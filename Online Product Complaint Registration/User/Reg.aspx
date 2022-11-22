<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/guestmaster.Master" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="Online_Product_Complaint_Registration.User.Reg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body style="background-color:#fadbf6;">
        <form id="form1" runat="server" align="left">
            <div>
                <br />
                <br />
            <asp:Label ID="Label1" runat="server" Text="Name" ></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="TextBox1" runat="server" Style="margin-left: 92px" Width="184px"></asp:TextBox><br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter your name" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator><br /><br />
             <asp:Label ID="Label4" runat="server" Text="Address" ></asp:Label>

            <asp:TextBox ID="TextBox4" runat="server" Style="margin-left: 92px" Width="184px"></asp:TextBox><br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter your Address" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator><br /><br />
            
           <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
             <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female" />
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="gender" Text="Others" /><br /><br />

            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="TextBox2" runat="server" TextMode="Email" Style="margin-left: 92px" Width="184px"></asp:TextBox><br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter your email" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator><br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid format" ControlToValidate="TextBox2" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator><br />

            <asp:Label ID="Label3" runat="server" Text="Phone"></asp:Label>

            &nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="TextBox3" runat="server" TextMode="Phone"  Style="margin-left: 92px" Width="184px"></asp:TextBox><br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter your Phone number" ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator><br />
            

            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please check your Number" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
            
             

            <br />
        </div>
        <p>
            &nbsp;<asp:Label ID="Label6" runat="server" Text="Username"></asp:Label>
            &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style1" Height="16px" Width="189px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Password"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style2" Width="187px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
                </p>
    </form>
</body>
</asp:Content>
