#nullable disable
using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using Newtonsoft.Json;



namespace Assignment1.Controllers
{
    public class PMController : Controller
    {

        private readonly ApplicationDbContext _db;

        Uri baseaddress = new Uri("https://localhost:44339/api");
        HttpClient client = new HttpClient();


        public PMController(ApplicationDbContext db)
        {
            _db = db;
            client = new HttpClient();
            client.BaseAddress = baseaddress;
        }

        int pages = 0;


        //get method for PM index page                                                                 GET ALL
        public IActionResult Index(int pg)
        {
            IEnumerable<PmModel> pms = new List<PmModel>();
            IEnumerable<PmModel> pmobj = new List<PmModel>();

            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/PmApi1/").Result;
            if (response != null)
            {
                string obj = response.Content.ReadAsStringAsync().Result;
                pms = JsonConvert.DeserializeObject<IEnumerable<PmModel>>(obj);
            }

            const int pagesize = 5;
            if (pg < 1)
            { pg = 1; }

            int cout = pms.Count();

            pages = (int)Math.Ceiling((decimal)cout/(decimal)pagesize);

            int listskip = (pg - 1) * pagesize;

            var objs = pms.Skip(listskip).Take(pagesize).ToList<PmModel>();
            ViewBag.pages = pages ;
            ViewBag.pagesize = pagesize;
            //pmobj = JsonConvert.DeserializeObject<IEnumerable<PmModel>>(objs);
            return View(objs);
        }




        //GET: PM/Details/5                                                        GET DETAILS
        public IActionResult Details(int? id)
        {
            PmModel pmobj = new PmModel();

            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/PmApi1/" + id).Result;

            //var test = response.Result;

            if (response.IsSuccessStatusCode)
            {

                string obj = response.Content.ReadAsStringAsync().Result;
                pmobj = JsonConvert.DeserializeObject<PmModel>(obj);
            }

            return View(pmobj);


        }



        // GET: PM/Create GET  CREATE
        public IActionResult Create()
        {
            return View();
        }



        // POST: PM/Create   this method complets create action on db               POST CREATE

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PmModel pmobj) 
       {
            

            HttpResponseMessage response = client.PostAsJsonAsync<PmModel>(client.BaseAddress + "/Pmapi1/", pmobj).Result;
            if (response.IsSuccessStatusCode)
            {

                return RedirectToAction("Index", pages);
            }

            return View("Create");

        }


        // GET: PM/Edit/5                                                                  GET EDIT
        public IActionResult Edit(int? id)
        {
            PmModel pmobj = new PmModel();

            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/PmApi1/" + id).Result;

            if (response.IsSuccessStatusCode)
            {

                string obj = response.Content.ReadAsStringAsync().Result;
                pmobj = JsonConvert.DeserializeObject<PmModel>(obj);
            }

            return View(pmobj);
        }



        // POST: PM/Edit/5                                                                    POST EDIT

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PmModel pmobj)
        {
            HttpResponseMessage response = client.PutAsJsonAsync<PmModel>(client.BaseAddress + "/Pmapi1/" + pmobj.PM_Id, pmobj).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index",1);
            }
            return View("Create");
        }




        // GET: PM/Delete/5                                                           GET DELETE
        public IActionResult Delete(int? id)
        {
            PmModel pmobj = new PmModel();

            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/PmApi1/" + id).Result;

            if (response.IsSuccessStatusCode)
            {

                string obj = response.Content.ReadAsStringAsync().Result;
                pmobj = JsonConvert.DeserializeObject<PmModel>(obj);
            }

            return View(pmobj);
        }



        //post delete                                                                   POST DELETE
        //k
        [HttpPost]
        public IActionResult DeleteConfirmed(int? id)
        { 
            HttpResponseMessage response = client.DeleteAsync(client.BaseAddress + "/PmApi1/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }

            return View("Delete");

        }


        // checks for existance of id                                                EXISTS
        private bool PmExists(int id)
        {
            return _db.Pms.Any(e => e.PM_Id == id);
        }
        public IActionResult AssetNew()
        {
            return View();
        }





        //partial views for pm

        public IActionResult _SelectAsset(int id) //Partial View for select aset
        {
            PmModel pmobj = new PmModel();

            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/PmApi1/" + id).Result;
            if (response.IsSuccessStatusCode)
            {

                string obj = response.Content.ReadAsStringAsync().Result;
                pmobj = JsonConvert.DeserializeObject<PmModel>(obj);
            }

            return View("_SelectAsset", pmobj);
        }

      

      
        public IActionResult _asset(int id) //Partial View for Modal //GET
  {
            PmModel pmobj = new PmModel();

            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/PmApi1/" + id).Result;

            //var test = response.Result;

            if (response.IsSuccessStatusCode)
            {

                string obj = response.Content.ReadAsStringAsync().Result;
                pmobj = JsonConvert.DeserializeObject<PmModel>(obj);
            }

            return View(pmobj);
        }
        //[HttpPost]
        //public ActionResult _asset() //POST
        //{
           
        //}

        public IActionResult ShowPartial()
        {
            IEnumerable<PmModel> pms = new List<PmModel>();

            client.BaseAddress = new Uri("https://localhost:44339/api/");     //https://localhost:7133/api/PMapi/  //https://localhost:44339/PM
            var response = client.GetAsync("Pmapi1");
            response.Wait();
            var test = response.Result;

            if (response != null)
            {
                var display = test.Content.ReadAsAsync<IEnumerable<PmModel>>();
                display.Wait();

                pms = display.Result;
            }



            return PartialView("_NewTemplate", pms);
        }

        
        public IActionResult CopyPm(int id)
        {
            PmModel pmobj = new PmModel();

            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/PmApi1/" + id).Result;

            if (response.IsSuccessStatusCode)
            {

                string obj = response.Content.ReadAsStringAsync().Result;
                pmobj = JsonConvert.DeserializeObject<PmModel>(obj);
            }

            
            PmModel newpm = new PmModel();

            newpm.PM_Name = pmobj.PM_Name;
            newpm.Asset = pmobj.Asset;
            newpm.Schedules = pmobj.Schedules;
            newpm.Assigned_To = pmobj.Assigned_To;
            newpm.Location = pmobj.Location;

            HttpResponseMessage re = client.PostAsJsonAsync<PmModel>(client.BaseAddress + "/Pmapi1/", pmobj).Result;
            if(re.IsSuccessStatusCode)
                return View("Index", pages);

            return View();
            //return PartialView("Details", this._db.Pms.Find(PM_Id));
        }


    }

}


