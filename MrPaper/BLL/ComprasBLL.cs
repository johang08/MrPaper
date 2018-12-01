using MrPaper.DAL;
using MrPaper.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MrPaper.BLL
{
    public class ComprasBLL
    {
        public static bool Guardar(Compras compras)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Compras.Add(compras) != null)
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

        public static bool Modificar(Compras compras)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var Anterior = db.Compras.Find(compras.CompraId);

                foreach (var item in Anterior.Productos)
                {
                    if (!compras.Productos.Exists(d => d.ProductosDetalleId == item.ProductosDetalleId))
                        db.Entry(item).State = EntityState.Deleted;
                }
                foreach (var item in compras.Productos)
                {
                    var estado = item.ProductosDetalleId > 0 ? EntityState.Modified : EntityState.Added;
                    db.Entry(item).State = estado;
                }
                db.Entry(compras).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Compras compras = contexto.Compras.Find(id);

                var Anterior = contexto.Compras.Find(compras.CompraId);
                foreach (var item in Anterior.Productos)
                {
                    if (!compras.Productos.Exists(d => d.ProductosDetalleId == item.ProductosDetalleId))
                        contexto.Entry(item).State = EntityState.Deleted;
                }

                contexto.Compras.Remove(compras);

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

        public static Compras Buscar(int id)
        {
            Contexto db = new Contexto();
            Compras compras = new Compras();
            try
            {
                compras = db.Compras.Find(id);
                if (compras == null)
                {
                    db.Dispose();
                    return compras;
                }

                compras.Productos.Count();
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return compras;
        }

        public static List<Compras> GetList(Expression<Func<Compras, bool>> expression)
        {
            List<Compras> compras = new List<Compras>();
            Contexto contexto = new Contexto();
            try
            {
                compras = contexto.Compras.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return compras;
        }
    }
}
