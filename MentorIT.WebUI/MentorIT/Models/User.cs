using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MentorIT.Models
{
    public class User
    {
        public string ConnectionId { get; set; }
        public string Name { get; set; }

    }
}