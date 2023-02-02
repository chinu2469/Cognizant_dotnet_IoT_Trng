
using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment1API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PMapiController : ControllerBase
    {
        private ApplicationDbContext _db;                              // object created for db
        public PMapiController(ApplicationDbContext db)
        {
            _db = db;
        }
    //    // GET: api/<PMapiController>
    //    [HttpGet]
    //    public IActionResult GetAllPM()
    //    {
    //        IEnumerable<PmModel>? objDashboardList = _db.Pms;
    //        return Ok(objDashboardList);
    //    }

    // GET api/<PMapiController>/5
    //[HttpGet("{id}")]
    //public object PMById(int id)
    //{
    //    PmModel pmobj = new PmModel();
    //    pmobj = _db.Pms.FirstOrDefault(x => x.PM_Id == id);
    //    return Ok(pmobj);
    //}

    // POST api/<PMapiController>     CREATE
    [HttpPost]
        public void PostPM( PmModel pmobj)
        {
            if (pmobj != null)
            {
                _db.Pms.Add(pmobj);
                _db.SaveChanges();
            }
            
        }

        
        // PUT api/<PMapiController>/5                                  update / edit
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

        // DELETE api/<PMapiController>/5
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
    }
}
