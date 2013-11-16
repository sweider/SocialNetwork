using SocialNetwork.BussinessLogic;
using SocialNetwork.Entities;
using SocialNetwork.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;

namespace SocialNetwork.WebUI.Controllers
{
    public class GroupController : Controller
    {
        public ActionResult New()
        {
            return View(new NewGroupViewModel { Types = Enum.GetNames(typeof(GroupTipes)).ToList() });
        }

        public ActionResult Show()
        {
            return View();   
        }

        public ActionResult Index()
        {
            return View(new AllGroupsViewModel { Groups = new GroupBL().AllGroups() });
        }

        [HttpPost]
        public ActionResult Create(NewGroupViewModel model)
        {
            //TODO Croup creation + redirect to group edit
            var gBL = new GroupBL();
            gBL.CreateGroup(model.GroupName, User.Identity.GetUserId(), model.GroupType);

            return RedirectToAction("Index");            
        }

    }
}