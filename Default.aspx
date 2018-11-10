<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
    <br />
    <br />
    Adı:&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
    <br />
    Soyadı:<asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Ekle" />
    <br />
    <br />
    <br />
</asp:Content>
