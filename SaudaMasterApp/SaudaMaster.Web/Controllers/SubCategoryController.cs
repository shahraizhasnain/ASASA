using System.Linq;
using System;
using System.Web.Mvc;
using SaudaMaster.SharedModel;
using SaudaMaster.Services;
using System.Web;
using System.IO;

namespace SaudaMaster.Web.Controllers
{
    public class SubCategoryController : Controller
    {
        private ISubCategoryService subcategoryservices;

        public SubCategoryController()
            : this(new SubCategoryServices())
        {

        }

        public SubCategoryController(ISubCategoryService subcategoryservice)
        {
            this.subcategoryservices = subcategoryservice;
        }

        public ActionResult Index()
        {
            ViewBag.SubCategory = new SubCategoryViewModel();
            SubCategoryViewModel viewModel = new SubCategoryViewModel();
            viewModel.SubCategoryList = subcategoryservices.ReturnAllSubCategory().ToList();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(SubCategoryViewModel collection, HttpPostedFileBase file)
        {

            if (ModelState.IsValid)
            {
                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(("/Content/img"), fileName);
                    var SavePath = Path.Combine(Server.MapPath("~/Content/img"), fileName);
                    collection.SubCategoryImage = path;
                    file.SaveAs(SavePath);
                    collection.SubCategoryID = Convert.ToInt16(Session["SubCategoryID"]);
                    subcategoryservices.CreateSubCategory(collection);
                }
            }
            return RedirectToAction("Index");
        }
    }
}