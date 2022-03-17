using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace IDP_Project_01.admin
{
    public partial class ManageApplicant : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Cv_DBConnectionString"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["aid"] == null)
                    Response.Redirect("../admin_login.aspx");

                string q = "select * from Applicant";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd = new SqlCommand(q, con);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                cmd.ExecuteNonQuery();
                da.Fill(ds, "Applicant");
                if (ds.Tables["Applicant"].Rows.Count > 0)
                {
                    GridView1.DataSource = ds.Tables["Applicant"];
                    GridView1.DataBind();

                }


            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton img;
            img = (ImageButton)sender;
            string q = "delete from Applicant where appid = '" + img.CommandArgument.ToString() + "'";
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd = new SqlCommand(q, con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Response.Redirect(Request.RawUrl);
        }
    }
}