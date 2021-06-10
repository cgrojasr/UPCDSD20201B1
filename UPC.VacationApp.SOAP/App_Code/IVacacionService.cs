using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVacacionService" in both code and config file together.
[ServiceContract]
public interface IVacacionService
{
    [OperationContract]
    int Registrar(VacacionModel objVacacion);
    [OperationContract]
    VacacionModel Buscar(int Id);
    [OperationContract]
    bool Actualizar(VacacionModel objVacacion);
    [OperationContract]
    bool Eliminar(int Id);
}

[DataContract]
public class VacacionModel { 
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public int IdUsuario { get; set; }
    [DataMember]
    public DateTime FechaInicio { get; set; }
    [DataMember]
    public DateTime FechaFinal { get; set; }
    [DataMember]
    public int IdUsuarioRegistro { get; set; }
    [DataMember]
    public bool Activo { get; set; }
    [DataMember]
    public string MessageError { get; set; }
}
