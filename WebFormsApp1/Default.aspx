<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsApp1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%-- Ex1 --%>

        <%--<asp:Label runat="server" Text="Hello!"></asp:Label>--%>
        <!--<asp:Label runat="server" Text="Hello!"></asp:Label>-->
        <%--<asp:Label ID="myLabel" runat="server" Text="Hello!"></asp:Label>
        <asp:TextBox ID="myTextBox" runat="server">text</asp:TextBox>
        <asp:Button
            runat="server"
            Text="submit"
            ID="submitButton"
            OnClick="submitButton_Click" />
        <div><%= 2 * 2 %></div>
        <div><%= test %></div>
        <div><%= myFunc() %></div>
        <div>
            <% for (int i = 0; i < 5; i++)
            {
            Response.Write("<br/>" + "Hello " + i);
            }
            %>
        </div>
        <div>
	        <%= output %>
        </div>--%>

        <%-- Ex2: state --%>

        <div>
            <asp:Label ID="myLabel" runat="server"><%= counter %></asp:Label>
        </div>
        <div>
            <asp:Button
            runat="server"
            Text="+1"
            ID="add_1"
            OnClick="add_1_Click" />
        </div>
    </div>
    </form>
</body>
</html>
