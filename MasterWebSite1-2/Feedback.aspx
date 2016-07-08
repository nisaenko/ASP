<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="Feedback.aspx.cs" Inherits="Feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <%--<asp:Label runat="server" Text="This is Feedback page:"></asp:Label>--%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div>
       <p>
        This is my Feedback Page.
        <%--</p>--%> 
        Comments: <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" 
           Height="73px" Width="223px"></asp:TextBox>
   </div>
</asp:Content>