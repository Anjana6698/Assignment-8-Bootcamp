<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/guestmaster.Master" AutoEventWireup="true" CodeBehind="product_details.aspx.cs" Inherits="Online_Product_Complaint_Registration.Admin.product_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" style="margin-top:50px">
            
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label1" runat="server" Text="Product Details" style="margin-left: 500px"></asp:Label><br />
        &nbsp;&nbsp;
        &nbsp;&nbsp;
        &nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Product Name" style="margin-left: 500px"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 25px"></asp:TextBox><br /><br />
            <br />
            &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Add" style="margin-left: 572px" Width="116px" OnClick="Button1_Click"/><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView1" runat="server" style="margin-left: 500px" Width="327px" AutoGenerateColumns="False" DataKeyNames="pid" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:BoundField DataField="name" HeaderText="Product Name" />
                    <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                    <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                    
                </Columns>



          

           </asp:GridView>
         </form>
           
</asp:Content>
