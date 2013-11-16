using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using SocialNetwork.WebUI.Models;
using SocialNetwork.BussinessLogic;

namespace SocialNetwork.WebUI.Controllers
{
    public class PostController : Controller
    {
        [HttpPost]
        public ActionResult CreateUsersPost(ProfileViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var userId = User.Identity.GetUserId();
                UserPostBL.CreatePost(userId, model.PostContent);
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult CreateGroupPost(GroupViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var userId = User.Identity.GetUserId();
                GroupPostBL.CreatePost(userId, int.Parse(model.GroupId), model.GroupPostContent);
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}