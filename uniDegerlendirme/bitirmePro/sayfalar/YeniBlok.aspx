﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="YeniBlok.aspx.cs" Inherits="bitirmePro.sayfalar.YeniBlok" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server" class="form-group">
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="üniversite Başlık"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="üniversite Tarih"></asp:TextBox>
         <br />
        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="üniversite Görsel"></asp:TextBox>
         <br />
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" DataTextField="turAd" DataValueField="turid"></asp:DropDownList>
         <br />
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" DataTextField="kategoriAd" DataValueField="kategoriid"></asp:DropDownList>
        <br />
         <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" placeholder="üniversite İçerik" Height="100px" TextMode="MultiLine"></asp:TextBox>
       <br />
        <asp:Button ID="Button1" runat="server" Text="kaydet" CssClass="btn-success" OnClick="Button1_Click"/>


    </form>







</asp:Content>
