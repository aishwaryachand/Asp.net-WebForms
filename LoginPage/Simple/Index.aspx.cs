using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                 txtName.Focus();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "admin" & txtPwd.Text == "admin")
                Response.Write("Valid User");
            else
                Response.Write("Invalid User");
        }

        protected void BbtnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = txtPwd.Text = "";
            txtName.Focus();
        }
    }
}
