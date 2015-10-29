﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="nakladnayaE.aspx.cs" Inherits="IIS.АСУ_склад.накладнаяE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass %> <%= Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass %> <%= Constants.EditFormHeaderCssClass %>">Накладная</h2>
        <div class="<%= Constants.FormToolbarCssClass %> <%= Constants.EditFormToolbarCssClass %> <%= Constants.StickyCssClass %>">
            <asp:ImageButton ID="SaveBtn" runat="server" SkinID="SaveBtn" OnClick="SaveBtn_Click" AlternateText="<%$ Resources: Resource, Save %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="SaveAndCloseBtn" runat="server" SkinID="SaveAndCloseBtn" OnClick="SaveAndCloseBtn_Click" AlternateText="<%$ Resources: Resource, Save_Close %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="CancelBtn" runat="server" SkinID="CancelBtn" OnClick="CancelBtn_Click" AlternateText="<%$ Resources: Resource, Cancel %>" />
        </div>
        <div class="<%= Constants.FormControlsCssClass %> <%= Constants.EditFormControlsCssClass %>">
            <%-- Autogenerated section start [Controls] --%>
<!-- autogenerated start -->
<div>
	<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlстатусLabel" runat="server" Text="Статус" EnableViewState="False">
</asp:Label>
<asp:DropDownList ID="ctrlстатус" CssClass="descTxt" runat="server">
	<asp:ListItem>новая</asp:ListItem>
<asp:ListItem>выписанная</asp:ListItem>
<asp:ListItem>приостановленная</asp:ListItem>
<asp:ListItem>готовая</asp:ListItem>
<asp:ListItem>отгруженная</asp:ListItem>

</asp:DropDownList>
</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlдатаВремяОтгрузкиLabel" runat="server" Text="Дата время отгрузки" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlдатаВремяОтгрузки" runat="server"/>
</div>
</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlсуммаLabel" runat="server" Text="Сумма" EnableViewState="False">
</asp:Label>
<ac:DecimalTextBox CssClass="descTxt" ID="ctrlсумма" runat="server">
</ac:DecimalTextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlвесLabel" runat="server" Text="Вес" EnableViewState="False">
</asp:Label>
<ac:DecimalTextBox CssClass="descTxt" ID="ctrlвес" runat="server">
</ac:DecimalTextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlпримечаниеLabel" runat="server" Text="Примечание" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlпримечание" runat="server">
</asp:TextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlФИОполучателяLabel" runat="server" Text="Ф и ополучателя" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlФИОполучателя" runat="server">
</asp:TextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlномерLabel" runat="server" Text="Номер" EnableViewState="False">
</asp:Label>
<ac:AlphaNumericTextBox CssClass="descTxt" ID="ctrlномер" Type="Numeric" runat="server">
</ac:AlphaNumericTextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlдатазаполненияLabel" runat="server" Text="Датазаполнения" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlдатазаполнения" runat="server"/>
</div>
</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlматериальноОтветственноеЛицоLabel" runat="server" Text="Материально ответственное лицо" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlматериальноОтветственноеЛицо" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlматериальноОтветственноеЛицоValidator" runat="server" ControlToValidate="ctrlматериальноОтветственноеЛицо"
ErrorMessage="Не указано: материальноОтветственноеЛицо" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlматериальноОтветственноеЛицо_фамилияLabel" runat="server" Text="Фамилия" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlматериальноОтветственноеЛицо_фамилия" runat="server" ReadOnly="true">
</asp:TextBox>

</div>
<asp:ScriptManager ID="ScriptManager1" runat="server" >
</asp:ScriptManager>

<div style="clear: left">
	<ac:AjaxGroupEdit ID="ctrlзаписьвнакладной" runat="server" ReadOnly="false" />
</div>
<br/>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>