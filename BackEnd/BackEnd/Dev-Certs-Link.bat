@echo off
dotnet dev-certs https -ep %USERPROFILE%\.aspnet\https\ToDoApp.pfx -p ToDoApp
dotnet dev-certs https --trust
setx WSLENV USERPROFILE/up