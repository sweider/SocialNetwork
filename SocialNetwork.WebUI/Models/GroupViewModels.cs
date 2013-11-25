using SocialNetwork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SocialNetwork.BussinessLogic;

namespace SocialNetwork.WebUI.Models
{
    public class GroupViewModel
    {
        public Group Group { get; set; }
        public GroupBL.UpdatesParts UpdateSection { get; set; }
    }



    public class NewGroupViewModel
    {
        public List<string> Types { get; set; }
        public GroupTipes GroupType { get; set; }
        public String GroupName { get; set; }
    }

    public class ShowGroupViewModel
    {
     
        public bool IsOwnGroup { get; set; }
        public bool IsAuthoredByGroup { get; set; }
        public Group Group { get; set; }

        public String GroupPostContent { get; set; }
    }

    public class AllGroupsViewModel
    {
        public List<Group> Groups { get; set; }
    }


}