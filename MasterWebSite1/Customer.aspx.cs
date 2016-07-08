using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class _Customer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            AddProvince(); // Adding province list to province drop down
        }

    }

    // For adding list of provinces to province drop down
    protected void AddProvince()
    {
        string[] province = { "Ontario", "Manitoba", "Quebec", "Saskatchewan", "BC", "Alberta", "Nova Scotia", "PEI", "New Brunswick", "New Foundland" };

        foreach (var str in province)
            ddlProvince.Items.Add(str);
    }

    // When user select dates using calender control, this is invoked
   

    

    // When user click on the image button, this is invoked
   
    protected void btnClear_Click(object sender, EventArgs e)
    {
        ClearControls();
    }


    protected void ClearControls()
    {
        txtFName.Text = "";
        txtLName.Text = "";
        txtDOB.Text = "";
        txtAddress1.Text = "";
        txtTelephone.Text = "";
        txtEmail.Text = "";
        txtAddress2.Text = "";
        txtCity.Text = "";
        ddlProvince.ClearSelection();


    }
}