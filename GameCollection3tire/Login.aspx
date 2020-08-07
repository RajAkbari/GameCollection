<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="<%=ResolveClientUrl("~/Content/css/bootstrap.min.css")%>" rel="stylesheet" type="text/css" />
    <link href="<%=ResolveClientUrl("~/Content/css/bootstrap-theme.min.css")%>" rel="stylesheet" type="text/css" />
    <script src="<%=ResolveClientUrl("~/Content/js/jquery.min.js") %>" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~/Content/js/bootstrap.min.js") %>" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" style="padding-top: 50px;">
            <div class="row">
                <div class="col-md-12">
                    <h1>
                        <asp:Label runat="server" ID="lblPageHeader" Text="Login Address Book" />
                    </h1>
                    <hr />
                    <asp:Label runat="server" ID="lblMessage" EnableViewState="false" />
                </div>
                <br />
            </div>
            <br />
            <div class="form-group row">
                <label for="lblUserName" class="col-md-2 col-form-label">User Name</label>
                <div class="col-md-4">
                    <asp:TextBox runat="server" ID="txtUserName" CssClass="form-control" placeholder="Enter User Name" />
                    <asp:RequiredFieldValidator runat="server" ID="rfvUserName" ControlToValidate="txtUserName" Display="Dynamic" ErrorMessage="Enter User Name" CssClass="text-danger" ValidationGroup="User" />
                </div>
            </div>
            <div class="form-group row">
                <label for="lblPassword" class="col-md-2 col-form-label">Password</label>
                <div class="col-md-4">
                    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control" placeholder="Enter Password" />
                    <asp:RequiredFieldValidator runat="server" ID="rfvPassword" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="Enter Password" CssClass="text-danger" ValidationGroup="User" />
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-4">
                     </div>
                <div class="col-sm-2 pull-right">
                    <asp:Button runat="server" ID="btnLogin" ValidationGroup="User" Text="Login" CssClass="btn btn-primary pull-right" OnClick="btnLogin_Click"></asp:Button>
                    &nbsp;
                <asp:HyperLink runat="server" ID="hlClear" Text="Clear" NavigateUrl="~/Login.aspx" CssClass="btn btn-danger" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
