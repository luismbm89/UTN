<%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="CerrarSesion.aspx.cs" Inherits="UTN.CerrarSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <script type="text/javascript">
    var timeleft = 5;
    var downloadTimer = setInterval(function(){
    timeleft--;
    document.getElementById("countdowntimer").textContent = timeleft;
    if(timeleft <= 0)
        clearInterval(downloadTimer);
    },1000);
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <h3>Sesión finalizada correctamente.</h3><br /> Será redirigido en <span style="font-style:oblique;color:darkgreen" id="countdowntimer">5 </span> segundos
</asp:Content>
