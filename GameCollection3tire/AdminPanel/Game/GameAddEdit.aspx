<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/content/Admin.master" CodeFile="GameAddEdit.aspx.cs" Inherits="AdminPanel_Game_GameAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="container-fluid">

        <div class="row">
            <div class="col-md-12">
                <h1>
                    <asp:Label runat="server" ID="lblPageHeader"></asp:Label>
                </h1>
                <p>
                    <asp:Label ID="lbladd" runat="server" BackColor="#ccffcc" ForeColor="#009900" EnableViewState="False"></asp:Label>
                </p>
            </div>
            <br />
            <asp:Label runat="server" ID="lblMessage" EnableViewState="false" />
        </div>
        <div class="card-body bg-gray " style="background-color: azure; color: black;">
            <div class="form-group row">
                <label for="txtGameName" class="col-md-1 col-form-lable">Game Name</label>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" ID="txtGameName" CssClass="form-control" placeholder="Enter Game Name" />
                    <asp:RequiredFieldValidator runat="server" ID="rfvGameName" ControlToValidate="txtGameName" ErrorMessage="Enter Game Name" ForeColor="Red" SetFocusOnError="True" Display="Dynamic" />
                </div>
            </div>
            <div class="form-group row">
                <label class="col-md-1 col-form-lable">Game Creator</label>
                <div class="col-md-5">
                    <asp:DropDownList ID="ddlGameCreator" runat="server" CssClass="select2me form-control"></asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ID="rfvddlGameCreator" ControlToValidate="ddlGameCreator" InitialValue="-1" ErrorMeassage="Select Game Creator" ForeColor="Red" SetFocusOnError="True" Display="Dynamic" ErrorMessage="Enter Game Creator" />
                </div>
                <label class="col-md-1 col-form-lable">Game Category</label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddlGameCategory" runat="server" CssClass="select2me form-control"></asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ID="rfvddlGameCategory" ControlToValidate="ddlGameCategory" InitialValue="-1" ErrorMeassage="Select Game Category" ForeColor="Red" SetFocusOnError="True" Display="Dynamic" ErrorMessage="Enter Game Category" />
                </div>
            </div>
            <div class="form-group row">
                <label class="col-md-1 col-form-lable">Game Device</label>
                <div class="col-md-5">
                    <asp:DropDownList ID="ddlGameDevice" runat="server" CssClass="select2me form-control"></asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ID="rfvddlGameDevice" ControlToValidate="ddlGameDevice" InitialValue="-1" ErrorMeassage="Select Game Device" ForeColor="Red" SetFocusOnError="True" Display="Dynamic" ErrorMessage="Enter Game Device" />
                </div>
                <label for="txtReleaseDate" class="col-md-1 col-form-lable">Release Date</label>
                <div class="col-md-4">
                    <asp:TextBox runat="server" ID="txtReleaseDate" CssClass="form-control" placeholder="Enter Release Date" TextMode="Date" />
                    <asp:RequiredFieldValidator runat="server" ID="rfvReleaseDate" ControlToValidate="txtReleaseDate" ErrorMessage="Enter Release Date" ForeColor="Red" SetFocusOnError="True" />
                </div>
            </div>
            <div class="form-group row">
                <label for="txtGameVersion" class="col-md-1 col-form-lable">Game Version</label>
                <div class="col-sm-5">
                    <asp:TextBox runat="server" ID="txtGameVersion" CssClass="form-control" placeholder="Enter Game Version" />
                    <asp:RequiredFieldValidator runat="server" ID="rfvGameVersion" ControlToValidate="txtGameVersion" ErrorMessage="Enter Game Version" ForeColor="Red" SetFocusOnError="True" />
                </div>
                <label for="txtGameDescription" class="col-md-1 col-form-lable">Description</label>
                <div class="col-sm-4">
                    <asp:TextBox runat="server" ID="txtGameDescription" CssClass="form-control" placeholder="Enter Description" TextMode="MultiLine" Rows="3" />
                    <asp:RequiredFieldValidator runat="server" ID="rfvGameDescription" ControlToValidate="txtGameDescription" ErrorMessage="Enter Description" ForeColor="Red" SetFocusOnError="True" />
                </div>
            </div>
            <div class="form-group row">
                <label for="fuImage" class="col-md-1 col-form-lable">Image Upload</label>
                <div class="col-md-9">
                    <asp:Image ID="imgGame" CssClass="img-fluid" runat="server" Height="100px" Visible="false" />
                    <asp:FileUpload ID="fuImage" runat="server" />
                    <asp:RequiredFieldValidator runat="server" ID="rfvImage" ControlToValidate="fuImage" Display="Dynamic" ErrorMessage="Choose Image File" CssClass="text-danger" ForeColor="Red" />
                </div>
                <div>
                    <asp:Button runat="server" ID="BtnSave" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click"></asp:Button>
                    <asp:HyperLink runat="server" ID="hlCancel" Text="Cancel" NavigateUrl="~/AdminPanel/Game/GameList.aspx" CssClass="btn btn-danger" />
                </div>
            </div>
        </div>
    </div>


    <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="Server">
</asp:Content>
