<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="Tp2.update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous">
    <title></title>
</head>
<body style="background-color: #09b7db8f;">
    <form id="form1" runat="server">
        <div class="card customCard">
            <div class="card-body" style="    background-color: aliceblue;margin: auto;
    width: 100%;
    text-align: center;">
                <div class="pt-2"></div>
                <h5 class="card-title">Tp2 Actualizar</h5>
                <h3>Conexión a MYSQL</h3>
                <div class="pt-2"></div>
            </div>
        </div>
        <hr />
        <div class="container-fluid">
            <div id="message" class="alert alert-success" style="display: none;">
                 Usuario modificado Correctamente...
            </div>
            <section style="display:grid;grid-template-columns:3fr">


            <div style="margin: auto;
                        display: grid;
                        place-items: center;
                        border: solid 1px black;
                        place-self: center;
                        width: 39vw;
                        height: 40vh;                   
                        border-radius: 2px;
                        background-color: #e2f1f1;
                        padding: 12px;
                        align-items: center;
                        justify-content: center;
                        align-content: space-between;
                        justify-items: center;">
                    <asp:TextBox ID="txtId" style="display:none" runat="server" />
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
                <asp:Button Text="Actualizar" style="place-self: stretch;background: linear-gradient(0deg, #00ff7b 0%, #23da16 94%);color: white;border-style: none;border-radius: 14px;" ID="cmdupdateUserToDatabase" runat="server" OnClick="CmdupdateUserToDatabase_Click" />

            </div>
            
        </section>
        </div>
    </form>
</body>
    
    <script type="text/javascript">
        document.getElementById('cmdupdateUserToDatabase').addEventListener('click', function(e) {
       // e.preventDefault(); 

        document.getElementById('message').style.display = 'block';

    });
    </script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-HwwvtgBNo3bZJJLYd8oVXjrBZt8cqVSpeBNS5n7C8IVInixGAoxmnlMuBnhbgrkm" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.min.js" integrity="sha384-Rx+T1VzGupg4BHQYs2gCW9It+akI2MM/mndMCy36UVfodzcJcF0GGLxZIzObiEfa" crossorigin="anonymous"></script>

</html>
