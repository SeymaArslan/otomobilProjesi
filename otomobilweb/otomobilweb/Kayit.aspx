<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kayit.aspx.cs" Inherits="otomobilweb.Kayit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<style type="text/css">
    .auto-style1 {
        height: 26px;
    }
</style>

<form id="form1" runat="server">
    <head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" /><div class="container-fluid" style="background:url('/Content/Images/back.jpg') no-repeat  center; height:100%">
 <img src="images/Arama_Alt.png"  width="100%" height="10%" />
<title>KAYIT SAYFASI</title>
</head>

<body>
<table width="100%" border="0" cellspacing="2" cellpadding="2">
  <tr>
    <th colspan="2" scope="col"><img src="Content/1316326230455_DrLockMAninvoice-938x704.jpg" width="100" height="100" /></th>
  </tr>
  <tr>
    <td height="26" colspan="2"><div align="center">MÜŞTERİ KAYIT SAYFASI</div></td>
  </tr>
  <tr>
    <td width="24%" class="auto-style1">
        <asp:Label ID="Label1" runat="server" Text="Yeni Kullanici Adı:"></asp:Label>
      </td>
    <td width="51%" class="auto-style1">
        <asp:TextBox ID="TextBox1" runat="server" Width="30%"></asp:TextBox>
      </td>
  </tr>
  <tr>
    <td>
        <asp:Label ID="Label2" runat="server" Text="Şifreniz:"></asp:Label>
      </td>
    <td>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="30%"></asp:TextBox>
      </td>
  </tr>
  <tr>
    <td colspan="2"><div align="left">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="KAYDOL" Width="28%" />
        </div>      <div align="left"></div>      <div align="center">
        <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>      <div align="center"></div></td>
  </tr>
</table>
    </form>
</body>
</html>
