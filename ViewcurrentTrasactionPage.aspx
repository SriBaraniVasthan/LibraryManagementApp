<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewcurrentTrasactionPage.aspx.cs" Inherits="LibraryManagementSystem.ViewcurrentTrasactionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 362px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <table class="auto-style1">
            <tr>
                <td class="auto-style2">USER ID</td>
                <td>
                    <asp:TextBox ID="txt_userid" runat="server" OnTextChanged="txt_userid_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="ENter userID " ControlToValidate="txt_userid"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Text="View Transactions" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
    <div>
        <h2>USER TRANSACTIONS</h2>
    </div>
    <div>
        <asp:GridView ID="gvr_trans" runat="server" AutoGenerateColumns="False"    OnRowDeleting="gvr_trans_RowDeleting" Height="155px" Width="813px" >
         
            <Columns>
                <asp:TemplateField HeaderText="TRANSACTION ID">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("TransactionID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="BOOK ID">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("BookID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TRANSACTION DATE">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("ReturnDate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField HeaderText="DELETE TRANS_ID" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
