<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KalenderWebForm.aspx.cs" Inherits="Kalender.KalenderWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Calendar ID="KalVerjaardag" runat="server" OnSelectionChanged="KalVerjaardag_SelectionChanged"></asp:Calendar>
        <br />
        U heeft deze datum geselecteerd:<br />
        <asp:TextBox ID="tbDatum" runat="server" Width="300px"></asp:TextBox>
        <br />
        <br />
        U bent nu:<p>
            <asp:TextBox ID="tbLeeftijd" runat="server" OnTextChanged="TextBox2_TextChanged" Width="300px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
