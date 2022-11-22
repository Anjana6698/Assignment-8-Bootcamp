<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/guestmaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Online_Product_Complaint_Registration.Guest.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body style="background-color:#ecdfee;">
    <form id="form1" runat="server">
         <div>
            <h2 style="margin-left: 495px;margin-top: 100px" >
               LOGIN</h2>
        
            <asp:Label ID="Label1" runat="server" Text="Username" style="margin-left: 500px"></asp:Label>
            <br />
            
            <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="185px" style="margin-left: 500px"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Password" style="margin-left: 500px"></asp:Label>
            <br />
           
            <asp:TextBox ID="TextBox2" runat="server" Height="29px" TextMode="Password" style="margin-left: 500px" Width="185px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" Height="34px" OnClick="Button1_Click" style="margin-left: 500px" Width="113px" /><br /><br />
             </div>
             </form>
        </body>
</asp:Content>
