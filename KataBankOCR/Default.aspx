<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KataBankOCR._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>KataBankOCR</h1>
        <p class="lead">A neat place to transcribe your OCR documents.</p>
        <asp:FileUpload ID="ocrFileUpload" runat="server" />
    </div>
    
</asp:Content>
