<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/content/Admin.master" CodeFile="GameList.aspx.cs" Inherits="AdminPanel_Game_GameList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">

    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h1>Game List</h1>
                <asp:HyperLink runat="server" ID="hlGameAdd" Text="Add New Game" NavigateUrl="~/AdminPanel/Game/GameAddEdit.aspx" CssClass=" btn btn-primary " />
            </div>
        </div>
        <br />
        <asp:Label runat="server" ID="lblMessage" EnableViewState="False" />
        <br />
        <div class="container ">

            <asp:GridView ID="gvGameList" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-hover" OnRowCommand=" gvGame_RowCommand">

                <Columns>
                    <asp:BoundField DataField="GameID" HeaderText="ID" />
                    <asp:BoundField DataField="GameName" HeaderText="Game Name" />
                    <asp:BoundField DataField="GameCategoryName" HeaderText="CategoryName" />
                    <asp:BoundField DataField="GameCreatorName" HeaderText="Creator Name" />
                    <asp:BoundField DataField="GameDeviceName" HeaderText="Device Name" />
                    <asp:BoundField DataField="GameDescription" HeaderText="Description" />

                    <asp:TemplateField HeaderText="Release Date" ControlStyle-Width="90px">
                        <ItemTemplate>
                            <asp:Label ID="lblReleaseDate" runat="server" Text='<%# Eval("ReleaseDate","{0:dd-MM-yyyy}") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="GameVersion" HeaderText="Version" />

                    <asp:TemplateField HeaderText="game image" ControlStyle-Width="70px">
                        <ItemTemplate>
                            <asp:Image ID="imgGame" CssClass="img-fluid" runat="server" ImageUrl='<%# Eval("imageurl") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Edit">
                        <ItemTemplate>
                            <asp:HyperLink runat="server" ID="hlEdit" Text="Edit" CssClass="btn btn-success btn-sm" NavigateUrl='<%# "~/AdminPanel/Game/GameAddEdit.aspx?GameID=" + Eval("GameID").ToString().Trim()  %>'></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Delete">
                        <ItemTemplate>
                            <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-danger btn-sm" Text="Delete" CommandName="DeleteRecord" CommandArgument='<%# Eval("GameID") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="Server">
</asp:Content>