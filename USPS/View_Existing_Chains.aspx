﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Existing_Chains.aspx.cs" Inherits="USPS.View_Existing_Chains" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Repeater ID="rpt1" Runat="server">
 <HeaderTemplate>
  <ul>
 </HeaderTemplate>

  <ItemTemplate>
    <li>
      <%# DataBinder.Eval(Container.DataItem, "Value.ToString()")%>
   </li>
  </ItemTemplate>

  <FooterTemplate>
    </ul>
  </FooterTemplate>
 </asp:Repeater>
    </div>
    </form>
</body>
</html>
