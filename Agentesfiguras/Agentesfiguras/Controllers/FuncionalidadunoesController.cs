using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Agentesfiguras.Context;
using Agentesfiguras.Modelofigura;
using System.Collections.Immutable;

namespace Agentesfiguras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionalidadunoesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FuncionalidadunoesController(AppDbContext context)
        {
            _context = context;
        }

        
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Funcionalidaduno>>> PostFuncionalidaduno(String nombreagente)
        {

            if (nombreagente == "Agente A")
            {

                List<Funcionalidaduno> listarresp = new List<Funcionalidaduno>();

                int[] temp_int = new int[10] { 20, 10, 15, 29, 30, 9, 8, 6, 7, 9 };

                float sum = 0;
                float cantidad = temp_int.Length;
                for (var i = 0; i < temp_int.Length; i++)
                {
                    sum = sum + temp_int[i];
                }

                listarresp.Add(new Funcionalidaduno() { Nombreagente = nombreagente, Numn = temp_int.Length, Respuestaalatendencia = (sum/cantidad), Datosevaluados = "20, 10, 15, 29, 30, 9, 8, 6, 7, 9" });
                return listarresp;
            }

            if(nombreagente == "Agente B")
            {
                List<Funcionalidaduno> listarresp = new List<Funcionalidaduno>();
                
                int[] temp_int = new int[10] { 20, 10, 15, 29, 30, 9, 8, 6, 7, 9 };
                double sumarmonica = 0;
                

                for (var i = 0; i< temp_int.Length; i++)
                {
                    double sumcoe = (1/(((float)temp_int[i])));
                    sumarmonica = sumarmonica + (sumcoe);
                }

               
                    listarresp.Add(new Funcionalidaduno() { Nombreagente = nombreagente, Numn = temp_int.Length, Respuestaalatendencia = (temp_int.Length/sumarmonica), Datosevaluados = "20, 10, 15, 29, 30, 9, 8, 6, 7, 9" });
                    return listarresp;

            }

            if (nombreagente == "Agente C")
            {
                List<Funcionalidaduno> listarresp = new List<Funcionalidaduno>();
                int[] temp_int = new int[10] { 20, 10, 15, 29, 30, 9, 8, 6, 7, 9 };

                int aux = 0;

                for(var i = 0; i< temp_int.Length; i++)
                {
                    if ( (int)temp_int[i] > (int)temp_int[i+1])
                    {
                        aux = (int)temp_int[i];
                        temp_int[i] = (int)temp_int[i+1];
                        temp_int[i + 1] = aux;
                    }
                }

                
                if(temp_int.Length % 2  == 0)
                {
                   
                   
                    listarresp.Add(new Funcionalidaduno() { Nombreagente = nombreagente, Numn = temp_int.Length, Respuestaalatendencia = (((int)temp_int[(temp_int.Length/2)-1]+ (temp_int.Length / 2))), Datosevaluados = "20, 10, 15, 29, 30, 9, 8, 6, 7, 9" });
                    return listarresp;
                }

                else
                {
                    listarresp.Add(new Funcionalidaduno() { Nombreagente = nombreagente, Numn = temp_int.Length, Respuestaalatendencia = (((int)temp_int[(temp_int.Length / 2)])), Datosevaluados = "20, 10, 15, 29, 30, 9, 8, 6, 7, 9" });
                    return listarresp;
                }
                

            }

                return NoContent();
          

           


           
        }


    }
}
