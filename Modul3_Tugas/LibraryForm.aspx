<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LibraryForm.aspx.cs" Inherits="Tugas_Modul3.LibraryForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Library Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Library Data Entry</h2>
            <table>
                <tr>
                    <td>NIM:</td>
                    <td><asp:TextBox ID="txtNIM" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Nama Lengkap:</td>
                    <td><asp:TextBox ID="txtNama" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Jurusan:</td>
                    <td><asp:TextBox ID="txtJurusan" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Tanggal Lahir:</td>
                    <td><asp:TextBox ID="txtTanggalLahir" runat="server" TextMode="Date"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Judul Buku:</td>
                    <td><asp:TextBox ID="txtJudul" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Pengarang:</td>
                    <td><asp:TextBox ID="txtPengarang" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Tanggal Pinjam:</td>
                    <td><asp:TextBox ID="txtTanggalPinjam" runat="server" TextMode="Date"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
                    </td>
                </tr>
            </table>
            <asp:GridView ID="gvLibrary" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
    </form>
</body>
</html>