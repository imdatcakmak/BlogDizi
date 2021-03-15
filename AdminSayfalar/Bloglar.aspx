<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Bloglar.aspx.cs" Inherits="BlogDizi.AdminSayfalar.Bloglar" %>
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
                    <td><%#Eval("BLOGID") %></td>
                    <td><%#Eval("BLOGBASLIK") %></td>
                    <td><%#Eval("BLOGTARIH") %></td>
                    <td><%#Eval("BLOGTUR") %></td>
                    <td><%#Eval("BLOGKATEGORI") %></td>
                    <td> <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "BlogSil.aspx?BLOGID="+ Eval("BLOGID") %>' runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td> <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "BlogGuncelle.aspx?BLOGID="+ Eval("BLOGID") %>' runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="/AdminSayfalar/YeniBlog.aspx" class="btn btn-primary">Yeni Blog</a>
</asp:Content>
