﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ejemploACORDEON.aspx.vb" Inherits="psi_gui.usuarios"
    MasterPageFile="~/Admin.Master" %>
<!--
<asp:Content runat="server" ContentPlaceHolderID="barraNavegacion">
    <nav class="navbar navbar-inverse navbar-fixed-top">
        <div class="container-fluid">
            <div class="navbar-header">
            <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
            <span class="sr-only">Conmutar la navegación</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="Default.aspx">Proyecto Psi</a>
            </div>
            <div id="navbar" class="navbar-collapse collapse">
            <ul class="nav navbar-nav navbar-right">
            <li><a href="noticias.aspx">Noticias</a></li>
            <li><a href="nosotros.aspx">Nosotros</a></li>
            <li><a href="contactese.aspx">Contáctese</a></li>
            <li class="dropdown">
            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Servicios<span class="caret"></span></a>
            <ul class="dropdown-menu">
            <li><a href="#">Presencia en la Web</a></li>
            <li><a href="tests.aspx">Psicodiagnóstico</a></li>
            <li><a href="#">Asistente virtual</a></li>
            </ul>
            </li>
            <li><a class="btn btn-default btn-sm" href="login.aspx" id="lblPerfil" title="Perfil"></a></li>
            </ul>
            <form class="navbar-form navbar-right">
            <input type="text" class="form-control" placeholder="Buscar..." data-translatable-string="Search..." />
            </form>
            </div>
        </div>
    </nav>
</asp:Content>
-->
<asp:Content runat="server" ContentPlaceHolderID="barraNavegacion">
    <div class="container" id="MenuOpciones">
        <div class="container-fluid">
            <div class="col-sm-3 col-md-3" style="position: fixed; left: 0px; max-width:180px">
                <div id="accordion" class="sidebar-nav">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <a data-toggle="collapse" data-parent="#accordion" href="#collapseOne">
                                    <span class="glyphicon glyphicon-credit-card"></span>
                                    Clientes
                                </a>
                            </h4>
                        </div>
                        <div id="collapseOne" class="panel-collapse collapse in">
                            <div class="panel-body">
                                <ul class="nav nav-sidebar">
                                    <li><a href="#">Suscripciones</a></li>
                                    <li><a href="clientes.aspx">Clientes</a></li>
                                    <li><a href="usuarios.aspx">Usuarios</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <a data-toggle="collapse" data-parent="#accordion" href="#collapseTwo">
                                    <span class="glyphicon glyphicon-user">
                                    </span>
                                    Psicodiagnosis
                                </a>
                            </h4>
                        </div>
                        <div id="collapseTwo" class="panel-collapse collapse">
                            <div class="panel-body">
                                <ul class="nav nav-sidebar">
                                    <li><a href="ABMevaluadores.aspx">Evaluadores</a></li>
                                    <li><a href="coordinadores.aspx">Coordinadores</a></li>
                                    <li><a href="pacientes.aspx">Pacientes</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h4 class="panel-title"><a data-toggle="collapse" data-parent="#accordion" href="#collapseThree"><span class="glyphicon glyphicon-stats"></span>Tests</a> </h4>
                        </div>
                        <div id="collapseThree" class="panel-collapse collapse">
                            <div class="panel-body">
                                <ul class="nav nav-sidebar">
                                    <li><a href="#">Consignas</a></li>
                                    <li><a href="protocoloWisc3.rdlc">Preguntas</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="pagina">
    <div class="container-fluid " style="position:relative; left:170px;">
        <div class="table">
            <form runat="server">
                <div class="table-responsive" runat="server">
                <h1>Lista de usuarios</h1><br />
                <br /><br />
                <br />
                </div>
            </form>
        </div>
    </div>
</asp:Content>
