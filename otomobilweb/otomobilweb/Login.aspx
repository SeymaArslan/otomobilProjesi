<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="otomobilweb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .dxeTextBox_iOS input.dxeEditArea_iOS, .dxeButtonEdit_iOS input.dxeEditArea_iOS{
            font-size:14px !important;
        }
        .dxbButton_iOS{
            color: white;
            background: #203D73;
            font-weight:lighter;
            font-family:Arial;
            font-size:13px;
        }
        .auto-style2 {
            width: 125px;
        }
        .auto-style3 {
            width: 125px;
            height: 38px;
        }
        .auto-style4 {
            height: 38px;
        }
        .auto-style5 {
            width: 125px;
            height: 37px;
        }
        .auto-style6 {
            height: 37px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="container-fluid" style="background:url('/Content/Images/back.jpg') no-repeat  center; height:100%">
        <div class="container">
            <div class="col-md-12 col-sm-12">
               
        &nbsp;<asp:Image ID="Image1" runat="server" Height="98px" style="display:block; margin:0 auto"  ImageAlign="Middle" ImageUrl="~/Content/Images/slider-3.jpg" Width="241px" />
     <asp:Label ID="Label1" runat="server" CssClass="auto-style1" style="display:inline-block; text-align:center" Font-Names="Arial" Font-Size="28px" Text="Kullanıcı Giriş"></asp:Label>
       
<table style="width: 1009px; height: 159px">
     
  <tr>
    <td class="auto-style3">
        <asp:Label ID="Label2" runat="server" Text=" MÜŞTERİ ADI:"></asp:Label>
      </td>
    <td class="auto-style4">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
      </td>
  </tr>
  <tr>
    <td class="auto-style5">

        <asp:Label ID="Label3" runat="server" Text="ŞİFRENİZ:"></asp:Label>

    </td>
    <td class="auto-style6">
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
      </td>
  </tr>
    <tr>
    <th scope="col" class="auto-style2">
        <asp:Button ID="Button1" runat="server" Height="32px" Text="GİRİŞ" Width="167px" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label>
        </th>
    <th scope="col">
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">ÜYE DEĞİLSENİZ LÜTFEN TIKLAYIN&#39;</asp:LinkButton>
        </th>
  </tr>


</table>
       
             
         
              
         
    
  </div>
            </div>
        </div>
    </div>
</form>
</body>
</html>
