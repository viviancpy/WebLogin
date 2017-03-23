using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLogin
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            testif.Attributes.Add("src", "About.aspx");
            //testif.Attributes.Add("onload", "function(){top.location.href = this.contentWindow.location.href;return false;}");
        }
    }
}