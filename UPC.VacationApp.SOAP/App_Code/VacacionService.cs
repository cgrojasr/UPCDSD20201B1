using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UPC.VacationApp.BL;
using UPC.VacationApp.BL.BusinessLogic;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "VacacionService" in code, svc and config file together.
public class VacacionService : IVacacionService
{
    private readonly VacacionBL objVacacionBL;

    public VacacionService()
    {
        objVacacionBL = new VacacionBL();
    }

    public bool Actualizar(VacacionModel objVacacion)
    {
        try
        {
            var vacacion = new Vacacion
            {
                Id = objVacacion.Id,
                IdUsuario = objVacacion.IdUsuario,
                FechaInicio = objVacacion.FechaInicio,
                FechaFinal = objVacacion.FechaFinal,
                Activo = objVacacion.Activo,
                IdUsuarioModifico = objVacacion.IdUsuarioRegistro
            };

            var rpta = objVacacionBL.Modificar(vacacion);

            return rpta;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public VacacionModel Buscar(int Id)
    {
        var objVacacion = new VacacionModel();
        try
        {
            var vacacion = objVacacionBL.Buscar(Id);

            objVacacion.Id = vacacion.Id;
            objVacacion.IdUsuario = vacacion.IdUsuario;
            objVacacion.FechaInicio = vacacion.FechaInicio;
            objVacacion.FechaFinal = vacacion.FechaFinal;
            objVacacion.Activo = vacacion.Activo;
        }
        catch (Exception ex)
        {
            objVacacion.MessageError = ex.Message;
        }

        return objVacacion;
    }

    public bool Eliminar(int Id)
    {
        try
        {
            var rpta = objVacacionBL.Eliminar(Id);
            return rpta;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int Registrar(VacacionModel objVacacion)
    {
        try
        {
            var vacacion = new Vacacion()
            {
                IdUsuario = objVacacion.IdUsuario,
                FechaInicio = objVacacion.FechaInicio,
                FechaFinal = objVacacion.FechaFinal,
                Activo = objVacacion.Activo,
                IdUsuarioRegistro = objVacacion.IdUsuarioRegistro
            };
            var Id= objVacacionBL.Registrar(vacacion);

            return Id;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
