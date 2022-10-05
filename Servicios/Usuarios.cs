using Newtonsoft.Json;

namespace Servicios
{
    public class Usuarios
    {
        public string email { get; set; }   
        public string nombre { get; set; }
        public string clave { get; set; }
        public int idCliente { get; set; }


        public List<Usuarios> Listar()
        {

            string listUsuariosJson= new Rest.ConsumirServicios("https://631914666b4c78d91b357014.mockapi.io/Clientes").CreateObject();
            var listProductos = JsonConvert.DeserializeObject<List<Usuarios>>(listUsuariosJson);


        }

    }






}