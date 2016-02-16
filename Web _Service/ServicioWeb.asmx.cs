using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Runtime.Serialization;

namespace Web__Service
{
    /// <summary>
    /// Descripción breve de ServicioWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWeb : System.Web.Services.WebService
    {

        [WebMethod]
        public int autenticacion(string nombre, string contraseña)
        {
            Modelo.entidades.Usuario usuario = Modelo.consultas.isUsuario(nombre,contraseña);
            if (usuario != null)
            {
                return 1;
            }
            return 0;
        }
        [WebMethod]
        public Modelo.entidades.Obra consulta_Obras(string nombre)
        {
            return Modelo.consultas.isObraMovil(nombre);
        }
    }
}
