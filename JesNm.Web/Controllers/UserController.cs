using Abp.Web.Mvc.Authorization;
using JesNm.Authorization;
using JesNm.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JesNm.Web.Controllers
{
    [AbpMvcAuthorize]
    public class UserController : Controller
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {   
            _userAppService = userAppService;
        }

        // GET: User
        [AbpMvcAuthorize(PermissionNames.Administration_UserManagement_CreateUser)]
        public ActionResult Index()
        {
           
            var users = _userAppService.GetAllUser();
            return View(users);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
           
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
