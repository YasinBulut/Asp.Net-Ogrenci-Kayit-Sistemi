<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="YazOkulu.OgrenciGuncelle" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <strong>
                <asp:Label for="txtıd" runat="server" Text="Öğrenci Id:" Style="margin-left: 20px; font-size: 16pt;"></asp:Label>
                </strong>
                <asp:TextBox ID="txtıd" runat="server" CssClass="form-control" Style="margin-left: 20px"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="txtad" runat="server" Text="Öğrenci Ad:" Style="margin-left: 20px; font-size: 16pt;"></asp:Label>
                </strong>
                <asp:TextBox ID="txtad" runat="server" CssClass="form-control" Style="margin-left: 20px"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="txtsoyad" runat="server" Text="Öğrenci Soyad:" Style="margin-left: 20px; font-size: 16pt;"></asp:Label>
                </strong>
                <asp:TextBox ID="txtsoyad" runat="server" CssClass="form-control" Style="margin-left: 20px"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="txtnumara" runat="server" Text="Öğrenci Numara:" Style="margin-left: 20px; font-size: 16pt;"></asp:Label>
                </strong>
                <asp:TextBox ID="txtnumara" runat="server" CssClass="form-control" Style="margin-left: 20px"></asp:TextBox>
            </div>
            <br />
             <div>
                <strong>
                <asp:Label for="txtmail" runat="server" Text="Öğrenci Mail:" Style="margin-left: 20px; font-size: 16pt;"></asp:Label>
                </strong>
                <asp:TextBox ID="txtmail" runat="server" CssClass="form-control" Style="margin-left: 20px"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="txtsifre" runat="server" Text="Öğrenci Şifre:" Style="margin-left: 20px; font-size: 16pt;"></asp:Label>
                </strong>
                <asp:TextBox ID="txtsifre" runat="server" CssClass="form-control" Style="margin-left: 20px"></asp:TextBox>
            </div>

        </div>
        <asp:Button ID="Button1" runat="server" Width="200px" Text="Güncelle"  CssClass="btn btn-success" Style="margin-left: 20px; font-size: 16pt;" OnClick="Button1_Click" />
    </form>
</asp:Content>

