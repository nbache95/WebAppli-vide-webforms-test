using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            string connectionString ;
            SqlConnection cnn;

            connectionString = @"Server=CY-RT85O0N2T5PK\MSSQlSERVER01;Trusted_Connection=True;Database=mydbtuto ;User ID=demo_user;Password=Password123";

            cnn = new SqlConnection(connectionString);

            cnn.Open();

            Response.Write("Connection Made");
            cnn.Close();

            //
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = " ";
            sql = "Select nom , prenom from table1";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "</br>";
            }

            Response.Write(Output);
            dataReader.Close();
            command.Dispose();

            cnn.Close();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Session["Name"] = txtName.Text;

            Response.Write(Session["Name"]);
            
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