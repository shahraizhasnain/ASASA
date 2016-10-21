using System.Linq;
using System;
using System.Web.Mvc;
using SaudaMaster.SharedModel;
using SaudaMaster.Services;
using System.Web;
using System.IO;

namespace SaudaMaster.Web.Controllers
{
    public class BrandsController : Controller
    {
        private IBrandService brandServices;

        public BrandsController()
            : this(new BrandServices())
        {

        }

        public BrandsController(IBrandService brandService)
        {
            this.brandServices = brandService;
        }

        public ActionResult Index()
        {
                ViewBag.Brand = new BrandViewModel();
                BrandViewModel viewModel = new BrandViewModel();
                viewModel.BrandList = brandServices.ReturnAllBrands().ToList();
                return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(BrandViewModel collection, HttpPostedFileBase file)
        {

            if (ModelState.IsValid)
            {
                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(("/Content/img"), fileName);
                    var SavePath = Path.Combine(Server.MapPath("~/Content/img"), fileName);
                    collection.BrandImage = path;
                    file.SaveAs(SavePath);
                    collection.BrandID = Convert.ToInt16(Session["BrandID"]);
                    brandServices.CreateBrand(collection);
                }
            }
            return RedirectToAction("Index");
        }
    }
}