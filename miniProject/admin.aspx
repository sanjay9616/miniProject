<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="miniProject.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td>Name</td>
                    <td><asp:TextBox ID="name" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>DOB</td>
                    <td><asp:TextBox ID="dob" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Username</td>
                    <td><asp:TextBox ID="txtUser" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Select User Type</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>admin</asp:ListItem>
                            <asp:ListItem>user</asp:ListItem>
                        </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>

                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Sign Up" />

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
