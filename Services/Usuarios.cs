using Newtonsoft.Json;
using System.Collections.Generic;

namespace Services
{
    public class Usuarios
    {

        public string Email { get; set; }   
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public int IdCliente { get; set; }


        public static List<Usuarios> Listar()
        {

            string listUsuariosJson= new Rest.ConsumirServicios("https://633a36cbe02b9b64c60d2f51.mockapi.io/parcial/Usuarios").CreateObject();
            List<Usuarios> listUsuarios = JsonConvert.DeserializeObject<List<Usuarios>>(listUsuariosJson);

            return listUsuarios;

        }

    }






}