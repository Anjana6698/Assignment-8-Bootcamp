<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Adminmaster.Master" AutoEventWireup="true" CodeBehind="viewquery.aspx.cs" Inherits="Online_Product_Complaint_Registration.Admin.viewquery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Raise A Query</h1>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="qId" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
            </Columns>
        </asp:GridView>
    </form>
</asp:Content>
