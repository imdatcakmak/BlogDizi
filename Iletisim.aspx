<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="BlogDizi.Iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
<div class="contact-content">
	 <div class="container">
		     <div class="contact-info">
			 <h2>İLETİŞİM</h2>
			 <p>Blog sayfamızda bulunan film ve dizilere eklemek istedikleriniz için veya yorumlarda yaşayacağınız herhangi bir problem olursa bu kısımdan bizlere ulaşabilirsiniz.Mesaj gönderme sırasında mail adresinizi mutlaka doğru yazın ki sizlere geri dönüş sağlayabilelim.İlginize teşekkür ederiz.</p>
		     </div>
			 <div class="contact-details">				 
			 <form runat="server">
                 <asp:TextBox ID="TextBox1" runat="server" placeholder="Ad Soyad" required=""></asp:TextBox>
				 <asp:TextBox ID="TextBox2" runat="server" placeholder="Mail" required=""></asp:TextBox>
				 <asp:TextBox ID="TextBox3" runat="server" placeholder="Telefon" required=""></asp:TextBox>
				 <asp:TextBox ID="TextBox4" runat="server" placeholder="Konu" required=""></asp:TextBox>
				 <asp:TextBox ID="TextBox5" runat="server" placeholder="Mesajınız" required="" TextMode="MultiLine"  Height="100"></asp:TextBox>
                 <asp:Button ID="Button1" runat="server" Text="Gönder" OnClick="Button1_Click" />
			 </form>
		  </div>
		  <div class="contact-details">
			  <div class="col-md-6 contact-map">
				 <h4>Biz Buradayız.</h4>
				<div class="mapouter"><div class="gmap_canvas"><iframe width="600" height="500" id="gmap_canvas" src="https://maps.google.com/maps?q=ankara&t=&z=13&ie=UTF8&iwloc=&output=embed" frameborder="0" scrolling="no" marginheight="0" marginwidth="0"></iframe><a href="https://www.online-timer.net"></a><br><style>.mapouter{position:relative;text-align:right;height:500px;width:600px;}</style><style>.gmap_canvas {overflow:hidden;background:none!important;height:500px;width:600px;}</style></div></div>
			  </div>
			  <div class="col-md-6 company_address">		 
					<h4>Tam Adres</h4>
					<p>Elvan Mahallesi</p>
					<p>1959 sokak Etimesgut/ANKARA</p>
					<p>TURKEY</p>
					<p>Phone:(00) 222 666 444</p>
					<p>Fax: (000) 123 456 78 0</p>
					<p>Email: <a href="#">imdatcakmak97@gmail.com</a></p>
					<p>Takip etmek için : <a href="#">Facebook</a>, <a href="#">Twitter</a></p>
			 </div>
			  <div class="clearfix"></div>
	     </div>		 


			 </div>
	 </div>


	

</asp:Content>
