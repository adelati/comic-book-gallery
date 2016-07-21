using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
		public ActionResult detail(){

			if (DateTime.Today.DayOfWeek == DayOfWeek.Monday) {

				return Redirect("/");
			}

			return Content("Hello it is me: Comic Books Controller looool");

		}
    }
}
