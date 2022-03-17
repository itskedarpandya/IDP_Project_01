<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminmaster.Master" AutoEventWireup="true" CodeBehind="admin_dashboard.aspx.cs" Inherits="IDP_Project_01.admin.admin_dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <a href="../admin/Admin_profile.aspx">Profile</a> &nbsp
    <a href="../admin/Reset_pass.aspx">Reset Password</a> &nbsp
    <a href="../admin/ManageApplicant.aspx">Manage Applicant</a> &nbsp
    <a href="../admin/ManageCategory.aspx">Manage Category</a> &nbsp
    <a href="../admin/ManageHr.aspx">Manage HR</a> &nbsp
    <a href="../admin/Logout.aspx">Logout</a> &nbsp
    <p>
    </p>
</asp:Content>
