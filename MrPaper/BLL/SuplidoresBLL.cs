using MrPaper.DAL;
using MrPaper.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MrPaper.BLL
{
    public class SuplidoresBLL
    {
        public static bool Guardar(Suplidores suplidor)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Suplidores.Add(suplidor) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Suplidores suplidor)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(suplidor).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Suplidores suplidor = contexto.Suplidores.Find(id);

                contexto.Suplidores.Remove(suplidor);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static Suplidores Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Suplidores suplidor = new Suplidores();

            try
            {
                suplidor = contexto.Suplidores.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return suplidor;
        }

        public static List<Suplidores> GetList(Expression<Func<Suplidores, bool>> expression)
        {
            List<Suplidores> suplidor = new List<Suplidores>();
            Contexto contexto = new Contexto();
            try
            {
                suplidor = contexto.Suplidores.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return suplidor;
        }
    }

}
