﻿using jobSalt.Models;
using jobSalt.Models.Feature.Housing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jobSalt.Controllers
{
    public class HousingController : Controller
    {
        HousingShepard shepard = new HousingShepard();

        public ActionResult Index(string filterString, int page = 0, int resultsPerPage = 10)
        {
            FilterBag filters = FilterBag.createFromURLQuery(Request.QueryString.ToString());

            ViewBag.FilterString = filters.JsonEncode();
            ViewBag.FilterBag = filters;

            // If being called from ajax return the partial view that has the next set of job posts
            if (Request.IsAjaxRequest())
            {
                return PartialView("Index_Partial", shepard.GetHousing(filters).ToArray());
            }

            return View();
        }

    }
}
