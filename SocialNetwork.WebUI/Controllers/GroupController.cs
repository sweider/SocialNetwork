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

         [Authorize]
        public ActionResult Show(int id)
        {
            var group = new GroupBL().GetGroupById(id, false);
            return View(new ShowGroupViewModel{   
                                Group = group,
                                IsOwnGroup = group.GroupCreatorId == User.Identity.GetUserId() ? true : false
                             });
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
            var group = gBL.CreateGroup(model.GroupName, User.Identity.GetUserId(), model.GroupType);

            return RedirectToAction("Edit", new {id = group.GroupId });            
        }

        public ActionResult Edit(int id)
        {
            return View(new GroupViewModel { Group = new GroupBL().GetGroupById(id,true)});
        }

        [HttpPost]
        public ActionResult Update(int id, GroupViewModel model)
        {
            new GroupBL().UpdateGroup(id, model.Group,model.UpdateSection);
           
            return RedirectToAction("Show", new { id = id });
        }
    }
}