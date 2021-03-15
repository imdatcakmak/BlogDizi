<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniBlog.aspx.cs" Inherits="BlogDizi.AdminSayfalar.YeniBlog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server" class="form-group">
        
        <asp:TextBox ID="TxtBaslik" runat="server" CssClass="form-control" placeholder="Blog Başlık"></asp:TextBox>
        <br />
         <asp:TextBox ID="TxtTarih" runat="server" CssClass="form-control" placeholder="Blog Tarih"></asp:TextBox>
        <br />
         <asp:TextBox ID="TxtGorsel" runat="server" CssClass="form-control" placeholder="Blog Görsel"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" DataTextField="TURAD" DataValueField="TURID"></asp:DropDownList>
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" DataTextField="KATEGORIAD" DataValueField="KATEGORIID"></asp:DropDownList>
        <br />
        <asp:TextBox ID="TxtIcerik" runat="server" CssClass="form-control" placeholder="Blog İçerik" TextMode="MultiLine" Height="100px"></asp:TextBox>
        <br />
        <asp:Button ID="BtnKaydet" runat="server" Text="Kaydet"  CssClass="btn btn-success" OnClick="BtnKaydet_Click"/>

    </form>

</asp:Content>
