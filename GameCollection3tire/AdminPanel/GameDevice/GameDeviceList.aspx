<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/content/Admin.master" CodeFile="GameDeviceList.aspx.cs" Inherits="AdminPanel_GameDevice_GameDeviceList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">

    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h1>Game Device List</h1>
                <asp:HyperLink runat="server" ID="hlGameDeviceAdd" Text ="Add Game Device" NavigateUrl="~/AdminPanel/GameDevice/GameDeviceAddEdit.aspx" CssClass="btn btn-primary pull-right" />
            </div>
            <br />
                        <asp:Label runat="server" ID="lblMessage" EnableViewState="false" />

            <br />
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="gvGameDeviceList" runat="server" AutoGenerateColumns="false"  CssClass="table table-bordered table-hover" OnRowCommand="gvGameDevice_RowCommand" >
                    <Columns>
                       <asp:BoundField DataField="GameDeviceID" HeaderText="Game Device ID" />
                    <asp:BoundField DataField="GameDeviceName" HeaderText="Game Device Name" />
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                             <asp:HyperLink runat="server" ID="hlEdit" Text="Edit" CssClass="btn btn-success btn-sm" NavigateUrl='<%# "~/AdminPanel/GameDevice/GameDeviceAddEdit.aspx?GameDeviceID=" + Eval("GameDeviceID").ToString().Trim() %>'></asp:HyperLink>
                                <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-danger btn-sm" Text="Delete" CommandName="DeleteRecord" CommandArgument='<%# Eval("GameDeviceID") %>' />
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
