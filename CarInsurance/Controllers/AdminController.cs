using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {

        private InsuranceEntities db = new InsuranceEntities();

        // GET: Admin
        public ActionResult Admin()
        {

            var insurees = db.Tables.ToList();
            var tables = new List<Table>();

            foreach (var insuree in insurees)
            {
                var table = new Table();
                table.Id = insuree.Id;
                table.FirstName = insuree.FirstName;
                table.LastName = insuree.LastName;
                table.EmailAddress = insuree.EmailAddress;
                table.DateOfBirth = insuree.DateOfBirth;
                table.CarYear = insuree.CarYear;
                table.CarMake = insuree.CarMake;
                table.CarModel = insuree.CarModel;
                table.DUI = insuree.DUI;
                table.SpeedingTickets = insuree.SpeedingTickets;
                table.CoverageType = insuree.CoverageType;
                table.Quote = Convert.ToDecimal(insuree.Quote);
                tables.Add(table);

            }

            return View(tables);
        }


    }
    
}