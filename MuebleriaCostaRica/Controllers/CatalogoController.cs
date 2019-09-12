using MuebleriaCostaRica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MuebleriaCostaRica.Controllers
{
    public class CatalogoController : ApiController
    {
        // api/catalogo
        public  IHttpActionResult Get()
        {
            return Ok(Inventario.Listar());
        }

        // api/catalogo
        public IHttpActionResult Get(string id)
        {
            return Ok(Inventario.ListarPorId(id));
        }


        public IHttpActionResult Post(Mueble pmueble)
        {
            Inventario.Agregar(pmueble);
            return Content(HttpStatusCode.Created, pmueble);
        }

        public IHttpActionResult Put(Mueble pmueble)
        {
            Inventario.Actualizar(pmueble);
            return Content(HttpStatusCode.OK, pmueble);
        }

        public IHttpActionResult Delete(Mueble pmueble)
        {
            Inventario.Eliminar(pmueble);
            return Content(HttpStatusCode.OK, pmueble);
        }
    }
}
