using Microsoft.EntityFrameworkCore;
using Alfreelina_P1_AP1.Entidades;
using Alfreelina_P1_AP1.DAL;
using System.Linq;
using System;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Alfreelina_P1_AP1.BLL{
    public class CiudadesBLL{

        public static bool Guardar(Ciudades ciudades){
            if (!Existe(ciudades.CiudadesID))
                return Insertar(ciudades);
            else 
                return Modificar(ciudades);
        }

        private static bool Existe(int id){
            bool existe;
            Contexto contexto = new Contexto();
            try{
                existe = contexto.Ciudades.Any(c => c.CiudadesID == id);
            }
            catch(Exception){
                throw;

            } finally{
                contexto.Dispose();
            }
            return existe;
        }
        private static bool Insertar(Ciudades ciudades){
            bool Guardado;
            Contexto contexto = new Contexto();
            try{
                contexto.Ciudades.Add(ciudades);
                Guardado = contexto.SaveChanges()>0;
            }
            catch(Exception){
                throw;
               
            } finally{
                contexto.Dispose();
            }
            return Guardado;
        }

        private static bool Modificar(Ciudades ciudades){
            bool Modificado;
            Contexto contexto = new Contexto();
            try{
                contexto.Entry(ciudades).State = EntityState.Modified;
                Modificado = contexto.SaveChanges()>0;
            }
            catch(Exception){
                throw;
               
            } finally{
                contexto.Dispose();
            }
            return Modificado;
        }

      public static Ciudades Buscar(int id){
            Ciudades ciudades = new Ciudades();
            Contexto contexto = new Contexto();
            try{
                ciudades = contexto.Ciudades.Find(id);
            }
            catch(Exception){
                throw;
               
            } finally{
                contexto.Dispose();
            }
            return ciudades;
        }

        public static bool Eliminar(int id){
            bool Eliminado;
            Contexto contexto = new Contexto();
            try{
                var ciudades = contexto.Ciudades.Find(id);
                contexto.Entry(ciudades).State = EntityState.Deleted;
                Eliminado = contexto.SaveChanges()>0;
            }

            catch(Exception){
                throw;
               
            } finally{
                contexto.Dispose();
            }
            return Eliminado;
        }

    public static List <Ciudades> GetList(Expression<Func<Ciudades, bool>> productos)
        {
            List<Ciudades> Lista = new List<Ciudades>();
            Contexto contexto = new Contexto();

            try
            {
                Lista = contexto.Ciudades.Where(productos).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
    }

    }
    }