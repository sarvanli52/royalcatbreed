using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using royalcatbreed.Models;
namespace royalcatbreed.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        catbreedEntities db = new catbreedEntities();
        [HttpGet]
        public ActionResult Index(string cat_name)
        {

            List<SelectListItem> getCatNames = (from i in db.cats_front_page.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = i.cat_name,
                                                    Value = i.id.ToString()
                                                }).ToList();
            ViewBag.itm = getCatNames;



            using (catbreedEntities db = new catbreedEntities())

            {
                var model = db.cats_front_page.ToList();
                return View(model);

            }


        }
        [Route("About")]
        public ActionResult About()
        {
            return View();
        }


        [Route("cat-breed/{cat_name}")]
        public ActionResult CatBreed(string cat_name)
        {

            using (catbreedEntities db = new catbreedEntities())
            {

                var model = db.cats_front_page.Where(x => x.cat_name == cat_name).FirstOrDefault();
                if (model == null)
                {
                    return HttpNotFound();
                }
                return View(model);
            }

        }

        [HttpGet]
        [Route("breed-info-search")]
        public ActionResult CatBreedSearchResult(string p)
        {

            using (catbreedEntities db = new catbreedEntities())

            {

                var cats = from c in db.cats_front_page select c;
                if (!string.IsNullOrEmpty(p)){

                    cats = cats.Where(m => m.cat_name.Contains(p));
                }
                return View(cats.ToList());
               
                //var model = db.cats_front_page.ToList();
                //return View(model);

            }


        }

        [Route("cat-problems/{cat_name}")]
        public ActionResult CatProblems(string cat_name)
        {

            using (catbreedEntities db = new catbreedEntities())
            {

                var model = db.cats_front_page.Where(x => x.cat_name == cat_name).FirstOrDefault();
                if (model == null)
                {
                    return HttpNotFound();
                }
                return View(model);
            }

        }

        [Route("home-instructions/{cat_name}")]
        public ActionResult HomeInstructions(string cat_name)
        {

            using (catbreedEntities db = new catbreedEntities())
            {

                var model = db.cats_front_page.Where(x => x.cat_name == cat_name).FirstOrDefault();
                if (model == null)
                {
                    return HttpNotFound();
                }
                return View(model);
            }

        }

        [Route("cat-nutrition/{cat_name}")]
        public ActionResult CatNutrition(string cat_name)
        {

            using (catbreedEntities db = new catbreedEntities())
            {

                var model = db.cats_front_page.Where(x => x.cat_name == cat_name).FirstOrDefault();
                if (model == null)
                {
                    return HttpNotFound();
                }
                return View(model);
            }

        }

        [Route("cat-behavior-training/{cat_name}")]
        public ActionResult CatBehaviorTraining(string cat_name)
        {

            using (catbreedEntities db = new catbreedEntities())
            {

                var model = db.cats_front_page.Where(x => x.cat_name == cat_name).FirstOrDefault();
                if (model == null)
                {
                    return HttpNotFound();
                }
                return View(model);
            }

        }

        [Route("cat-grooming/{cat_name}")]
        public ActionResult CatGrooming(string cat_name)
        {

            using (catbreedEntities db = new catbreedEntities())
            {

                var model = db.cats_front_page.Where(x => x.cat_name == cat_name).FirstOrDefault();
                if (model == null)
                {
                    return HttpNotFound();
                }
                return View(model);
            }

        }



    }
}