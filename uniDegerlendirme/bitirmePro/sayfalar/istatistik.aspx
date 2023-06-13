<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="istatistik.aspx.cs" Inherits="bitirmePro.sayfalar.istatistik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <table class="table table-bordered">
        <tr>
            <td>
                Toplam Üniversite Sayısı:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
            <td>
                Toplam Yorum Sayısı:<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
            <td>
                akdeniz bölgesindeki üniversite sayısı:<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
            <td>
                marmara bölgesindeki üniversite sayısı:<asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></td>
        </tr>
         <tr>
            <td>
                karadeniz bölgesindeki üniversite sayısı:<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
            <td>
                5 yıldızlı üniversite sayısı:<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
            <td>
                En Fazla Yorumlu Üniversite:<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td>
              <td>
                iç anadolu bölgesindeki üniversite sayısı:<asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></td>
    </table>

</asp:Content>
