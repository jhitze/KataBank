﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KataBankOCR._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>KataBankOCR</h1>
        <p class="lead">A neat place to transcribe your OCR documents.</p>
        <asp:Label runat="server" ID="uploadStatus" class="label label-info"></asp:Label>
        <asp:FileUpload ID="ocrFileUpload" runat="server" />
        <asp:Button class="btn btn-primary" runat="server" id="UploadButton" text="Upload" onclick="UploadButton_Click"/>
    </div>
    <div class="row">
        <p>Here are the account numbers recognized from the file:</p>
        <asp:Label runat="server" ID="AccountNumbers"></asp:Label>
    </div>
</asp:Content>
