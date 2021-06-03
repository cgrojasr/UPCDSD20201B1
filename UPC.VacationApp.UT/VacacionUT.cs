using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UPC.VacationApp.BL;
using UPC.VacationApp.BL.BusinessLogic;

namespace UPC.VacationApp.UT
{
    [TestClass]
    public class VacacionUT
    {
        [TestMethod]
        public void Regitrar()
        {
            var objVacacion = new Vacacion() {
                Activo = true,
                FechaInicio = DateTime.Now,
                FechaFinal = DateTime.Now,
                IdUsuarioRegistro = 0,
                FechaRegistro = DateTime.Now,
                IdUsuario = 1
            };

            var objVacacionBL = new VacacionBL();
            var id = objVacacionBL.Registrar(objVacacion);

            Assert.AreEqual(1, id);
        }

        [TestMethod]
        public void Buscar()
        {
            var objVacacionBL = new VacacionBL();
            var objVacacion = objVacacionBL.Buscar(1);

            Assert.AreEqual(1, objVacacion.Id);
        }

        [TestMethod]
        public void Modificar()
        {
            var objVacacion = new Vacacion()
            {
                Id = 1,
                Activo = false,
                FechaInicio = DateTime.Now,
                FechaFinal = DateTime.Now,
                IdUsuarioModifico = 1,
            };

            var objVacacionBL = new VacacionBL();
            var rpta = objVacacionBL.Modificar(objVacacion);

            Assert.AreEqual(true, rpta);
        }

        [TestMethod]
        public void Eliminar()
        {
            var objVacacionBL = new VacacionBL();
            var rpta = objVacacionBL.Eliminar(1);

            Assert.AreEqual(true, rpta);
        }
    }
}
