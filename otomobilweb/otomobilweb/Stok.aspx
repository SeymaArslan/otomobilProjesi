<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Stok.aspx.cs" Inherits="otomobilweb.Stok" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
      <div class="container-fluid" style="background:url('/Content/Images/back.jpg') no-repeat  center; height:100%">
<title>STOK BİLGİ SAYFASI</title>
</head>

<body>
<table width="100%" border="0" cellspacing="2" cellpadding="2">
  <tr>
    <th colspan="6" scope="col" style="height: 22px">
        <asp:Label ID="Label2" runat="server" Font-Underline="True" ForeColor="#3366FF" Text="LÜTFEN STOKTAKİ BİLGİLERE UYGUN SEÇİM YAPIP SEPETİNİZE EKLEYİNİZ!"></asp:Label>
      </th>
  </tr>
  <tr>
    <td height="26" colspan="6"><div align="center">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="STOK BİLGİSİ EKRANI"></asp:Label>
        </div></td>
  </tr>
  <tr>
    <td height="170" colspan="6">
        <asp:GridView ID="GridView1" runat="server" Height="99%" Width="99%">
        </asp:GridView>
      </td>
  </tr>
  <tr>
    <td><div align="center">
        <asp:Button ID="mkyj_stk" runat="server" Text="MAKYAJ STOK" Width="99%" OnClick="mkyj_stk_Click" />
        </div></td>
    <td colspan="2"><div align="center">
        <asp:Button ID="mtr_stk" runat="server" Text="MOTOR STOK" Width="99%" OnClick="mtr_stk_Click" />
        </div></td>
    <td colspan="2"><div align="center">
        <asp:Button ID="kprt_stk" runat="server" Text="KAPORTA STOK" Width="99%" OnClick="kprt_stk_Click" />
        </div></td>
    <td><div align="center">
        <asp:Button ID="Button4" runat="server" Text="ANASAYFAYA DÖN" Width="99%" OnClick="Button4_Click" />
        </div></td>
      <tr>
    <td height="26" colspan="6"><div align="center">
        <asp:Label ID="Label3" runat="server" Text="STOK GRAFİKSEL DAĞILIMI" Font-Bold="True"></asp:Label>
         
        </div></td>
  </tr>
  </tr>
      <tr>
    <td height="170" colspan="2">
        <asp:Chart ID="Chart2" runat="server" DataSourceID="SqlDataSource1">
            <series>
                <asp:Series ChartArea="Makyaj Stok" Name="Series1" XValueMember="Miktar" YValueMembers="Birim_Fiyatı">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="Makyaj Stok">
                </asp:ChartArea>
            </chartareas>
            <Titles>
                <asp:Title Name="Makyaj Stok" Text="Makyaj Stok">
                </asp:Title>
            </Titles>
        </asp:Chart>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:YEDEKPARCAConnectionString %>" SelectCommand="SELECT [Miktar], [Birim_Fiyatı] FROM [STOK_MAKYAJ]"></asp:SqlDataSource>
          </td>
    <td height="170" colspan="2">
        <asp:Chart ID="Chart3" runat="server" DataSourceID="SqlDataSource2">
            <series>
                <asp:Series ChartType="Pie" Name="Series1" XValueMember="Miktar" YValueMembers="Birim_Fiyatı">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
            <Titles>
                <asp:Title Name="Motor Stok" Text="Motor Stok">
                </asp:Title>
            </Titles>
        </asp:Chart>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:YEDEKPARCAConnectionString %>" SelectCommand="SELECT [Miktar], [Birim_Fiyatı] FROM [STOK_MOTOR]"></asp:SqlDataSource>
          </td>
    <td height="170" colspan="2">
        <asp:Chart ID="Chart4" runat="server" DataSourceID="SqlDataSource3">
            <series>
                <asp:Series ChartType="Line" Name="Series1" XValueMember="Miktar" YValueMembers="Birim_Fiyatı">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
            <Titles>
                <asp:Title Name="Kaporta Stok" Text="Kaporta Stok">
                </asp:Title>
            </Titles>
        </asp:Chart>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:YEDEKPARCAConnectionString %>" SelectCommand="SELECT [Miktar], [Birim_Fiyatı] FROM [STOK_KAPORTA]"></asp:SqlDataSource>
          </td>
  </tr>
  </table>
</body>
</asp:Content>
