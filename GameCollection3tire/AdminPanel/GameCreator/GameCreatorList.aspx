<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/content/Admin.master" CodeFile="GameCreatorList.aspx.cs" Inherits="AdminPanel_GameCreator_GameCreatorList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">

    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h1>Game Creator List</h1>
                <asp:HyperLink runat="server" ID="hlGameCreatorAdd" Text="Add Game Creator" NavigateUrl="~/AdminPanel/GameCreator/GameCreatorAddEdit.aspx" CssClass="btn btn-primary pull-right" />
            </div>
            <br />
            <asp:Label runat="server" ID="lblMessage" EnableViewState="false" />
            <br />
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="gvGameCreatorList" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-hover" OnRowCommand="gvGameCreator_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="GameCreatorID" HeaderText="Game Creator ID" />
                        <asp:BoundField DataField="GameCreatorName" HeaderText="Game Creator Name" />
                        <asp:TemplateField HeaderText="Actions">
                            <ItemTemplate>
                                <asp:HyperLink runat="server" ID="hlEdit" Text="Edit" CssClass="btn btn-success btn-sm" NavigateUrl='<%# "~/AdminPanel/GameCreator/GameCreatorAddEdit.aspx?GameCreatorID=" + Eval("GameCreatorID").ToString().Trim() %>'></asp:HyperLink>
                                <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-danger btn-sm" Text="Delete" CommandName="DeleteRecord" CommandArgument='<%# Eval("GameCreatorID") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
            </div>
        </div>
    </div>
    <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="Server">
</asp:Content>
