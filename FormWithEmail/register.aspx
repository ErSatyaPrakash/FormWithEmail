<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="FormWithEmail.register" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Submit Form</title>
    <style>
        .textbox{
            margin-bottom:10px;
            
        }
        div{
            margin:50px 500px;
        }
        input, textarea{
            height:40px;
            width:300px;
        }
        textarea{
            resize:none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="txtName">Name:</label><br />
            <asp:TextBox ID="txtName" runat="server" CssClass="textbox form-control"></asp:TextBox><br />

            <label for="txtEmail">Email:</label><br />
            <asp:TextBox ID="txtEmail" runat="server" CssClass="textbox form-control"></asp:TextBox><br />

            <label for="txtMessage">Message:</label><br />
            <asp:TextBox ID="txtMessage" runat="server" CssClass="textbox form-control" TextMode="MultiLine"></asp:TextBox><br />

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
