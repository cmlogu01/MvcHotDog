using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotDogLovers.Models
{
    public class UserViewModel
    {
        public List<String> Dogs { get; set; }
        public User User { get; set; }
    }
}