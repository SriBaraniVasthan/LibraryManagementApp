<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LibraryManagementSystem.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="JavaScript1.js"></script>
    <style type="text/css">
        .auto-style1 {
            height: 159px;
            width: 388px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
      <h1> Library Management System</h1>      
    <div>
   
        <div>
            <h3>Login here!</h3>
        </div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Library Admin:</td>
            <td>
                <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Password:</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LOGIN" OnClientClick="return chklogin()" BackColor="Yellow" BorderColor="Blue"/>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
        
    </div>
    </div>
    </form>
</body>
</html>
