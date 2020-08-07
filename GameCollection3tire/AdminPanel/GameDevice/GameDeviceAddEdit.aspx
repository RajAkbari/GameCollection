<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/content/Admin.master" CodeFile="GameDeviceAddEdit.aspx.cs" Inherits="AdminPanel_GameDevice_GameDeviceAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
 <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h1>
                    <asp:Label ID="lblPageHeader" runat="server"></asp:Label>
                </h1>
                <p>
                    <asp:Label ID="lbladd" runat="server" BackColor="#ccffcc" ForeColor="#009900" EnableViewState="False"></asp:Label>
                </p>
            </div>
        </div>
     <br />
                        <asp:Label runat="server" ID="lblMessage" EnableViewState="false" />

            <br />
        <div class="row">
            <div class="col-md-2">
       <label class="control-label">Game Device Name : </label>

            </div>
            <div class="col-md-6">
                   <asp:TextBox ID="txtGameDeviceName" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvGameDeviceName" runat="server" ControlToValidate="txtGameDeviceName"  ErrorMessage="Enetr the Game Device Name" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>

            </div>
        </div>
     
        <br />
        <br />
        <div class="row">
            <div class="col-md-2"></div>
        <div class="col-md-10">
            <asp:Button ID="btnsave" runat="server" CssClass="btn btn-primary" Text="Save" OnClick="btnSave_Click" />
            <asp:HyperLink ID="btnedit" runat="server" CssClass="btn btn-danger" Text="Cancel" NavigateUrl="~/AdminPanel/GameDevice/GameDeviceList.aspx"></asp:HyperLink>
        </div>
            </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="Server">
</asp:Content>