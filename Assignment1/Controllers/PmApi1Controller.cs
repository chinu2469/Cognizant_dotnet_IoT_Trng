#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment1.Data;
using Assignment1.Models;
using System.Xml;
using Newtonsoft.Json;


namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PmApi1Controller : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public PmApi1Controller(ApplicationDbContext db)
        {
            _db = db;
        }

        


        // list return for pm
        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<PmModel>? objDashboardList = _db.Pms;
            return Ok(objDashboardList);
        }

        // GET: api/PmApi1/5
        // single object return

        [HttpGet("{id}")]

        

        public object PMById(int id)
        {
            PmModel pmobj = new PmModel();
            
            var new1 = _db.Pms.FirstOrDefault(x => x.PM_Id == id);
            if (new1 != null)
            {
                pmobj = new1;
            }
            
            return Ok(pmobj);
           
        }

        public object PMByName(string name)
        {
            PmModel pmobj = new PmModel();

            var new1 = _db.Pms.FirstOrDefault(x => x.PM_Name == name);
            if (new1 != null)
            {
                pmobj = new1;
            }

            return Ok(pmobj);

        }


        // POST: api/PmApi1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754


        [HttpPost]
        public void PostPM(PmModel pmobj)
        {
            if (pmobj != null)
            {
                _db.Pms.Add(pmobj);
                _db.SaveChanges();
            }

        }
        



        // PUT: api/PmApi1/5      edit id return method
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

        [HttpPut("{id}")]
        public void PutDetails(int id, PmModel pmobj)
        {
            if (_db.Pms.Any(x => x.PM_Id == id) && pmobj.PM_Name != null)
            {
                var newpm = _db.Pms.FirstOrDefault(x => x.PM_Id == id);
                //newpm.PM_Id = pmobj.PM_Id;
                newpm.PM_Name = pmobj.PM_Name;
                newpm.Asset = pmobj.Asset;
                newpm.Schedules = pmobj.Schedules;
                newpm.Assigned_To = pmobj.Assigned_To;
                newpm.Location = pmobj.Location;

                _db.SaveChanges();

            }


        }

        

        // DELETE: api/PmApi1/5

        [HttpDelete("{id}")]
        public void DeleteById(int id)
        {
            if (_db.Pms.Any(x => x.PM_Id == id))
            {
                PmModel pmobj = _db.Pms.First(x => x.PM_Id == id);
                _db.Pms.Remove(pmobj);
                _db.SaveChanges();

            }
        }
        

        private bool PmExists(int id)
        {
            return _db.Pms.Any(e => e.PM_Id == id);
        }

        //[HttpPost]
        //public void copypm(int id)
        //{
        //    if (_db.Pms.Any(x => x.PM_Id == id))
        //    {
        //        PmModel pmobj = _db.Pms.First(x => x.PM_Id == id);
        //        PmModel newpm = new PmModel();
        //        newpm.PM_Name = pmobj.PM_Name;
        //        newpm.Asset = pmobj.Asset;
        //        newpm.Schedules = pmobj.Schedules;
        //        newpm.Assigned_To = pmobj.Assigned_To;
        //        newpm.Location = pmobj.Location;

        //        _db.Pms.Add(newpm);
        //        _db.SaveChanges();
        //    }
                

        //}
    }
}

/*//[HttpDelete("{id}")]
        public async Task<IActionResult> DeletePm(int id)
        {
            var pm = await _db.Pms.FindAsync(id);
            if (pm == null)
            {
                return NotFound();
            }

            _db.Pms.Remove(pm);
            await _db.SaveChangesAsync();

            return NoContent();
        }

    [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePm(int? id, PmModel pmobj)
        {
            var newpm = _db.Pms.Where(model => model.PM_Id == pmobj.PM_Id).FirstOrDefault();

            if (newpm != null)
            {
                newpm.PM_Id = pmobj.PM_Id;
                newpm.PM_Name = pmobj.PM_Name;
                newpm.Asset = pmobj.Asset;
                newpm.Schedules = pmobj.Schedules;
                newpm.Assigned_To = pmobj.Assigned_To;
                newpm.Location = pmobj.Location;

                _db.SaveChanges();
            }
            else
            {
                return NotFound();
            }



            return Ok();
        }

    [HttpPost]
        public async Task<ActionResult<PmModel>> PostPm(PmModel pmobj)
        {
            _db.Pms.Add(pmobj);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetPm", new { id = pmobj.PM_Id }, pmobj);
        }

    [HttpGet("{id}")]
        public async Task<ActionResult<PmModel>> GetPm(int id)
        {
            //var pmobj = await _db.Pms.FindAsync(id);
            var pmobj =  _db.Pms.Where(x => x.PM_Id == id);

            if (pmobj == null)
            {
                return NotFound();
            }

            return Ok(pmobj);
        }

 GET: api/PmApi1   https://localhost:44339/api/pmapi1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pm>>> GetPms()
        {
            return await _context.Pms.ToListAsync();
        }
//public IActionResult getPartsById(int id)
        //{
        //    var parts = _db.Pms.Where(p => p.PM_Id == id).FirstOrDefault();
        //    // To convert JSON text contained in string json into an XML node
        //    XmlDocument doc = JsonConvert.DeserializeXmlNode(parts);
        //    return Ok(doc);
        //}

*/