<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RenderTime.ascx.cs" Inherits="WidgetLibrary.Controls.RenderTime" %>

<div>
    <%= Label %>
    <%= DateTimeOffset.Now.ToString(Format) %>
</div>
