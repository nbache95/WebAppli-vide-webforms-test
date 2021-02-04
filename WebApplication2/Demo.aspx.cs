using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Write(txtName.Text + "</br>");
            Response.Write(lstlocation.SelectedItem.Text + "</br>");

            lblname.Visible = false;
            txtName.Visible = false;
            lstlocation.Visible = false;
            chkC.Visible = false;
            chkASP.Visible = false;
            idfemme.Visible = false;
            idhomme.Visible = false;
            btnSubmit.Visible = false;
        }
    }
}