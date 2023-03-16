<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="otomobilweb.Anasayfa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
   
    <style type="text/css">
        .auto-style1 {
            height: 32px;
        }
        .auto-style2 {
            height: 22px;
        }
        .auto-style3 {
            height: 31px;
        }
        .auto-style4 {
            width: 134px;
        }
        .auto-style5 {
            height: 138px;
        }
        .auto-style6 {
            height: 112px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content3"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid" style="background:url('/Content/Images/back.jpg') no-repeat  center; height:100%">

    <table width="771" align="center" border="0" cellspacing="2" cellpadding="2">
  <tr>
    <th  colspan="4" scope="col" class="auto-style6"><p><img src="Content/yedek.jpg"  width="560" height="238" /></p></th>
  </tr>
  <tr align="center">
    <td colspan="4" class="auto-style1"><p>
        <asp:Label ID="Label1" runat="server" Text="YEDEK PARÇA ANASAYFASINA HOŞGELDİNİZ"></asp:Label>
        </p></td>
  </tr>
  <tr>
    <td colspan="2" align="center" class="auto-style2">
        <asp:Label ID="Label2" runat="server" Text="KATEGORİ SEÇİNİZ:"></asp:Label>
      </td>
    <td colspan="2" align="center" class="auto-style2">
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Menu" DataValueField="Cat_ID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="50%" >
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:YEDEKPARCAConnectionString %>" SelectCommand="SELECT * FROM [KATEGORI]"></asp:SqlDataSource>
      </td>
  </tr>
  <tr>
    <td height="178" colspan="4"><p>
        <asp:GridView ID="GridView1" runat="server" Width="100%" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ButtonType="Button" DeleteText="Sil" HeaderText="SEÇİMİNİZ" SelectText="Seç" ShowHeader="True" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        </p></td>
  </tr>
  <tr>
    <td class="auto-style3" align="center" colspan="4">
        <asp:Label ID="Label3" runat="server" Text="SEPETİNİZ"></asp:Label>
      </td>
  </tr>
  <tr>
    <td class="auto-style5" align="center" colspan="4">
        <asp:ListBox ID="ListBox1" runat="server" Height="99%" Width="100%"></asp:ListBox>
      </td>
  </tr>
  <tr>
    <td width="200">
        <asp:Button ID="Button2" runat="server" Height="28px" Text="SEÇİLENİ SİL" Width="100%" OnClick="Button2_Click" />
      </td>
    <td class="auto-style4">
        
        <asp:Button ID="Button1" runat="server" Text="TÜMÜNÜ TEMİZLE" Width="100%" Height="28px" OnClick="Button1_Click" />
      </td>
    <td width="200">
        <asp:Button ID="Button3" runat="server" Text="STOK GÖSTER" Width="100%" OnClick="Button3_Click" />
      </td>
    <td width="200">
        <asp:Button ID="Button4" runat="server" Text="ALIŞVERİŞİ TAMAMLA" Width="100%" OnClick="Button4_Click" />
      </td>
  </tr>
  <tr>
    <td colspan="2"><p>&nbsp;</p></td>
    <td colspan="2">&nbsp;</td>
  </tr>
</table>
</asp:Content>

