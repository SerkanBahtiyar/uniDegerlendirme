<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="uniler.aspx.cs" Inherits="bitirmePro.sayfalar.uniler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>BAŞLIK</th>
            <th>TARİH</th>
            <th>TÜR</th>
            <th>KATEGORİ</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("uniID") %></td>
                    <td><%# Eval("uniGBASLIK") %></td>
                    <td><%# Eval("uniTARIH") %></td>
                    <td><%# Eval("uniTUR") %></td>
                    <td><%# Eval("uniKATEGORI") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "uniSil.Aspx?uniID=" +Eval("uniID") %>' CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td>
                         <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "uniGuncelle.Aspx?uniID=" +Eval("uniID") %>' CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="YeniBlok.Aspx" class="btn btn-primary">Yeni Blog</a>





</asp:Content>
