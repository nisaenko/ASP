<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="Customer.aspx.cs" Inherits="_Customer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
          <div>
 
 
  <%--Name --%>
 <asp:Table ID="tblNam" runat="server" BorderWidth="0" 
            BorderStyle="None">
     <asp:TableRow>
  <asp:TableCell>*First Name:</asp:TableCell>
        <asp:TableCell><asp:TextBox ID="txtFName" runat="server" Width="150px"></asp:TextBox>
          
       </asp:TableCell>
</asp:TableRow>
        <asp:TableRow>
  <asp:TableCell>Last Name:</asp:TableCell>
        <asp:TableCell><asp:TextBox ID="txtLName" runat="server" Width="150px"></asp:TextBox>
       </asp:TableCell>
</asp:TableRow>
         <asp:TableRow>
  <asp:TableCell>*Date of Birth:</asp:TableCell> 
     <asp:TableCell><asp:TextBox ID="txtDOB" runat="server" Width="150px"></asp:TextBox>
        
          
     
         </asp:TableCell>
      </asp:TableRow> 
               <asp:TableRow>
                    <asp:TableCell>*Address Line 1:</asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtAddress1" runat="server" Width="150px"></asp:TextBox>
                        
                    </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                    <asp:TableCell>Address2:</asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtAddress2" runat="server" Width="150px"></asp:TextBox>
                       </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>

                    <asp:TableCell>*City:</asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtCity" runat="server" Width="150px"></asp:TextBox>
                      
                    </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                    <asp:TableCell>*Province:</asp:TableCell>
                    <asp:TableCell> 
                        <asp:DropDownList ID="ddlProvince" runat="server" Width="130px">
                        </asp:DropDownList>
                        
                    </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                    <asp:TableCell>*e-mail:</asp:TableCell>
                    <asp:TableCell> <asp:TextBox ID="txtEmail" runat="server" Width="150px"></asp:TextBox>
                    
                    </asp:TableCell>
                    </asp:TableRow>
                   <asp:TableRow>
                       <asp:TableCell>Telephone</asp:TableCell>
                       <asp:TableCell>
                     <asp:TextBox ID="txtTelephone" runat="server" Width="150px"></asp:TextBox>
                       </asp:TableCell>
                   </asp:TableRow>
            </asp:Table> <br />
      
    
    </div>
    <div>
    <br />
     &nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnClear" runat="server" Text="Clear" BackColor="#0066FF" ForeColor="White" Width="88px" 
            onclick="btnClear_Click" />
&nbsp;&nbsp;
    <asp:Button ID="btnNext" runat="server" Text="Next" Width="73px" BackColor="#0066FF" ForeColor="White" PostBackUrl="~/ProductInfo.aspx" />
    </div>
    </asp:Content>