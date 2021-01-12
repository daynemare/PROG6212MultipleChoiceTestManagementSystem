﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppExtension
{
    public partial class PortalHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];
            if(cookie!= null)
            {
                lblUser.Text = cookie["StudentNumber"];

            }
        }
    }
}