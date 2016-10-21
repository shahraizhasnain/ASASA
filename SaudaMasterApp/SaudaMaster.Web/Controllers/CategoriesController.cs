using System.Linq;
using System;
using System.Web.Mvc;
using SaudaMaster.SharedModel;
using SaudaMaster.Services;
using System.Web;
using System.IO;

namespace SaudaMaster.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategoryService CategoryServices;


        public CategoriesController()
            : this(new CategoryServices())
        {

        }

        public CategoriesController(ICategoryService CategoryServices)
        {
            this.CategoryServices = CategoryServices;
        }

        public ActionResult Index()
        {
                ViewBag.Category = new CategoryViewModel();
                CategoryViewModel viewModel = new CategoryViewModel();
                viewModel.CategoryList = CategoryServices.ReturnAllCategories().ToList();
                return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(CategoryViewModel collection, HttpPostedFileBase file)
        {

            if (ModelState.IsValid)
            {
                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(("/Content/img"), fileName);
                    var SavePath = Path.Combine(Server.MapPath("~/Content/img"), fileName);
                    collection.CategoryImage = path;
                    file.SaveAs(SavePath);
                    collection.CategoryID = Convert.ToInt16(Session["CategoryID"]);
                    CategoryServices.CreateCategory(collection);
                }
            }
            return RedirectToAction("Index");
        }
    }
}