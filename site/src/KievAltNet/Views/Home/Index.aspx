<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <title>Kiev ALT.NET</title>	
	<meta name="Language" content="Ukrainian">
	<meta name="Author" content="Mike Chaliy" />
	<meta name="Description" content="Cайт Київської ALT.NET. Альтернативна .NET комуніті.">
</asp:Content>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2></h2>
       <p> 
	  Вітаємо вас на сайті київської ALT.NET. Поки що нас майже немає, але ми над
	   цим працюємо. Для того, щоб не пропустити щось важливе, рекомендуємо підписатися 
	   за допомогою <a href="http://feeds.feedburner.com/kievaltnet" rel="alternate" type="application/rss+xml" class="rss" >RSS</a> або 
	   <a href="http://twitter.com/kievaltnet" rel="alternate" class="twitter" >Twitter</a>.
		</p> 
	 <dl>  
	  <dt>Навіщо все це?</dt> 
	  <dd>Взагалі-то для обміну ДОСВІДом. Переважно досвідом в .NET.</dd> 
	 
	  <dt>Які теми?</dt> 
	  <dd>Ми не обтяжуємо себе колом тем, про які ми можемо спілкуватися, а про які &mdash; ні.
	   Ось список того, що одразу спало на думку: архітектурні питання, як 
	   наприклад, DDD, CQRS чи MVC; мови розробки &mdash; C#, F#, IronPhyton; або 
	   фреймворки, наприклад, NHibernate, ASP.NET MVC тощо; юніт-тестування; спеки; білд-скрипти;
	   тулзи для підвищення продуктивності, наприклад, ReSharper &mdash; коротше будь-що, що так чи інакше 
	   стосується .NET та розробки.</dd> 
	 
	  <dt>Мова?</dt> 
	  <dd>Більшість з нас спілкується російською, але всі розуміють українську, англійську
	   та матерну. Жодних обмежень з цього боку.</dd> 
	 
	  <dt>Що таке ALT.NET?</dt> 
	  <dd><q>We are a self-organizing, ad-hoc community of developers bound by a desire to
	   improve ourselves, challenge assumptions, and help each other pursue excellence 
	   in the practice of software development.</q> 
	   <br />* Це я стягнув з <a href="http://altdotnet.org/">http://altdotnet.org/</a>. Наразі в 
	   тенетах можна знайти значно більше інфи.</dd> 
	 
	   <dt>Чому не .NET User Group?</dt> 
	   <dd>Певне тому що ми не юзери, а розробники. Наразі це місце, де ми не хочемо чути 
	   реклами, ані Microsoft, ані будь-кого ще. Ми хочемо спілкування, живого 
	   спілкування, з живими і, що найважливіше, справжніми програмістами ;). </dd> 
	 </dl>
</asp:Content>