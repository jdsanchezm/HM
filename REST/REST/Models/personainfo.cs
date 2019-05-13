using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace REST.Models
{
    [DataContract]
    public class personainfo
    {
        [DataMember(Name = "idPersona")] public int IdPersona { get; set; }
        [DataMember(Name = "NoDocumento")] public int NoDocumento { get; set; }
        [DataMember(Name = "nombre")]public string nombre { get; set; }
        [DataMember(Name = "edad")] public int edad { get; set; }
        [DataMember(Name = "ocupacion")] public string ocupacion { get; set; }
    }
}