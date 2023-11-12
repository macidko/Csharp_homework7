//VIDEO1

KATMANLAR
	1.Katman
		1.1.Database

	2.Katman
		2.1DataAccess(Db Verilerine Eriþim)
			2.1.1.Veriye eriþim kodlarý yazýlýr.

	3.Katman
		3.1.Business(Ýþ ve Ýþ Kurallarý)
			3.1.1. Ýþ kodlarý bu katmana yazýlýr. Kurallar bu bölüme yazýlýr. *Örn: Bölgenize yemek teslimatý olup olmadýðýnýn kontrolü.

	4.Katman
		4.1.API(Application Programming *Interface*, Restful(json))
			4.1.1.UI ve Business katmanýnýn iletiþimini saðlayan ara katman

	5.Katman5
		5.1.UI(Android, IOS, Desktop vb.)
			5.1.1.Ýçeriðin gösterildiði sýnýf

-Veriye eriþim için farklý teknikler vardýr.
-Herhangi bir katmanda yapýlan deðiþiklik diðer katmanlarý etkilemez.
-SOLID
-PnP : Plug n Play
--Interface methodlarý default publictir. Fakat Interface'in kendisi default public DEÐÝLDÝR.
-naming convention
-LINQ(Language Integrated Query) Dil içerisindeki liste bazlý yapýlarý SQL gibi filtrelemeni saðlar.

Abstract Klasörü(Soyut)
	Referans tutucular bulunur.
	Soyut nesneler, interface, abstract class, base class.

Concrete Klasörü(Somut)
	Gerçek iþi yapan classlar bukunur.
	Concrete klasöründeki class'lar, veri tabanýndaki bir tabloya karþýlýk gelir.

Internal Class; 
	Yalnýzca bulunduðu proje(katman) içerisinde ulaþýlabilir. Class'ýn default halidir.
Public Class;
	Yalnýzca bulunduðu proje(katman) içerisinde deðil(internal), diðer projelerin(katmanlarýn) de ulaþabilmesi için kullanýlýr.


//VIDEO2

-Generic Repository Design Pattern;
	Generic Repository Design Pattern, yazýlým geliþtirme süreçlerinde kullanýlan bir tasarým desenidir. Bu desen, veritabaný iþlemlerini genel, 
	yeniden kullanýlabilir ve tip baðýmsýz bir þekilde ele almayý amaçlar. Genel olarak, bir Generic Repository (Jenerik Depo), bir veritabaný 
	tablosu veya nesne türü için temel CRUD (Create, Read, Update, Delete) iþlemlerini içeren genel operasyonlarý saðlar.

	Bu desenin ana avantajlarýndan biri, veritabaný iþlemleri için kullanýlan temel kodun tekrarýný önlemek ve sýk kullanýlan iþlevleri genelleþtirmektir. 
	Bu sayede, benzer iþlemleri gerçekleþtiren farklý varlýk türleri için ayný kodu kullanabilirsiniz.

	Generic Repository Design Pattern'ýn temel özellikleri þunlar olabilir:

		Genel ve Tip Baðýmsýz Operasyonlar: Bir Generic Repository, farklý türde nesneler için genel CRUD iþlemlerini destekler. 
		Bu, herhangi bir varlýk türü için ayný temel operasyonlarý kullanmanýza olanak tanýr.

		Yeniden Kullanýlabilirlik: Generic Repository, çeþitli varlýk türleri arasýnda kodun yeniden kullanýlabilirliðini artýrýr.
		CRUD operasyonlarýný her seferinde tekrar yazmak yerine, bu operasyonlarý genel bir þekilde kullanabilirsiniz.

		Test Edilebilirlik: Generic Repository'nin saðladýðý soyutlama, veritabaný iþlemlerini daha kolay bir þekilde test etmenizi saðlar. 
		Birim testleri, bu operasyonlarý varlýk türünden baðýmsýz olarak yürütebilir.

		Baðýmlýlýklarý Azaltma: Generic Repository, veritabaný iþlemleri için kullanýlan kodu bir araya getirir, bu da baðýmlýlýklarý 
		azaltýr ve sistemdeki deðiþikliklere daha iyi uyum saðlar.

		Esneklik: Generic Repository, yeni varlýk türleri eklediðinizde veya mevcut varlýk türlerini deðiþtirdiðinizde daha az deðiþiklik yapmanýza olanak tanýr.

	Örnek olarak, bir .NET uygulamasýnda Generic Repository Design Pattern kullanýmý þu þekilde gösterilebilir:

		public interface IRepository<T>
		{
			T GetById(int id);
			IEnumerable<T> GetAll();
			void Insert(T entity);
			void Update(T entity);
			void Delete(int id);
		}

		public class GenericRepository<T> : IRepository<T>
		{
			// CRUD operasyonlarýný implemente et
			// ...
		}

		// Kullaným örneði:
		IRepository<Customer> customerRepository = new GenericRepository<Customer>();
		var customer = customerRepository.GetById(1);

	Bu örnekte, IRepository arayüzü, temel CRUD operasyonlarýný içerir ve GenericRepository sýnýfý bu arayüzü uygular. 
	Customer gibi herhangi bir varlýk türü için bu generic repository kullanýlabilir.

-Refactoring?
	Refactoring, bir yazýlýmýn iç yapýsýný iyileþtirmek, kodu daha anlaþýlýr, sürdürülebilir ve genellikle daha etkili hale getirmek amacýyla 
	yapýlan düzenlemelerin bütünüdür. Refactoring iþlemi, genellikle mevcut kodun çalýþma davranýþýný deðiþtirmeden gerçekleþtirilir. 
	Bu, yazýlýmýn kalitesini artýrmak, hata oranýný düþürmek ve gelecekteki geliþtirmeleri kolaylaþtýrmak için kullanýlýr.

	Refactoring'in temel prensipleri arasýnda þunlar bulunur:
		Fonksiyonel Deðiþiklik Yok: Refactoring iþlemleri, mevcut kodun davranýþýný deðiþtirmeden gerçekleþtirilmelidir. 
		Yani, kullanýcýlara ayný sonuçlarý vermeye devam etmelidir.

		Sürekli Ýyileþtirme: Refactoring, genellikle küçük adýmlar halinde sürekli olarak uygulanmalýdýr.
		Büyük, karmaþýk deðiþiklikler yerine küçük, anlamlý adýmlarýn tercih edilmesi, hata ayýklama sürecini ve olasý sorunlarý minimize etmeye yardýmcý olabilir.

		Testlerle Güvence Altýna Alma: Refactoring iþlemleri sýrasýnda, kodun iþlevselliðini koruduðunu doðrulamak için varolan testlerin 
		çalýþmaya devam etmesi veya yeni testler eklenmesi önemlidir.

		Kod Kalitesi ve Okunabilirlik: Refactoring, genellikle kodun okunabilirliðini artýrmayý, tekrarlanan kodu azaltmayý ve genel kod kalitesini yükseltmeyi hedefler.

		Performans Ýyileþtirmesi: Refactoring, kodun performansýný artýrmak için de kullanýlabilir. Ancak bu durumda bile, iþlevselliði deðiþtirmemeye özen gösterilmelidir.

	Refactoring örnekleri þunlarý içerebilir:
		Kodu Parçalara Ayýrma (Extract Method): Uzun bir fonksiyonu daha küçük, anlamlý parçalara bölmek.

		Deðiþken Ýsimlendirme ve Yapýlandýrma (Rename and Reorganize): Deðiþken adlarýný ve yapýsýný daha açýklayýcý hale getirmek.

		Kodun Tekrar Kullanýlabilir Hale Getirilmesi (Extract Class, Extract Interface): Belirli bir sýnýftan veya arabirimden kodu ayýrarak daha genel ve yeniden kullanýlabilir hale getirmek.

		Kodu Birleþtirme (Consolidate Code): Benzer iþlevlere sahip kod parçalarýný birleþtirme.

		Kodun Taþýnmasý (Move Code): Belirli bir fonksiyonu veya sýnýfý baþka bir konuma taþýma.

	Refactoring, yazýlým geliþtirme sürecinin doðal bir parçasýdýr ve kodun bakýmýný kolaylaþtýrýr, hatalarý azaltýr ve gelecekteki geliþtirmeleri destekler.
-LINQ expression-predicate?
		C# LINQ (Language Integrated Query) içinde Expression ve Predicate terimleri, sorgu ifadeleri oluþturmak ve filtreleme iþlemleri 
		gerçekleþtirmek için kullanýlýr. Ýki terim de özellikle LINQ sorgularýnda veya LINQ to Entities gibi ORM (Object-Relational Mapping) kullanýldýðýnda karþýmýza çýkar.

		Expression:
			Expression sýnýfý, bir ifadeyi temsil eden bir aðaç yapýsý oluþturur. LINQ sorgularýnda kullanýlan lambda ifadelerini veya diðer 
			ifadeleri temsil etmek için kullanýlýr.
			Bu, sorgularý sadece derleme zamanýnda deðil, çalýþma zamanýnda da anlayabilme yeteneði saðlar. Bu, özellikle dinamik sorgu 
			oluþturmak veya sorgu ifadesini baþka bir yerde deðerlendirmek için kullanýþlýdýr.

		Örnek bir Expression kullanýmý:
			Expression<Func<int, bool>> isEvenExpression = x => x % 2 == 0;

	Predicate:
		Predicate terimi, genellikle bir þartý ifade etmek için kullanýlýr. LINQ sorgularýnda, Predicate terimi sýkça 
		Func<T, bool> türünde ifadeleri ifade eder. Bu ifadeler, genellikle bir koleksiyonu filtrelemek için kullanýlýr.

	Örnek bir Predicate kullanýmý:
		Predicate<int> isEvenPredicate = x => x % 2 == 0;

	LINQ sorgularýnda bu terimleri kullanmak, sorgularý daha dinamik hale getirmek ve koþullarýnýzý ifade etmek için güçlü bir araç saðlar. 
	Özellikle LINQ to Entities kullanýyorsanýz, Expression kullanmak, sorgularýn veritabanýnda yürütülmesi sýrasýnda sorgu ifadesinin optimize edilebilmesine olanak tanýr.

-delege?
	C# dilinde delege (delegate), bir türdür ve genellikle metodlarý temsil etmek ve bir metodun baþka bir metod tarafýndan 
	çaðrýlabilmesini saðlamak için kullanýlýr. Delegeler, olay tabanlý programlamada, LINQ sorgularýnda ve genel olarak metotlarý referans tipi olarak taþýmak ve iþlemek amacýyla kullanýlýr.

	Ýþte delege ile ilgili bazý temel kavramlar:
		Metot Temsilcisi:
			Delegeler, baþka bir metodu temsil etmek üzere kullanýlýr. Bir delege, imzasý (parametre listesi ve dönüþ türü) belirli bir metodun referansýný taþýr.
			Bir delege, bir metodun imzasýný ve dönüþ türünü belirler. Bu delege tipi, yalnýzca ayný imza ve dönüþ türüne sahip metodlarýn referansýný tutabilir.

		Olaylar ve Geri Çaðrýlar:
			Delegeler, özellikle olay tabanlý programlamada (event-driven programming) kullanýlýr. Bir nesnenin belirli bir durumu 
			deðiþtiðinde veya bir eylem gerçekleþtiðinde baþka bir kodu çaðýrmak için de kullanýlýr.

		LINQ (Language Integrated Query):
			LINQ sorgularý, koleksiyonlarda filtreleme, sýralama ve gruplama gibi iþlemleri gerçekleþtirmek için genellikle delege kullanýr. 
			Örneðin, Func<T, bool> türündeki bir delege, bir koleksiyonu filtrelemek için LINQ sorgularýnda kullanýlabilir.

		Geniþletilebilirlik ve Esneklik:
			Delegeler, kodun geniþletilebilir ve esnek olmasýna yardýmcý olur. Özellikle bir metodu baþka bir metoda geçmek, geri çaðýrmak 
			veya bir metodu dinamik olarak belirlemek istediðinizde kullanýþlýdýr.

	Ýþte basit bir C# delege örneði:
	// Bir delege tanýmla
	delegate int MatematikselIslem(int x, int y);

	// Bir metot tanýmla
	static int Topla(int x, int y)
	{
		return x + y;
	}

	// Delegeyi bir metoda baðla
	MatematikselIslem toplamaDelegesi = Topla;

	// Delegeyi kullanarak metodu çaðýr
	int sonuc = toplamaDelegesi(3, 5);
	Console.WriteLine("Toplam: " + sonuc);

	Bu örnekte, MatematikselIslem adýnda bir delege tanýmlanmýþ ve bu delege, Topla adýndaki bir metodu temsil eder. 
	Delege, metot referansýný taþýr ve çaðrýldýðýnda Topla metodu çalýþtýrýlýr.

-ORM: veritabaný nesneleriyle kodlar arasýnda bir bað kurup, veritabaný iþlerini yapma sürecidir.
	ORM, "Object-Relational Mapping" (Nesne Ýliþkisel Eþleme) kýsaltmasýdýr. ORM, bir programlama tekniðidir ve 
	nesne odaklý programlamayý (OOP) iliþkisel veritabaný sistemleriyle entegre etmeyi amaçlar. Bu sayede, 
	programcýlar nesne tabanlý bir dilde (genellikle bir programlama dilinde) veritabaný iþlemlerini gerçekleþtirebilirler, 
	bunun sonucunda ise veritabanýndaki tablolar ve nesne modelleri arasýndaki dönüþüm ve etkileþim otomatik olarak yönetilir.

	Bir ORM sistemi, nesne modellerini veritabaný tablolarýna eþleyen ve bu nesneler arasýnda iliþkileri yöneten bir ara katman saðlar. 
	Bu sayede, programcýlar veritabanýyla ilgili iþlemleri gerçekleþtirirken SQL sorgularýný doðrudan yazmak yerine nesne yönelimli bir 
	yaklaþým kullanabilirler. Bu, yazýlým geliþtirme sürecini hýzlandýrabilir ve bakýmýný kolaylaþtýrabilir.

	ORM'nin bazý avantajlarý þunlar olabilir:

		Daha Az SQL Bilgisi Gerekir: ORM kullanmak, programcýlarýn daha az SQL bilgisiyle uygulama geliþtirmelerine olanak tanýr.

		Taþýnabilirlik: ORM, farklý veritabaný sistemleri arasýnda daha iyi taþýnabilirlik saðlar. Çoðu ORM çözümü, desteklediði farklý veritabaný sistemleri 
						arasýnda geçiþ yapmayý kolaylaþtýrýr.

		Daha Kolay Bakým: ORM'nin saðladýðý soyutlama, kodun bakýmýný kolaylaþtýrabilir. Veritabaný þemasýnda yapýlan deðiþiklikler, 
						  genellikle sadece ORM konfigürasyonlarýný güncellemeyi gerektirir.

		Daha Az Tekrar: ORM, veritabaný iþlemleri için kullanýlan kodun tekrarýný azaltabilir, çünkü genellikle genel veritabaný iþlemleri için kullanýlabilen 
						hazýr fonksiyonlar içerir.

	Örnek olarak, Django, Hibernate, Entity Framework gibi çeþitli ORM kütüphaneleri mevcuttur ve bu kütüphaneler farklý programlama dillerinde 
	(Python, Java, .NET vb.) kullanýlabilirler.

-NuGet?