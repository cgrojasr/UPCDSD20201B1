using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.VacationApp.BL.DataAccess
{
    interface IVacacionDA {
        int Registrar(Vacacion objVacacion);
        Vacacion Buscar(int IdVacacion);
        Vacacion BuscarConFirst(int IdVacacion);
        bool Modificar(Vacacion objVacacion);
        bool Eliminar(int IdVacacion);
    }

    class VacacionDA : IVacacionDA
    {
        private readonly dbVacationDataContext dc;
        public VacacionDA()
        {
            dc = new dbVacationDataContext();
        }

        public Vacacion Buscar(int IdVacacion)
        {
            try
            {
                var query = (from vac in dc.Vacacions
                            where vac.Id.Equals(IdVacacion)
                            select vac).Single();

                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Vacacion BuscarConFirst(int IdVacacion)
        {
            var query = dc.Vacacions.First(x => x.Id.Equals(IdVacacion));

            return query;
        }

        public bool Eliminar(int IdVacacion)
        {
            try
            {
                var query = dc.Vacacions.First(x => x.Id.Equals(IdVacacion));
                dc.Vacacions.DeleteOnSubmit(query);
                dc.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Modificar(Vacacion objVacacion)
        {
            try
            {
                var query = dc.Vacacions.First(x => x.Id.Equals(objVacacion.Id));

                query.FechaInicio = objVacacion.FechaInicio;
                query.FechaFinal = objVacacion.FechaFinal;
                query.FechaModificacion = DateTime.Now;
                query.IdUsuarioModifico = objVacacion.IdUsuarioModifico;
                query.Activo = objVacacion.Activo;

                dc.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int Registrar(Vacacion objVacacion)
        {
            try
            {
                dc.Vacacions.InsertOnSubmit(objVacacion);
                dc.SubmitChanges();

                return objVacacion.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
