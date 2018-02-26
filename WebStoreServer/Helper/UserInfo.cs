using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebStoreServer.Models;

namespace WebStoreServer.Helper
{
    public class UserInfo
    {
        public User User { get; set; }
        public UserDetails Details { get; set; }
    }
}