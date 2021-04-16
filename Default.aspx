<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:Calendar ID="Calendar1" runat="server" CellSpacing="50" Width="80%" BackColor="ActiveBorder"
                        DayNameFormat="Full" NextPrevFormat="FullMonth"  BorderWidth="3px"
                        BorderColor="Brown" Height="40%" ondayrender="Calendar1_DayRender">
                        <TitleStyle BackColor="AliceBlue" />
                        <TodayDayStyle BackColor="BurlyWood" />
                        <SelectedDayStyle BackColor="GreenYellow" />
                    </asp:Calendar>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
