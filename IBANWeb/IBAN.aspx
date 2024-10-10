<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IBAN.aspx.cs" Inherits="IBAN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery-1.9.1.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />   

    <style type="text/css">
        .messagealert {
            width: 100%;
            position: fixed;
             top:0px;
            z-index: 100000;
            padding: 0;
            font-size: 15px;
        }
    </style>

       <script type="text/javascript">
        function ShowMessage(message, messagetype) {
            var cssclass;
            switch (messagetype) {
                case 'Success':
                    cssclass = 'alert-success'
                    break;
                case 'Error':
                    cssclass = 'alert-danger'
                    break;
                case 'Warning':
                    cssclass = 'alert-warning'
                    break;
                default:
                    cssclass = 'alert-info'
            }
            $('#<%=btnConvertidor.ClientID %>').append('<div id="alert_div" style="margin: 0 0.5%; -webkit-box-shadow: 3px 4px 6px #999;" class="alert fade in ' + cssclass + '"><a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a><strong>' + messagetype + '!</strong> <span>' + message + '</span></div>');
        }
    </script>
   
</head>
<body>
    <form id="form1" runat="server" style="margin:10px;">
    <div>
        <div>
            <h2>Convertidor Cuenta Cliente a IBAN</h2>
        </div>

    </div>

           <div class="alert alert-primary" style="margin-top:20px; margin-left:5px;" runat="server" id="divMensaje" >  
               <%-- <p class="bg-danger">--%>
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </div>          
        
           <%-- <div class="alert alert-primary" role="alert" runat="server" id="divMensaje2" sty >
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </div>--%>
        
           <div class="row">  
               <div class="col-sm-4 col-md-4 col-lg-4">
                   <div class="input-group">
                       <span class="input-group-addon">Identificacion</span>
                       <asp:TextBox ID="txtIdentificacion" runat="server" class="form-control"></asp:TextBox>
                   </div>
                </div>
           </div>
  
           <div class="row">  
               <div class="col-sm-4 col-md-4 col-lg-4">
                   <div class="input-group">
                       <span class="input-group-addon">CC</span>
                       <asp:TextBox ID="txtCC" runat="server" class="form-control"></asp:TextBox>
               </div>
                    </div>
            </div>
    
            <div class="row" style="margin-top:5px;">  
               <div class="col-sm-4 col-md-4 col-lg-4">
                   <div class="input-group">
                       <span class="input-group-addon">IBAN</span>
                <asp:TextBox ID="txtIBAN" runat="server" class="form-control" ReadOnly="true"></asp:TextBox>
               </div>
                    </div>
            </div>

          

        <div class="row" style="margin-top:5px;">  
               <div class="col-sm-4 col-md-4 col-lg-4">
                   <div class="input-group">
                       <asp:Button ID="btnConvertidor" runat="server" Text="Convertir" OnClick="btnConvertidor_Click"  />
                       <asp:Button ID="btnBorrar" runat="server" Text="Limpiar" OnClientClick="myFunction()" OnClick="btnBorrar_Click" style="margin-left: 10px;"  />
                   </div>
                    </div>
        </div>

       
    </form>
</body>
</html>
