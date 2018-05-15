using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsApp1
{
    public class User
    {
        public string mLogin { get; set; }
        public string mEmail { get; set; }
        public User(string _login, string _email)
        {
            mLogin = _login;
            mEmail = _email;
        }
        public string toHtml()
        {
            return string.Format("Login: {0}<br/>Email: {1}", mLogin, mEmail);
        }
    }
}