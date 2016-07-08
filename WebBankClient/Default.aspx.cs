using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

public partial class _Default : System.Web.UI.Page
{
    ServiceReference1.BankAccClient proxy;
  //  ServiceReference1.ServiceData exc;
  
    
    protected void Page_Load(object sender, EventArgs e)
    {
        proxy = new ServiceReference1.BankAccClient();
    //  exc = new ServiceReference1.ServiceData();
        //exc = ServiceReference1.MyExceptionContainer;
    }
  
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        int actNo = Convert.ToInt32(txtActno.Text);
        lblOutput.Text = proxy.GetCustDetails(actNo);
    }
       
    public void btnDeposit_Click(object sender, EventArgs e)
    {
       
            int actNo = Convert.ToInt32(txtActno.Text);
            double amt = Convert.ToInt32(txtAmount.Text);
            lblOutput.Text = proxy.Debit(actNo, amt);
       
    }

    public void btnWithdraw_Click(object sender, EventArgs e)
    {
         
        try
        {
          
                int actNo = Convert.ToInt32(txtActno.Text);
                double amt = Convert.ToInt32(txtAmount.Text);
                lblOutput.Text = proxy.Credit(actNo, amt);
            
       }

        catch (FaultException<ServiceData> Fex)
        {
            lblOutput.Text = "ErrorMessage::" + Fex.Detail.ErrorMessage + Environment.NewLine;
            lblOutput.Text = "ErrorDetails::" + Environment.NewLine + Fex.Detail.ErrorDetails;
        }
    }

    public void btnBalance_Click(object sender, EventArgs e)
    {
        int actNo = Convert.ToInt32(txtActno.Text);
        lblOutput.Text = proxy.CustomerBalance(actNo);
    }
}