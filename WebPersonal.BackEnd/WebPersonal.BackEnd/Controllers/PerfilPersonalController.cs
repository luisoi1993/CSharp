using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebPersonal.BackEnd.Controllers
{
  //  [Route("api/[controller]")]
    [ApiController]
    public class PerfilPersonalController : ControllerBase
    {
        [HttpGet("LeerPerfil/{id}")]
       
        public string Get(int id)
        {
                // codigo para leer de la base de datos
                return id switch
                {
                    1 => "Ivan",
                    2 => "Curso",
                    _ => throw new NotSupportedException("El id no es válido")
                };  
        }

       public string Post(PerfilPersonalDto perfilPersonal)
        {

            //Guardar perfil en la base de datos.

            return perfilPersonal.Nombre;

        }
    }

    public class PerfilPersonalDto
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }
    }
}
