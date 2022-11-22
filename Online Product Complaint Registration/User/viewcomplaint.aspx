<%@ Page Title="" Language="C#" MasterPageFile="~/User/usermaster.Master" AutoEventWireup="true" CodeBehind="viewcomplaint.aspx.cs" Inherits="Online_Product_Complaint_Registration.User.viewcomplaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Complaint Status</h1>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="cId"></asp:GridView>
    </form>
</asp:Content>
