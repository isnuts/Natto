using Natto.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Natto.Controllers
{
    public class HomeController : Controller
    {

		private readonly IProductService _productService;

		public HomeController(IProductService productService)
		{
			_productService = productService;
		}
		//
		////// GET: /Home/


        public ActionResult Index()
        {
			//_productService.GetProductAll();
            return View();
        }

    }
}
