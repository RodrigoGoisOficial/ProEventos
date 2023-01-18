using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento()
                {
                    EventoId = 1,
                    Tema = "Angular e .NET 5",
                    Local = "Chapecó",
                    Lote = "Primeiro Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImageURL = "foto.png"
                },
                new Evento()
                {
                    EventoId = 2,
                    Tema = "Angular e .NET 5",
                    Local = "Xaxim",
                    Lote = "Segundo Lote",
                    QtdPessoas = 100,
                    DataEvento = DateTime.Now.AddDays(3).ToString(),
                    ImageURL = "foto.png"
                }
            };

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{id}")]
        public string Put()
        {
            return "E";
        }

        [HttpDelete("{id}")]
        public string Delete()
        {
            return "value";
        }
    }
}
