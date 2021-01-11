using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CovidRecordLib;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace covidservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CovidRecordsController : ControllerBase
    {

        private static int idCount = 6;
        //static list
        private static readonly List<CovidRecord> covidRecords = new List<CovidRecord>()
        {
            new CovidRecord(1, "Roskilde", 4, 4, 2),
            new CovidRecord(2, "Slagelse", 5, 5, 4),
            new CovidRecord(3, "Rønne", 6, 6, 6),
            new CovidRecord(4, "Køge", 2, 1, 1),
            new CovidRecord(5, "Kastrup", 3, 2, 2),
        };


        // GET: api/<CovidRecordsController>
        [HttpGet]
        public IEnumerable<CovidRecord> Get()
        {
            return covidRecords;
        }

        // GET api/<CovidRecordsController>/5
        [HttpGet("{id}")]
        public CovidRecord Get(int id)
        {
            return covidRecords.Find(i => i.Id == id);
        }

        // GET by city
        [HttpGet("city/{city}")]
        public IEnumerable<CovidRecord> GetRecordsByCity(string city)
        {
            return covidRecords.FindAll(a => a.City == city);
        }

        //POST
        [HttpPost]
        public void Post([FromBody] CovidRecord value)
        {
            value.Id = idCount++;
            covidRecords.Add(value);
        }
    }
}
