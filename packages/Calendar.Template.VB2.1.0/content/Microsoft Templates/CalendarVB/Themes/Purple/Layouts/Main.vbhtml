﻿<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title>Calendar</title>
        <link href="@Href("~/favicon.ico")" rel="shortcut icon" type="image/x-icon" />
        @RenderPage(Themes.GetResourcePath("Sections", "StylesScripts.vbhtml"))
    </head>
    <body>
        <div id="header" class="border-bottom">
            <p id="siteTitle">
                <a href="@Href("~/")" title="Home">
                    Calendar
                </a>
            </p>
            @Code
                If UserHelper.CurrentUser IsNot Nothing Then
                    @RenderPage(Themes.GetResourcePath("Sections", "UserInfo.vbhtml"))
                End If
            End Code
        </div>
        @RenderBody()
    </body>
</html>