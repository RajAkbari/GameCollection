<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/content/Admin.master" CodeFile="GameCategoryList.aspx.cs" Inherits="AdminPanel_GameCategory_GameCategoryList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">

    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h1>Game Category List</h1>
                <asp:HyperLink ID="hlAddGameCategory" runat="server" Text="Add Game Category" CssClass="btn btn-primary pull-right" NavigateUrl="~/AdminPanel/GameCategory/GameCategoryAddEdit.aspx"></asp:HyperLink>
                <br />
                <asp:Label runat="server" ID="lblMessage" EnableViewState="false" />
                <br />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="gvGameCategoryList" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False" OnRowCommand="gvGameCategory_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="GameCategoryID" HeaderText="Game Category ID" />
                        <asp:BoundField DataField="GameCategoryName" HeaderText="Game Category Name" />
                        <asp:TemplateField HeaderText="Actions">
                            <ItemTemplate>
                                <asp:HyperLink ID="hlEdit" runat="server" Text="Edit" CssClass="btn btn-success btn-sm" NavigateUrl='<%# "~/AdminPanel/GameCategory/GameCategoryAddEdit.aspx?GameCategoryID="+Eval("GameCategoryID").ToString() %>'></asp:HyperLink>
                                <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-danger btn-sm" CommandName="DeleteRecord" CommandArgument='<%# Eval("GameCategoryID")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="Server">
</asp:Content>
