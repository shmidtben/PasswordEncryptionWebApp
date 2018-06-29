<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstWebPage.aspx.cs" Inherits="PasswordEncryptionWebApp.FirstWebPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-top: 40px">
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            Please type in your password:</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="30px" style="margin-top: 0px" TextMode="Password" Width="269px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Please select the encryption algorithm you would like to use:</p>
        <p>
            <asp:Button ID="buttonSHA1" runat="server" OnClick="buttonSHA1_Click" Text="SHA-1" />
            <asp:Button ID="buttonSHA2" runat="server" OnClick="buttonSHA2_Click" Text="SHA-2" />
            <asp:Button ID="buttonMD5" runat="server" OnClick="buttonMD5_Click" Text="MD-5" style="width: 71px" />
            <asp:Button ID="buttonPBKDF2" runat="server" OnClick="buttonPBKDF2_Click" Text="PBKDF2" />
            <asp:Button ID="buttonBCRYPT" runat="server" OnClick="buttonBCRYPT_Click" Text="BCRYPT" />
            <asp:Button ID="buttonSCRYPT" runat="server" OnClick="buttonSCRYPT_Click" Text="SCRYPT" />
            </p>
    </form>
</body>
</html>
