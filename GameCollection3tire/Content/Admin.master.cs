using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Content_Admin : System.Web.UI.MasterPage
{
    #region Load Event
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["UserID"] == null)
                Response.Redirect("~/Login.aspx");
            if (Session["UserName"] != null)
            {
                lblUserName.Text = "Hi," + Session["UserName"].ToString();
            }
        }
    }
    #endregion Load Event

    #region button:logout
    protected void lbtnlogout_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("~/Default.aspx");
    }
    #endregion button:logout
}

