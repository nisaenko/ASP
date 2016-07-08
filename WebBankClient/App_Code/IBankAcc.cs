using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


[ServiceContract(SessionMode = SessionMode.Allowed)]
public interface IBankAcc
{
    [OperationContract]
    string GetCustDetails(int act);

    [OperationContract(Name = "Credit")]
    [FaultContract(typeof(ServiceData))]
   // [FaultContract(typeof(CustomException))]
    string WithDrawMoney(int act, double amt);

    [OperationContract(Name = "Debit")]
  
  //  [FaultContract(typeof(CustomException))]
    string DepositMoney( int act, double amt );

    [OperationContract(Name = "CustomerBalance")]
    //[FaultContract(typeof(MyExceptionContainer))]
  //  [FaultContract(typeof(CustomException))]
    string GetBalance(int act);

}

//[DataContract()]
//public class CustomException
//{
//    [DataMember()]
//    public string Title;

//    [DataMember()]
//    public string ExceptionMessage;

//    [DataMember()]
//    public string InnerException;

//    [DataMember()]
//    public string StackTrace;
//}

[DataContract]
public class ServiceData
{
    [DataMember]
    public bool Result { get; set; }
    [DataMember]
    public string ErrorMessage { get; set; }
    [DataMember]
    public string ErrorDetails { get; set; }
}

[DataContract]
public class Customer
{
    private int accountNumber;
    private string name;
    private string address;
    private double balance;
    public Customer(int act, string str_name, double bal, string addr)
    {
        accountNumber = act;
        name = str_name;
        balance = bal;
        address = addr;
    }  

    [DataMember(Name="Account", IsRequired = false, Order = 0)]
    public int AccountNumber
    {
        get { return accountNumber; }

        set { accountNumber = value; }
    }

    [DataMember(Name="FirstName", IsRequired = true, Order = 1)]
    public string Name
    {
        get { return name; }

        set { name = value; }
    }

    [DataMember(Name="Balance", IsRequired = true, Order = 2, EmitDefaultValue = true)]
    public double Balance
    {
        get { return balance; }
            set
            {
                if (value <= 0.0)
                    balance = 0.0;
                else
                    balance = value;
            }
    }

    [DataMember(Name="Address", IsRequired = false, Order = 3)]
    public string Address
    {
        get { return address; }

        set { address = value; }
    }
}

 