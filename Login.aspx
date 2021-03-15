<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BlogDizi.Login" %>


<!DOCTYPE html>
<html lang="en">
   <head>
      <title>BlogDizi Login </title>
      <!-- Meta tags -->
      <meta name="viewport" content="width=device-width, initial-scale=1" />
      <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
      <meta name="keywords" content="Gaze Sign up & login Form Responsive Widget, Audio and Video players, Login Form Web Template, Flat Pricing Tables, Flat Drop-Downs, Sign-Up Web Templates, Flat Web Templates, Login Sign-up Responsive Web Template, Smartphone Compatible Web Template, Free Web Designs for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design"
         />
      <script>
         addEventListener("load", function () { setTimeout(hideURLbar, 0); }, false); function hideURLbar() { window.scrollTo(0, 1); }
      </script>
      <!-- Meta tags -->
      <!--stylesheets-->
       <link href="web/css/bootstrap.css" rel="stylesheet" />
      <link href="/web2/css/style.css" rel='stylesheet' type='text/css' media="all">
      <!--//style sheet end here-->
      <link href="//fonts.googleapis.com/css?family=Source+Sans+Pro:400,600,700" rel="stylesheet">
   </head>
   <body>
      <div class="mid-class">
         <div class="art-right-w3ls">
            <h2>Film Dizi Admin Login Paneli</h2>
            <form action="#" method="post" runat="server">
               <div class="main">
                  <div class="form-left-to-w3l">
                      <asp:TextBox ID="TextBox1" runat="server"  placeholder="Kullanıcı Adınız"></asp:TextBox>
                  </div>
                  <div class="form-left-to-w3l ">
                      <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" placeholder="Şifre"></asp:TextBox>
                     <div class="clear"></div>
                  </div>
               </div>
               <div class="left-side-forget">
                  <input type="checkbox" class="checked">
                  <span class="remenber-me">Beni Hatırla </span>
               </div>
               <div class="right-side-forget">
                  <a href="#" class="for">Şifremi unuttum...?</a>
               </div>
               <div class="clear"></div>
               <div class="btnn">
                   <br />
                   <asp:Button ID="Button1" runat="server" Text="Giriş Yap" CssClass="btn btn-primary" OnClick="Button1_Click" />
               </div>
            </form>
        
          
         </div>
         <div class="art-left-w3ls">
            <h1 class="header-w3ls">
             Film & Dizi Login Paneli
            </h1>
         </div>
      </div>
      <footer class="bottem-wthree-footer">
        <p><b>Copyrights © 2021  Blog Dizi All rights reserved | Design by İmdat ÇAKMAK</b> </p>
      </footer>
   </body>
</html>