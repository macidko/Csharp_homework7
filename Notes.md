//VIDEO1

KATMANLAR
	1.Katman
		1.1.Database

	2.Katman
		2.1DataAccess(Db Verilerine Eri�im)
			2.1.1.Veriye eri�im kodlar� yaz�l�r.

	3.Katman
		3.1.Business(�� ve �� Kurallar�)
			3.1.1. �� kodlar� bu katmana yaz�l�r. Kurallar bu b�l�me yaz�l�r. *�rn: B�lgenize yemek teslimat� olup olmad���n�n kontrol�.

	4.Katman
		4.1.API(Application Programming *Interface*, Restful(json))
			4.1.1.UI ve Business katman�n�n ileti�imini sa�layan ara katman

	5.Katman5
		5.1.UI(Android, IOS, Desktop vb.)
			5.1.1.��eri�in g�sterildi�i s�n�f

-Veriye eri�im i�in farkl� teknikler vard�r.
-Herhangi bir katmanda yap�lan de�i�iklik di�er katmanlar� etkilemez.
-SOLID
-PnP : Plug n Play
--Interface methodlar� default publictir. Fakat Interface'in kendisi default public DE��LD�R.
-naming convention
-LINQ(Language Integrated Query) Dil i�erisindeki liste bazl� yap�lar� SQL gibi filtrelemeni sa�lar.

Abstract Klas�r�(Soyut)
	Referans tutucular bulunur.
	Soyut nesneler, interface, abstract class, base class.

Concrete Klas�r�(Somut)
	Ger�ek i�i yapan classlar bukunur.
	Concrete klas�r�ndeki class'lar, veri taban�ndaki bir tabloya kar��l�k gelir.

Internal Class; 
	Yaln�zca bulundu�u proje(katman) i�erisinde ula��labilir. Class'�n default halidir.
Public Class;
	Yaln�zca bulundu�u proje(katman) i�erisinde de�il(internal), di�er projelerin(katmanlar�n) de ula�abilmesi i�in kullan�l�r.


//VIDEO2

-Generic Repository Design Pattern;
	Generic Repository Design Pattern, yaz�l�m geli�tirme s�re�lerinde kullan�lan bir tasar�m desenidir. Bu desen, veritaban� i�lemlerini genel, 
	yeniden kullan�labilir ve tip ba��ms�z bir �ekilde ele almay� ama�lar. Genel olarak, bir Generic Repository (Jenerik Depo), bir veritaban� 
	tablosu veya nesne t�r� i�in temel CRUD (Create, Read, Update, Delete) i�lemlerini i�eren genel operasyonlar� sa�lar.

	Bu desenin ana avantajlar�ndan biri, veritaban� i�lemleri i�in kullan�lan temel kodun tekrar�n� �nlemek ve s�k kullan�lan i�levleri genelle�tirmektir. 
	Bu sayede, benzer i�lemleri ger�ekle�tiren farkl� varl�k t�rleri i�in ayn� kodu kullanabilirsiniz.

	Generic Repository Design Pattern'�n temel �zellikleri �unlar olabilir:

		Genel ve Tip Ba��ms�z Operasyonlar: Bir Generic Repository, farkl� t�rde nesneler i�in genel CRUD i�lemlerini destekler. 
		Bu, herhangi bir varl�k t�r� i�in ayn� temel operasyonlar� kullanman�za olanak tan�r.

		Yeniden Kullan�labilirlik: Generic Repository, �e�itli varl�k t�rleri aras�nda kodun yeniden kullan�labilirli�ini art�r�r.
		CRUD operasyonlar�n� her seferinde tekrar yazmak yerine, bu operasyonlar� genel bir �ekilde kullanabilirsiniz.

		Test Edilebilirlik: Generic Repository'nin sa�lad��� soyutlama, veritaban� i�lemlerini daha kolay bir �ekilde test etmenizi sa�lar. 
		Birim testleri, bu operasyonlar� varl�k t�r�nden ba��ms�z olarak y�r�tebilir.

		Ba��ml�l�klar� Azaltma: Generic Repository, veritaban� i�lemleri i�in kullan�lan kodu bir araya getirir, bu da ba��ml�l�klar� 
		azalt�r ve sistemdeki de�i�ikliklere daha iyi uyum sa�lar.

		Esneklik: Generic Repository, yeni varl�k t�rleri ekledi�inizde veya mevcut varl�k t�rlerini de�i�tirdi�inizde daha az de�i�iklik yapman�za olanak tan�r.

	�rnek olarak, bir .NET uygulamas�nda Generic Repository Design Pattern kullan�m� �u �ekilde g�sterilebilir:

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
			// CRUD operasyonlar�n� implemente et
			// ...
		}

		// Kullan�m �rne�i:
		IRepository<Customer> customerRepository = new GenericRepository<Customer>();
		var customer = customerRepository.GetById(1);

	Bu �rnekte, IRepository aray�z�, temel CRUD operasyonlar�n� i�erir ve GenericRepository s�n�f� bu aray�z� uygular. 
	Customer gibi herhangi bir varl�k t�r� i�in bu generic repository kullan�labilir.

-Refactoring?
	Refactoring, bir yaz�l�m�n i� yap�s�n� iyile�tirmek, kodu daha anla��l�r, s�rd�r�lebilir ve genellikle daha etkili hale getirmek amac�yla 
	yap�lan d�zenlemelerin b�t�n�d�r. Refactoring i�lemi, genellikle mevcut kodun �al��ma davran���n� de�i�tirmeden ger�ekle�tirilir. 
	Bu, yaz�l�m�n kalitesini art�rmak, hata oran�n� d���rmek ve gelecekteki geli�tirmeleri kolayla�t�rmak i�in kullan�l�r.

	Refactoring'in temel prensipleri aras�nda �unlar bulunur:
		Fonksiyonel De�i�iklik Yok: Refactoring i�lemleri, mevcut kodun davran���n� de�i�tirmeden ger�ekle�tirilmelidir. 
		Yani, kullan�c�lara ayn� sonu�lar� vermeye devam etmelidir.

		S�rekli �yile�tirme: Refactoring, genellikle k���k ad�mlar halinde s�rekli olarak uygulanmal�d�r.
		B�y�k, karma��k de�i�iklikler yerine k���k, anlaml� ad�mlar�n tercih edilmesi, hata ay�klama s�recini ve olas� sorunlar� minimize etmeye yard�mc� olabilir.

		Testlerle G�vence Alt�na Alma: Refactoring i�lemleri s�ras�nda, kodun i�levselli�ini korudu�unu do�rulamak i�in varolan testlerin 
		�al��maya devam etmesi veya yeni testler eklenmesi �nemlidir.

		Kod Kalitesi ve Okunabilirlik: Refactoring, genellikle kodun okunabilirli�ini art�rmay�, tekrarlanan kodu azaltmay� ve genel kod kalitesini y�kseltmeyi hedefler.

		Performans �yile�tirmesi: Refactoring, kodun performans�n� art�rmak i�in de kullan�labilir. Ancak bu durumda bile, i�levselli�i de�i�tirmemeye �zen g�sterilmelidir.

	Refactoring �rnekleri �unlar� i�erebilir:
		Kodu Par�alara Ay�rma (Extract Method): Uzun bir fonksiyonu daha k���k, anlaml� par�alara b�lmek.

		De�i�ken �simlendirme ve Yap�land�rma (Rename and Reorganize): De�i�ken adlar�n� ve yap�s�n� daha a��klay�c� hale getirmek.

		Kodun Tekrar Kullan�labilir Hale Getirilmesi (Extract Class, Extract Interface): Belirli bir s�n�ftan veya arabirimden kodu ay�rarak daha genel ve yeniden kullan�labilir hale getirmek.

		Kodu Birle�tirme (Consolidate Code): Benzer i�levlere sahip kod par�alar�n� birle�tirme.

		Kodun Ta��nmas� (Move Code): Belirli bir fonksiyonu veya s�n�f� ba�ka bir konuma ta��ma.

	Refactoring, yaz�l�m geli�tirme s�recinin do�al bir par�as�d�r ve kodun bak�m�n� kolayla�t�r�r, hatalar� azalt�r ve gelecekteki geli�tirmeleri destekler.
-LINQ expression-predicate?
		C# LINQ (Language Integrated Query) i�inde Expression ve Predicate terimleri, sorgu ifadeleri olu�turmak ve filtreleme i�lemleri 
		ger�ekle�tirmek i�in kullan�l�r. �ki terim de �zellikle LINQ sorgular�nda veya LINQ to Entities gibi ORM (Object-Relational Mapping) kullan�ld���nda kar��m�za ��kar.

		Expression:
			Expression s�n�f�, bir ifadeyi temsil eden bir a�a� yap�s� olu�turur. LINQ sorgular�nda kullan�lan lambda ifadelerini veya di�er 
			ifadeleri temsil etmek i�in kullan�l�r.
			Bu, sorgular� sadece derleme zaman�nda de�il, �al��ma zaman�nda da anlayabilme yetene�i sa�lar. Bu, �zellikle dinamik sorgu 
			olu�turmak veya sorgu ifadesini ba�ka bir yerde de�erlendirmek i�in kullan��l�d�r.

		�rnek bir Expression kullan�m�:
			Expression<Func<int, bool>> isEvenExpression = x => x % 2 == 0;

	Predicate:
		Predicate terimi, genellikle bir �art� ifade etmek i�in kullan�l�r. LINQ sorgular�nda, Predicate terimi s�k�a 
		Func<T, bool> t�r�nde ifadeleri ifade eder. Bu ifadeler, genellikle bir koleksiyonu filtrelemek i�in kullan�l�r.

	�rnek bir Predicate kullan�m�:
		Predicate<int> isEvenPredicate = x => x % 2 == 0;

	LINQ sorgular�nda bu terimleri kullanmak, sorgular� daha dinamik hale getirmek ve ko�ullar�n�z� ifade etmek i�in g��l� bir ara� sa�lar. 
	�zellikle LINQ to Entities kullan�yorsan�z, Expression kullanmak, sorgular�n veritaban�nda y�r�t�lmesi s�ras�nda sorgu ifadesinin optimize edilebilmesine olanak tan�r.

-delege?
	C# dilinde delege (delegate), bir t�rd�r ve genellikle metodlar� temsil etmek ve bir metodun ba�ka bir metod taraf�ndan 
	�a�r�labilmesini sa�lamak i�in kullan�l�r. Delegeler, olay tabanl� programlamada, LINQ sorgular�nda ve genel olarak metotlar� referans tipi olarak ta��mak ve i�lemek amac�yla kullan�l�r.

	��te delege ile ilgili baz� temel kavramlar:
		Metot Temsilcisi:
			Delegeler, ba�ka bir metodu temsil etmek �zere kullan�l�r. Bir delege, imzas� (parametre listesi ve d�n�� t�r�) belirli bir metodun referans�n� ta��r.
			Bir delege, bir metodun imzas�n� ve d�n�� t�r�n� belirler. Bu delege tipi, yaln�zca ayn� imza ve d�n�� t�r�ne sahip metodlar�n referans�n� tutabilir.

		Olaylar ve Geri �a�r�lar:
			Delegeler, �zellikle olay tabanl� programlamada (event-driven programming) kullan�l�r. Bir nesnenin belirli bir durumu 
			de�i�ti�inde veya bir eylem ger�ekle�ti�inde ba�ka bir kodu �a��rmak i�in de kullan�l�r.

		LINQ (Language Integrated Query):
			LINQ sorgular�, koleksiyonlarda filtreleme, s�ralama ve gruplama gibi i�lemleri ger�ekle�tirmek i�in genellikle delege kullan�r. 
			�rne�in, Func<T, bool> t�r�ndeki bir delege, bir koleksiyonu filtrelemek i�in LINQ sorgular�nda kullan�labilir.

		Geni�letilebilirlik ve Esneklik:
			Delegeler, kodun geni�letilebilir ve esnek olmas�na yard�mc� olur. �zellikle bir metodu ba�ka bir metoda ge�mek, geri �a��rmak 
			veya bir metodu dinamik olarak belirlemek istedi�inizde kullan��l�d�r.

	��te basit bir C# delege �rne�i:
	// Bir delege tan�mla
	delegate int MatematikselIslem(int x, int y);

	// Bir metot tan�mla
	static int Topla(int x, int y)
	{
		return x + y;
	}

	// Delegeyi bir metoda ba�la
	MatematikselIslem toplamaDelegesi = Topla;

	// Delegeyi kullanarak metodu �a��r
	int sonuc = toplamaDelegesi(3, 5);
	Console.WriteLine("Toplam: " + sonuc);

	Bu �rnekte, MatematikselIslem ad�nda bir delege tan�mlanm�� ve bu delege, Topla ad�ndaki bir metodu temsil eder. 
	Delege, metot referans�n� ta��r ve �a�r�ld���nda Topla metodu �al��t�r�l�r.

-ORM: veritaban� nesneleriyle kodlar aras�nda bir ba� kurup, veritaban� i�lerini yapma s�recidir.
	ORM, "Object-Relational Mapping" (Nesne �li�kisel E�leme) k�saltmas�d�r. ORM, bir programlama tekni�idir ve 
	nesne odakl� programlamay� (OOP) ili�kisel veritaban� sistemleriyle entegre etmeyi ama�lar. Bu sayede, 
	programc�lar nesne tabanl� bir dilde (genellikle bir programlama dilinde) veritaban� i�lemlerini ger�ekle�tirebilirler, 
	bunun sonucunda ise veritaban�ndaki tablolar ve nesne modelleri aras�ndaki d�n���m ve etkile�im otomatik olarak y�netilir.

	Bir ORM sistemi, nesne modellerini veritaban� tablolar�na e�leyen ve bu nesneler aras�nda ili�kileri y�neten bir ara katman sa�lar. 
	Bu sayede, programc�lar veritaban�yla ilgili i�lemleri ger�ekle�tirirken SQL sorgular�n� do�rudan yazmak yerine nesne y�nelimli bir 
	yakla��m kullanabilirler. Bu, yaz�l�m geli�tirme s�recini h�zland�rabilir ve bak�m�n� kolayla�t�rabilir.

	ORM'nin baz� avantajlar� �unlar olabilir:

		Daha Az SQL Bilgisi Gerekir: ORM kullanmak, programc�lar�n daha az SQL bilgisiyle uygulama geli�tirmelerine olanak tan�r.

		Ta��nabilirlik: ORM, farkl� veritaban� sistemleri aras�nda daha iyi ta��nabilirlik sa�lar. �o�u ORM ��z�m�, destekledi�i farkl� veritaban� sistemleri 
						aras�nda ge�i� yapmay� kolayla�t�r�r.

		Daha Kolay Bak�m: ORM'nin sa�lad��� soyutlama, kodun bak�m�n� kolayla�t�rabilir. Veritaban� �emas�nda yap�lan de�i�iklikler, 
						  genellikle sadece ORM konfig�rasyonlar�n� g�ncellemeyi gerektirir.

		Daha Az Tekrar: ORM, veritaban� i�lemleri i�in kullan�lan kodun tekrar�n� azaltabilir, ��nk� genellikle genel veritaban� i�lemleri i�in kullan�labilen 
						haz�r fonksiyonlar i�erir.

	�rnek olarak, Django, Hibernate, Entity Framework gibi �e�itli ORM k�t�phaneleri mevcuttur ve bu k�t�phaneler farkl� programlama dillerinde 
	(Python, Java, .NET vb.) kullan�labilirler.

-NuGet?