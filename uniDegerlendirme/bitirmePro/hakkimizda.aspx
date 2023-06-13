<%@ Page Title="" Language="C#" MasterPageFile="~/kullanici.Master" AutoEventWireup="true" CodeBehind="hakkimizda.aspx.cs" Inherits="bitirmePro.hakkimizda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div class="about-section">
            <div class="about-grid">
                <h3>hakkımızda</h3>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <p >


                             <a href="<%# Eval("aciklama") %>">Cv dosyası</a>

                        </p>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
