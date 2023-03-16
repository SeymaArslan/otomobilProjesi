<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Fatura.aspx.cs" Inherits="otomobilweb.Fatura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
     
    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }
        .auto-style2 {
            height: 25px;
            width: 50%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="background:url('/Content/Images/back.jpg') no-repeat  center; height:100%">
    <table width="100%"  border="0"  cellspacing="2" cellpadding="2">
  <tr>
    <th colspan="2" scope="col">&nbsp;</th>
  </tr>
  <tr>
    <th colspan="2" scope="col"></th>
  </tr>
  <tr>
    <th colspan="2"  scope="col">
        <asp:Label ID="Label1"  runat="server"  Text="FATURA BİLGİ" align="center"  Font-Bold="True"></asp:Label>
        
      </th>
  </tr>
  <tr>
    <td height="150" colspan="2">
        <asp:ListBox ID="ListBox1" runat="server" Height="99%" Width="75%" AutoPostBack="True">
            <asp:ListItem>TUTAR</asp:ListItem>
            <asp:ListItem Selected="True">SEÇTİKLERİNİZ</asp:ListItem>
        </asp:ListBox>
      </td>
  </tr>
  <tr>
    <td width="50%" class="auto-style1">
        <asp:Button ID="Button1" runat="server" BorderStyle="Ridge" ForeColor="#0033CC" Text="KONUM BİLGİNİZİ GİRİNİZ" Width="50%" OnClick="Button1_Click" />
      </td>
    <td class="auto-style2">
        <asp:Button ID="Button2" runat="server" BorderStyle="Ridge" ForeColor="Blue" Text="MAKBUZ\FİŞ" Width="50%" />
      </td>
  </tr>
</table>
</asp:Content>
