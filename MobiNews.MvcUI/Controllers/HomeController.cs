﻿using mobiNews.Service.Services;
using MobiNews.Core.Enums;
using MobiNews.Data.Models;
using MobiNews.MvcUI.Classes.Extensions;
using MobiNews.MvcUI.Models;
using MobiNews.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobiNews.MvcUI.Controllers
{
    public class HomeController : Controller
    {
        private ISupplierService _supplierService;
        private IStoriesService _storiesService;
        private IImportMethodHelper _importMethodHelper;

        public HomeController(ISupplierService supplierService, 
            IStoriesService storiesService, 
            IImportMethodHelper importMethodHelper)
        {
            _supplierService = supplierService;
            _storiesService = storiesService;
            _importMethodHelper = importMethodHelper;
        }

        public ActionResult Index()
        {
            var model = new NewStoriesModel();

            var stories = _storiesService.GetStories().ToList();

            if(stories != null)
            {
                model.Stories = stories.MapNewStoriesToStories();
            }

            return View(model);
        }

        public ActionResult Suppliers(int? pageNumber)
        {
            ViewBag.Message = "Suppliers - Add, Edit, Delete Suppliers.";

            var model = new SupplierModel()
            {
                PageNumber = (pageNumber != null ? Convert.ToInt32(pageNumber) : 1),
                PageSize = 5
            };

            var suppliers = _supplierService.GetSuppliers();

            if (suppliers != null)
            {
                // get the suppliers to display depending on the page we are on
                model.Suppliers = suppliers.OrderBy(o => o.SupplierID)
                    .Skip(model.PageSize * (model.PageNumber - 1))
                    .Take(model.PageSize).ToList();

                // get a total count of the pages
                model.PageCount = suppliers.Count();
                var page = (model.PageCount / model.PageSize) 
                    - (model.PageCount % model.PageSize == 0 ? 1 : 0);
            }

            return View(model);
        }

        public ActionResult GetSupplierById(int id)
        {
            var supplier = _supplierService.GetSupplier(s => s.SupplierID == id);

            if(supplier != null && supplier.SupplierID > 0)
            {
                var model = new SupplierModel()
                {
                    SupplierId = supplier.SupplierID,
                    SupplierName = supplier.SupplierName,
                    NotificationUrl = supplier.NotificationURL
                };

                return PartialView("_GridEditPartial", model);
            }

            return View();
        }

        public ActionResult AddSupplier(SupplierModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var dataModel = new Supplier()
                    {
                        SupplierName = model.SupplierName,
                        NotificationURL = model.NotificationUrl
                    };

                    _supplierService.Create(dataModel);
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /*dex*/)
            {
                // log dex
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }

            return View(model);
        }

        public ActionResult GetFeedData(SupplierModel model)
        {
            if(model != null && !string.IsNullOrEmpty(model.FeedURL))
            {
                // fetch the XML feed
                // inflate the entity with the xml data
                // return the status

                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult GetFTPData(SupplierModel model)
        {
            if (model != null && !string.IsNullOrEmpty(model.FTPPath))
            {
                // fetch the ftp files
                // store the image to the local image storage path
                // inflate the entity with the xml data from the file
                // return the status

                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult ImportMethods()
        {
            ViewBag.Message = "";

            var model = new ImportMethodModel();

            var importMethodsData = _importMethodHelper.LoadImportMethods();

            if(importMethodsData != null && importMethodsData.importMethods.Count() > 0)
            {
                model = new ImportMethodModel()
                {
                    ImportMethods = importMethodsData.importMethods.MapJsonImportMethodsToModel().ToList(),
                    ImportTypes = _importMethodHelper.GetSelectListItemFromEnum<ImportType>().ToList()
                };
            }
            else
            {
                model = new ImportMethodModel()
                {
                    ImportMethods = new List<ImportMethod>(),
                    ImportTypes = _importMethodHelper.GetSelectListItemFromEnum<ImportType>().ToList()
                };
            }

            return View(model);
        }

        public ActionResult AddImportMethod(ImportMethodModel model)
        {
            // TODO: add import method to JSON file

            return View(model);
        }
    }
}