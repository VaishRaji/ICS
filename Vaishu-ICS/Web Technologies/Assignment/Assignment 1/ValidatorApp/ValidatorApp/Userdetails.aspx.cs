using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidatorApp
{
    public partial class Userdetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblName.Text = Request.QueryString["Name"];
                lblFamilyName.Text = Request.QueryString["FamilyName"];
                lblAddress.Text = Request.QueryString["Address"];
                lblCity.Text = Request.QueryString["City"];
                lblZipCode.Text = Request.QueryString["ZipCode"];
                lblPhone.Text = Request.QueryString["Phone"];
                lblEmail.Text = Request.QueryString["Email"];


            }
        }
    }

}
    
