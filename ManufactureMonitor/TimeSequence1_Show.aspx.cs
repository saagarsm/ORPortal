﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManufactureMonitor
{
    public partial class TimeSequence1_Show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BackButton_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/TimeSequence1.aspx");
        }
    }
}