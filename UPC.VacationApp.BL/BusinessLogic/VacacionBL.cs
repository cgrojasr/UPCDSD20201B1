using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.VacationApp.BL.DataAccess;

namespace UPC.VacationApp.BL.BusinessLogic
{
    public class VacacionBL
    {
        private readonly VacacionDA objVacacionDA;

        public VacacionBL()
        {
            objVacacionDA = new VacacionDA();
        }

        public int Registrar(Vacacion objVacacion) {
            try
            {
                return objVacacionDA.Registrar(objVacacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Vacacion Buscar(int IdVacacion)
        {
            try
            {
                return objVacacionDA.Buscar(IdVacacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Modificar(Vacacion objVacacion)
        {
            try
            {
                return objVacacionDA.Modificar(objVacacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(int IdVacacion)
        {
            try
            {
                return objVacacionDA.Eliminar(IdVacacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
