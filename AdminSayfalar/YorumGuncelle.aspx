<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YorumGuncelle.aspx.cs" Inherits="BlogDizi.AdminSayfalar.YorumGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <form runat="server" class="form-group">
        
        <asp:TextBox ID="TxtBaslik" runat="server" CssClass="form-control" placeholder="Blog Başlık" Enabled="false"></asp:TextBox>
        <br />
         <asp:TextBox ID="TxtKullanici" runat="server" CssClass="form-control" placeholder="Kullanıcı Adı"></asp:TextBox>
        <br />
        <asp:TextBox ID="TxtIcerik" runat="server" CssClass="form-control" placeholder="Yorum İçerik" TextMode="MultiLine" Height="100px"></asp:TextBox>
        <br />
         <asp:Button ID="BtnGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="BtnGuncelle_Click" />

    </form>

</asp:Content>
