﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="psi_gui.default" MasterPageFile="~/Main.Master" Title="Proyecto Psi" %>
<asp:Content ID="C2" ContentPlaceHolderID="cuerpo" runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <meta name="description" content="Página de Inicio de PSI" />
    <meta name="author" content="" />
    <link rel="icon" href="../../favicon.ico" />
    <link href="css/bootstrap.css" rel="stylesheet" />

    <div id="myCarousel" class="carousel slide" data-ride="carousel" style="position: relative; top: 60px; z-index:10;">
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class=""></li>
            <li data-target="#myCarousel" data-slide-to="1" class=""></li>
            <li data-target="#myCarousel" data-slide-to="2" class="active"></li>
        </ol>
        <div class="carousel-inner" role="listbox">
            <div class="item active">
                <img class="first-slide" src="images/1.jpg" alt="First slide" />
                <div class="container">
                    <div class="carousel-caption">
                        <h1>Historia Clínica en la nube</h1>
                        <p>De forma segura</p>
                        <p><a class="btn btn-lg btn-primary" href="login.aspx" role="button">Regístrese</a></p>
                    </div>
                </div>
            </div>
        <div class="item">
            <img class="second-slide" src="images/2.jpg" alt="Second slide" />
            <div class="container">
                <div class="carousel-caption">
                    <h1>Su sitio web</h1>
                    <p>Acceda ya mismo</p>
                    <p><a class="btn btn-lg btn-primary" href="#" role="button">Solicítelo</a></p>
                </div>
            </div>
        </div>
        <div class="item">
            <img class="third-slide" src="images/3.jpg" alt="Third slide" />
            <div class="container">
                <div class="carousel-caption">
                    <h1>WISC v3 Online</h1>
                    <p>Pruébelo</p>
                    <p><a class="btn btn-lg btn-primary" href="login.aspx" role="button">Aquí</a></p>
                </div>
            </div>
        </div>
        </div>
        <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Anterior</span>
        </a>
        <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Siguiente</span>
        </a>
    </div>
    <div style="position:relative; display:block; top:60px; z-index: 50;">
        <h2>Bienvenida</h2>
    </div>
    </asp:Content>
