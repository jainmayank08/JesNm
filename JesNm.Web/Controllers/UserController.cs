using Abp.Authorization.Users;
using Abp.Domain.Uow;
using Abp.UI;
using Abp.Web.Mvc.Authorization;
using JesNm.Authorization;
using JesNm.Users;
using JesNm.Web.Models.User;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Abp.AutoMapper;
using AutoMapper;
using JesNm.Users.Dto;
using JesNm.Authorization.Roles;
using JesNm.Roles;

namespace JesNm.Web.Controllers
{
    //[AbpMvcAuthorize]
    public class UserController : JesNmControllerBase
    {
        private readonly IUserAppService _userAppService;
        private readonly IRoleAppService _roleAppService;

        public UserController(IUserAppService userAppService, IRoleAppService roleAppService)
        {   
            _userAppService = userAppService;
            _roleAppService = roleAppService;
        }

        // GET: User
       // [AbpMvcAuthorize(PermissionNames.Administration_UserManagement_CreateUser)]
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
            var model = new JesNm.Web.Models.User.CreateUserViewModel();
            return View("CreateUser", model);
        }

        [HttpPost]
        [UnitOfWork]
       // [AbpMvcAuthorize("Administration.UserManagement.CreateUser")]
        public virtual async Task<ActionResult> Create(CreateUserViewModel model)
        {
            try
            {
                CheckModelState();   
               
                //Create user
                var user = new User
                {                   
                    UserName = model.UserName,
                    Name = model.Name,
                    Surname = model.Surname,
                    EmailAddress = model.EmailAddress,
                    IsActive = true,
                    Password = model.Password
                };

                AutoMapper.Mapper.CreateMap<User, JesNm.Users.Dto.CreateUserInput>();
                
               var u = user.MapTo<JesNm.Users.Dto.CreateUserInput>();

              await _userAppService.CreateUser(u);


              return RedirectToAction("Index");
              
            }
            catch (UserFriendlyException ex)
            {  
                ViewBag.ErrorMessage = ex.Message;

                return View("Register", model);
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

        #region Role
        public ActionResult CreateRole()
        {
            var model = new JesNm.Web.Models.User.CreateRoleViewModel();
            return View("CreateRole", model);
        }

        [HttpPost]
        [UnitOfWork]
        // [AbpMvcAuthorize("Administration.UserManagement.CreateUser")]
        public virtual async Task<ActionResult> CreateRole(CreateRoleViewModel model)
        {
            try
            {
                CheckModelState();

                //Create role
                var role = new Role
                {
                    DisplayName = model.DisplayName,
                    Name = model.Name,
                    IsStatic = true,
                    IsDefault = false

                };

                AutoMapper.Mapper.CreateMap<Role, JesNm.Roles.Dto.CreateRolesInput>();

                var u = role.MapTo<JesNm.Roles.Dto.CreateRolesInput>();

                await _roleAppService.CreateRole(u);

                return RedirectToAction("Index");

            }
            catch (UserFriendlyException ex)
            {
                ViewBag.ErrorMessage = ex.Message;

                return View("Register", model);
            }
        }

        #endregion
    }
}
