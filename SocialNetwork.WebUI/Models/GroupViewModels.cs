using SocialNetwork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialNetwork.WebUI.Models
{
    public class GroupViewModel
    {
        public string GroupPostContent { get; set; }
        public string GroupId { get; set; }

    }

    public class NewGroupViewModel
    {
        public List<string> Types { get; set; }
        public GroupTipes GroupType { get; set; }
        public String GroupName { get; set; }
    }

    public class ShowGroupViewModel
    {
        public ShowGroupViewModel(Group group)
        {
            Group = group;
        }
        public Group Group { get; set; }
    }

    public class AllGroupsViewModel
    {
        public List<Group> Groups { get; set; }
    }
}