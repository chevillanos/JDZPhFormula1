using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JDZPhFormula1.Models;
using JDZPhFormula1.ViewModels;
using System.Data.Entity;
using JDZPhFormula1.Services;
using JDZPhFormula1.Repository;

namespace JDZPhFormula1.Controllers
{
    public class DriversController : Controller
    {
        // Test Run
        //private ApplicationDbContext _context;
        private readonly IDriverService _driverService;

        public DriversController()
        {
            _driverService = new DriverRepository();
        }

        public DriversController(IDriverService driverService)
        {
           _driverService = driverService;
        }

        // GET: Drivers
        public ActionResult Index()
        {
            return View();
        }

        // GET: Drivers/Details/5
        public ActionResult Details(int id)
        {
            var driver = _driverService.Details(id);

            if (driver == null)
                return HttpNotFound();

            return View(driver);
        }        

        // GET: Drivers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Drivers/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Drivers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Drivers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Drivers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Drivers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ByClassification(string classificationName)
        {
            #region mock drivers
            //var bronzeDrivers = new List<Driver>
            //{
            //    new Driver {
            //        Id = 1,
            //        Name = "Carl Henry",
            //        DriverStatus = 'A',
            //        JoiningDate = DateTime.Now,
            //        TeamId = 4,
            //        ClassificationId = 1,
            //        AvatarURL = "https://scontent.fmnl17-1.fna.fbcdn.net/v/t1.0-9/117389083_2020428021425707_3512632096438593950_n.jpg?_nc_cat=105&_nc_sid=09cbfe&_nc_ohc=cGiGV6Yqh9EAX_O_SFO&_nc_ht=scontent.fmnl17-1.fna&oh=a0e1a9c6dbaae382e702c6a542c11871&oe=5F92FE55"
            //    },
            //    new Driver
            //    {
            //        Id = 2,
            //        Name = "James Co",
            //        DriverStatus = 'A',
            //        JoiningDate = DateTime.Now,
            //        TeamId = 4,
            //        ClassificationId = 1,
            //        AvatarURL = "https://scontent.fmnl17-1.fna.fbcdn.net/v/t1.0-9/117389083_2020428021425707_3512632096438593950_n.jpg?_nc_cat=105&_nc_sid=09cbfe&_nc_ohc=cGiGV6Yqh9EAX_O_SFO&_nc_ht=scontent.fmnl17-1.fna&oh=a0e1a9c6dbaae382e702c6a542c11871&oe=5F92FE55"
            //    },
            //    new Driver
            //    {
            //        Id = 3,
            //        Name = "Jay Da Jose",
            //        DriverStatus = 'A',
            //        JoiningDate = DateTime.Now,
            //        TeamId = 4,
            //        ClassificationId = 1,
            //        AvatarURL = "https://scontent.fmnl17-1.fna.fbcdn.net/v/t1.0-9/117389083_2020428021425707_3512632096438593950_n.jpg?_nc_cat=105&_nc_sid=09cbfe&_nc_ohc=cGiGV6Yqh9EAX_O_SFO&_nc_ht=scontent.fmnl17-1.fna&oh=a0e1a9c6dbaae382e702c6a542c11871&oe=5F92FE55"
            //    }
            //};
            #endregion

            return View(_driverService.ByClassification(classificationName));

            //return View(classificationName + Classification.Bronze.ToString());
        }

        enum Classification
        {
            Bronze,
            Silver
        }
    }
}
