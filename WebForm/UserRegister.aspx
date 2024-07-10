<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRegister.aspx.cs" Inherits="WebForm.UserRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
    <form id="registerForm" runat="server">
        <div>
            <asp:Label ID="usernameLabel" Text="Username" runat="server"></asp:Label>
            <asp:TextBox ID="userName" runat="server"></asp:TextBox><br />
        </div>
        <div>
            <asp:Label ID="passwordLabel" Text="Password" runat="server"></asp:Label>
            <asp:TextBox ID="password" TextMode="Password" runat="server"></asp:TextBox><br />
        </div>
        <div>
            <asp:Label ID="confirmPasswordLabel" Text="Confirm Password" runat="server"></asp:Label>
            <asp:TextBox ID="confirmPassword" TextMode="Password" runat="server"></asp:TextBox><br />
        </div>
        <div>
            <asp:Label ID="genderLabel" Text="Gender" runat="server"></asp:Label>        
            <asp:RadioButton ID="genderMale" Text="Male" GroupName="gender" Value="male"  runat="server" />
            <asp:RadioButton ID="genderFemale" Text="Female" GroupName="gender" Value="male"   runat="server" />
            <br />
        </div>
        <div>
            <asp:Label ID="courseLabel" Text="Course" runat="server"></asp:Label>  
            <asp:CheckBox ID="c" Text="C" Value="C" runat="server" />
            <asp:CheckBox ID="cpp" Text="C++" Value="Cpp" runat="server" />
            <asp:CheckBox ID="java" Text="Java" Value="Java" runat="server" />
            <br />
        </div>
        <div>
            <asp:Label ID="countryLabel" Text="Country" runat="server"></asp:Label>
            <asp:DropDownList ID="country" runat="server" >
                <asp:ListItem Value="">Select your country</asp:ListItem>
                <asp:ListItem>Nepal</asp:ListItem>
                <asp:ListItem>India</asp:ListItem>
                <asp:ListItem>USA</asp:ListItem>
                <asp:ListItem>UK</asp:ListItem>
             </asp:DropDownList>
            <br />
        </div>
        <div>
            <asp:Button ID="submit" Text="Submit" OnClick="handleSubmit" runat="server" />
        </div>
        <div>
            <asp:TextBox ID="result" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
