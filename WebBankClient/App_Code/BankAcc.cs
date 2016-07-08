using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
public class BankAcc : IBankAcc
{
    //double bal;
    public static List<Customer> CustList = new List<Customer> {
                                                                    new Customer ( 1, "Anna", 100.00, "650 Young Street") ,  
                                                                    new Customer ( 2, "Ivan", 500.00, "759 Bloor Street West"),
                                                                    new Customer ( 3, "Maria", 300.00, "1560 Young Street" ),
                                                                    new Customer ( 4, "Pete", 800.00, "960 Steeles Avenue West" ),
                                                                    new Customer ( 5, "Max", 650.00, "2555 Bloor Street East")
                                                                    };

    public string GetCustDetails(int act)
    {
        foreach (Customer cust in CustList)
        {
            if (cust.AccountNumber == act)
            {
                return string.Format("Account Number : {0} , Name : {1}, Balance: {2}", cust.AccountNumber, cust.Name, cust.Balance);
            }

        } // end foreach

        return string.Format("{0}", "Customer does not exists!");
    }


    public string WithDrawMoney(int act, double amt)
    {
        ServiceData myServiceData = new ServiceData();
        try
        {


            foreach (Customer cust in CustList)
            {
                if (cust.AccountNumber == act)
                {
                    cust.Balance -= amt;
              
                    return string.Format("Account Number : {0} , Name : {1}, Balance: {2}", cust.AccountNumber, cust.Name, cust.Balance);
                }
            }

            return string.Format("{0}", "Customer does not exists!");
           
        }
        catch (Exception ex)
        {
            myServiceData.Result = false;
            myServiceData.ErrorMessage = "unforeseen error occurred. Please try later.";
            myServiceData.ErrorDetails = ex.ToString();
            throw new FaultException<ServiceData>(myServiceData, ex.ToString());
        }
    }

    public string DepositMoney(int act, double amt )
    {
        foreach (Customer cust in CustList)
        {
            if (cust.AccountNumber == act)
            {
                cust.Balance += amt;
                return string.Format("Account Number : {0} , Name : {1}, Balance: {2}", cust.AccountNumber, cust.Name, cust.Balance);
            }
        }
        return string.Format("{0}", "Customer does not exists!");
    }

    public string GetBalance(int act)
    {
        foreach (Customer cust in CustList)
        {
            if (cust.AccountNumber == act)
            {
                return string.Format("Balance: {0}", cust.Balance);
            }
        }
        return string.Format("{0}", "Customer does not exists!");

    }

} 

