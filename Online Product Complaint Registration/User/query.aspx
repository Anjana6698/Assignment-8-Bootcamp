<%@ Page Title="" Language="C#" MasterPageFile="~/User/usermaster.Master" AutoEventWireup="true" CodeBehind="query.aspx.cs" Inherits="Online_Product_Complaint_Registration.User.query" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <%--<body style="background-color:#edb5e6;">--%>
        <form id="form1" runat="server" align="left">
            <div>
               <h1> <center>
                   <asp:Label ID="Label1" runat="server" Text="Query Registration"></asp:Label>
                     </center></h1>
                <asp:Label ID="Label2" runat="server" Text="Product Name :"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Query  :"></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Height="221px" Width="650px"></asp:TextBox>
                <br />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                </div>
</form>
</asp:Content>
