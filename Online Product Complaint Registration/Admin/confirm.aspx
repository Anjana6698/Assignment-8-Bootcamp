<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/guestmaster.Master" AutoEventWireup="true" CodeBehind="confirm.aspx.cs" Inherits="Online_Product_Complaint_Registration.Admin.confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>User Details</h2>          
<form id="form1" runat="server">                     
 <asp:GridView ID="GridView1" runat="server" DataKeyNames="uId1" OnRowDeleting="GridView1_RowDeleting"> 
     <Columns>
     <asp:CommandField HeaderText="Sts" ShowDeleteButton="True" DeleteText="confirm" />    

     </Columns>                        

 </asp:GridView>  

</form>


</asp:Content>
