using DAL.Model;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectWebMvc.Controllers
{
    public class AuthorController : Controller
    {
       // public AuteurRepository _AuteurRepository;

        // AuteurRepository _AuteurRepository = new AuteurRepository();



        private  AuteurRepository _AuteurRepository;
        public AuthorController(AuteurRepository AuteurRepository)
           {
                _AuteurRepository = AuteurRepository;
               
           }

        // GET: Author
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Auteur obj)
        {
            AuteurRepository _AuteurRepository = new AuteurRepository();
            _AuteurRepository.Add(obj);
            return RedirectToAction("GetAll");
        }

        public ActionResult GetAll()
        {
            AuteurRepository _AuteurRepository = new AuteurRepository();
            var model = _AuteurRepository.GetAll();
            return PartialView("GetAll", model);
        }

       
    }
}