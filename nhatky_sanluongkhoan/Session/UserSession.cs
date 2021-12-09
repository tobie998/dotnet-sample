using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nhatky_sanluongkhoan.Session
{
    [Serializable]
    public class UserSession
    {
        public long UserID { get; set; }
        public string Username { get; set; }
    }
}