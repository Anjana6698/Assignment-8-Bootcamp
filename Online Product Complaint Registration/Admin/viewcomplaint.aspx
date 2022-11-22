<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Adminmaster.Master" AutoEventWireup="true" CodeBehind="viewcomplaint.aspx.cs" Inherits="Online_Product_Complaint_Registration.Admin.viewcomplaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" style="margin-top:50px">
            
   <asp:GridView ID="GridView1" runat="server" DataKeyNames="cid"  OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                
                <Columns>
                    <asp:CommandField HeaderText="Edit" ShowEditButton="True" EditText="Edit " />
                    
                </Columns>

    </asp:GridView>
        </form>
</asp:Content>
