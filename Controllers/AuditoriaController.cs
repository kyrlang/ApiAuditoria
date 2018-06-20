using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiAuditoria.Models;

namespace ApiAuditoria.Controllers
{
    public class AuditoriaController : ApiController
    {

        [HttpPost]
        [Route("api/v1/auditoria/log")]
        public IHttpActionResult Log([FromBody] Logs log)
        {
            if (log != null)
            {
                long unixDate = log.DataHora;
                DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                DateTime date = start.AddMilliseconds(unixDate).ToLocalTime();
                return Ok("Log inserido - Mensagem: " + log.Mensagem + " - Opercao: " + log.Operacao + " - Incluido em: " + date.ToString("dd/MM/yyyy HH:mm:ss"));
            }
            else
                return BadRequest("Error");
        }

        [HttpGet]
        [Route("api/v1/auditoria/log")]
        public IHttpActionResult Log()
        {
            if (null != null)
                return Ok("Ok");
            else
                return BadRequest("Error");
        }

    }
}
