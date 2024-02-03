using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Agentesfiguras.Context;
using Agentesfiguras.Modelofigura;

namespace Agentesfiguras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionalidaddosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FuncionalidaddosController(AppDbContext context)
        {
            _context = context;
        }


        

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Funcionalidaddos>>> PostFuncionalidaddos(Funcionalidades funcionalidades)
        {
            List<Funcionalidaddos> listaresp = new List<Funcionalidaddos>();
            String guardarnumeral = "";

            if (funcionalidades.Nombrefuncionalidad == "Escalera" && funcionalidades.Nombreagente == "Agente A" && funcionalidades.Numn>0 && funcionalidades.Numn<100)
            {
              for(var i = 1; i<=funcionalidades.Numn; i++)
                {
                   if(i == 1)
                    {
                        
                        listaresp.Add(new Funcionalidaddos() { Nombrefuncionalidad = funcionalidades.Nombrefuncionalidad, Nombreagente = funcionalidades.Nombreagente, Numn = funcionalidades.Numn, Respuestafingura = "#" });
                        
                    }

                   if(i > 1)
                    {
                        for(var j=0; j<i; j++)
                        {
                            guardarnumeral = guardarnumeral+"#";
                        }
                        listaresp.Add(new Funcionalidaddos() { Nombrefuncionalidad = funcionalidades.Nombrefuncionalidad, Nombreagente = funcionalidades.Nombreagente, Numn = funcionalidades.Numn, Respuestafingura = guardarnumeral });
                        guardarnumeral = "";
                    }
                }
                return listaresp;
            }

            if (funcionalidades.Nombrefuncionalidad == "Escalera" && funcionalidades.Nombreagente == "Agente B" && funcionalidades.Numn > 0 && funcionalidades.Numn < 100)
            {
                for (var i = funcionalidades.Numn; i > 0; i--)
                {
                    

                        for(var j = 0; j< i; j++)
                        {
                        guardarnumeral = guardarnumeral + "#";
                         }
                        listaresp.Add(new Funcionalidaddos() { Nombrefuncionalidad = funcionalidades.Nombrefuncionalidad, Nombreagente = funcionalidades.Nombreagente, Numn = funcionalidades.Numn, Respuestafingura = guardarnumeral  });
                        guardarnumeral = "";
                   
                }
                return listaresp;
            }

            if (funcionalidades.Nombrefuncionalidad == "Escalera" && funcionalidades.Nombreagente == "Agente C" && funcionalidades.Numn > 0 && funcionalidades.Numn < 100)
            {
                int contt = funcionalidades.Numn;

                while (contt <= ((funcionalidades.Numn + 2) + funcionalidades.Numn))
                {
                    for (var j = 0; j < contt; j++)
                    {
                        guardarnumeral = guardarnumeral + "#";
                    }

                    listaresp.Add(new Funcionalidaddos() { Nombrefuncionalidad = funcionalidades.Nombrefuncionalidad, Nombreagente = funcionalidades.Nombreagente, Numn = funcionalidades.Numn, Respuestafingura = "" + guardarnumeral + "" });
                    guardarnumeral = "";
                    contt = contt + 2;
                }

                
                int cont = (funcionalidades.Numn * 2);
             

                while(cont > 0 && cont >= funcionalidades.Numn)
                {
                    for(var j = 0; j < cont; j++)
                    {
                        guardarnumeral = guardarnumeral + "#";
                    }

                    listaresp.Add(new Funcionalidaddos() { Nombrefuncionalidad = funcionalidades.Nombrefuncionalidad, Nombreagente = funcionalidades.Nombreagente, Numn = funcionalidades.Numn, Respuestafingura = "" + guardarnumeral + "" });
                    cont = cont - 2;
                    guardarnumeral = "";
                }
                return listaresp;
            }





            return NotFound();
        }

        

       
    }
}
