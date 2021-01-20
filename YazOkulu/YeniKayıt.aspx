<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="YeniKayıt.aspx.cs" Inherits="YazOkulu.YeniKayıt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <form id="Form1" runat="server">
        <div class="form-group">
            <strong>
            <asp:Label for="txtad" runat="server" Text="Öğrenci Ad:" style="margin-left:15px"></asp:Label>
            </strong>
            <asp:TextBox ID="txtad" runat="server" CssClass="form-control" style="margin-left:15px"></asp:TextBox>
        </div>
        <br />
         <div class="form-group">
             <strong>
            <asp:Label for="txtsoyad" runat="server" Text="Öğrenci Soyad:" style="margin-left:15px"></asp:Label>
             </strong>
            <asp:TextBox ID="txtsoyad" runat="server" CssClass="form-control" style="margin-left:15px"></asp:TextBox>
        </div>
        <br />
         <div class="form-group">
             <strong>
            <asp:Label for="txtnumara" runat="server" Text="Öğrenci Numara:" style="margin-left:15px"></asp:Label>
             </strong>
            <asp:TextBox ID="txtnumara" runat="server" CssClass="form-control" style="margin-left:15px"></asp:TextBox>
        </div>
        <br />
         <div class="form-group">
             <strong>
            <asp:Label for="txtmail" runat="server" Text="Öğrenci Ad:" style="margin-left:15px"></asp:Label>
             </strong>
            <asp:TextBox ID="txtmail" runat="server" CssClass="form-control" style="margin-left:15px"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
            <asp:Label for="txtsifre" runat="server" Text="Öğrenci Şifre:" style="margin-left:15px"></asp:Label>
            </strong>
            <asp:TextBox ID="txtsifre" runat="server" CssClass="form-control" style="margin-left:15px"></asp:TextBox>
        </div>
        <strong>
        <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-success" style="margin-left:15px" OnClick="Button1_Click"/>
        </strong>
    </form>

</asp:Content>
