<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Tp2.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous">
    <title>Form</title>
</head>
<body class="pt-3 color-scheme" style="background-color: #c7c7c7;">
    
    <section style="    text-align: center;
    color: black;
    border: 1px solid black;
    border-radius: 0 0 25px 25px;
    background-color: aliceblue;
    margin: auto;
    border-style: none;" class="container-md align-content-center align-content-md-center">
        <h3>Formulario de Ingreso</h3>
    </section>

    <form id="form1" class="container card" style="box-shadow: 4px 5px 34px 5px #000;
                                            background-color:#c9c9c9c9;
                                            display:flex;
                                            flex-direction:column;
                                            padding:10px;
                                            justify-content:space-between;" runat="server">
            <div runat="server" style="padding:4px;margin: auto 12px;" id="errorAlert" class="alert alert-danger" role="alert">
                <p runat="server" id="messageText"></p>
            </div>
            
        <section style="display:grid;grid-template-columns:3fr 1fr">


            <div style="margin: auto;
    display: grid;
    place-items: center;
    border: solid 1px black;
    border-radius: 2px;
    height: 162px;
    background-color: #8d8d8d;
    width: 80%;
    padding: 12px;
    align-items: baseline;
    justify-content: center;
    align-content: space-between;
    justify-items: end;">
                <div style="">
                    <asp:Label Text="Nombre :" runat="server" />
                    <asp:TextBox ID="txtNombre" runat="server" />
                </div>
                <div>
                    <asp:Label Text="Dni :" runat="server" />
                    <asp:TextBox ID="txtDni" runat="server" />
                </div>
                <div>
                    <asp:Label Text="Email :" runat="server" />
                    <asp:TextBox ID="txtEmail" runat="server" />
                </div>
                <asp:Button Text="send" ID="cmdsendUserToDatabase" runat="server" OnClick="CmdsendUserToDatabase_Click" />

            </div>
            <section style="display:flex; margin:auto;padding:8px;border-radius: 0 50px 50px 50px;">
                <div>
                    <asp:TextBox autocomplete="off" style="border: solid 1px;border-radius: 0 0 0 50px;    text-align: center;border-style: none;box-shadow: -7px 7px 16px 0px #3d3d3d;" Placeholder="Ingresá ID a borrar" ID="txtEraseBox" runat="server" />
                </div>
                <div >
                    <asp:Button style="background-color:red;color:white;border-radius: 0 50px 50px 0;border-style: none;" Text="Delete" ID="cmdEraseButton" runat="server" OnClick="cmdEraseButton_Click" />
                </div>
            </section>
        </section>
    </form>
        <section style="margin:12px;background-color: #979797a1;padding: 20px;">
            <div id="grdDatos" runat="server"></div>
        </section>




</body>
    <script type="text/javascript">
    setTimeout(function() {
        document.getElementById('<%= errorAlert.ClientID %>').style.display = 'none';
    }, 3000);
    </script>

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-HwwvtgBNo3bZJJLYd8oVXjrBZt8cqVSpeBNS5n7C8IVInixGAoxmnlMuBnhbgrkm" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.min.js" integrity="sha384-Rx+T1VzGupg4BHQYs2gCW9It+akI2MM/mndMCy36UVfodzcJcF0GGLxZIzObiEfa" crossorigin="anonymous"></script>
</html>
