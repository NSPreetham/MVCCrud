﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;




namespace MVCCrud.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CrudServices.CompanyCRUD ReadCompany = new CrudServices.CompanyCRUD();
            List<Directory> CompanyList = ReadCompany.ReadCompanies();
            return View(CompanyList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}