using System;
using System.Collections;
using System.Windows.Forms;
using Soneta.Types;
using Soneta.Business;
using Soneta.Business.App;
using Soneta.Towary;
using Soneta.Handel;
using Soneta.Magazyny;
using Soneta.CRM;
using Soneta.Kasa;
using Soneta.Core;
using Soneta.EwidencjaVat;
using Soneta.Ksiega;

namespace PrzykladHandel
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing ) {
            if( disposing ) {
                ////////////////////////////////////////////////////////////////
                // Poniewa� obiekt Login mo�e przechowywa� po��czenie do
                // bazy danych (IDbConnection) nale�y zwolni� zasoby przez
                // niego u�ywane.
                //
                if (login!=null)
                    login.Dispose();

                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
					this.buttonPZ = new System.Windows.Forms.Button();
					this.buttonINW = new System.Windows.Forms.Button();
					this.buttonKorekta = new System.Windows.Forms.Button();
					this.textID = new System.Windows.Forms.TextBox();
					this.buttonPrzelew = new System.Windows.Forms.Button();
					this.cbGot�wka = new System.Windows.Forms.CheckBox();
					this.cbPrzelew = new System.Windows.Forms.CheckBox();
					this.buttonRW = new System.Windows.Forms.Button();
					this.buttonKontrahent = new System.Windows.Forms.Button();
					this.buttonKontrahenci = new System.Windows.Forms.Button();
					this.buttonTowary = new System.Windows.Forms.Button();
					this.buttonPZZK = new System.Windows.Forms.Button();
					this.buttonRaport = new System.Windows.Forms.Button();
					this.buttonWp�ata = new System.Windows.Forms.Button();
					this.buttonRozliczenie = new System.Windows.Forms.Button();
					this.buttonEwidencjaSprzedazy = new System.Windows.Forms.Button();
					this.SuspendLayout();
					// 
					// buttonPZ
					// 
					this.buttonPZ.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonPZ.Location = new System.Drawing.Point(12, 12);
					this.buttonPZ.Name = "buttonPZ";
					this.buttonPZ.Size = new System.Drawing.Size(164, 48);
					this.buttonPZ.TabIndex = 0;
					this.buttonPZ.Text = "Generowanie dokumentu PZ";
					this.buttonPZ.Click += new System.EventHandler(this.buttonPZ_Click);
					// 
					// buttonINW
					// 
					this.buttonINW.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonINW.Location = new System.Drawing.Point(12, 132);
					this.buttonINW.Name = "buttonINW";
					this.buttonINW.Size = new System.Drawing.Size(164, 48);
					this.buttonINW.TabIndex = 2;
					this.buttonINW.Text = "Generowanie dokumentu Inwentaryzacji";
					this.buttonINW.Click += new System.EventHandler(this.buttonINW_Click);
					// 
					// buttonKorekta
					// 
					this.buttonKorekta.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonKorekta.Location = new System.Drawing.Point(12, 192);
					this.buttonKorekta.Name = "buttonKorekta";
					this.buttonKorekta.Size = new System.Drawing.Size(164, 44);
					this.buttonKorekta.TabIndex = 3;
					this.buttonKorekta.Text = "Korekta sprzeda�y dokumentu o zadanym ID";
					this.buttonKorekta.Click += new System.EventHandler(this.buttonKorekta_Click);
					// 
					// textID
					// 
					this.textID.Location = new System.Drawing.Point(204, 204);
					this.textID.Name = "textID";
					this.textID.Size = new System.Drawing.Size(76, 20);
					this.textID.TabIndex = 6;
					this.textID.Text = "18";
					// 
					// buttonPrzelew
					// 
					this.buttonPrzelew.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonPrzelew.Location = new System.Drawing.Point(12, 248);
					this.buttonPrzelew.Name = "buttonPrzelew";
					this.buttonPrzelew.Size = new System.Drawing.Size(164, 44);
					this.buttonPrzelew.TabIndex = 4;
					this.buttonPrzelew.Text = "Faktura sprzeda�y";
					this.buttonPrzelew.Click += new System.EventHandler(this.buttonPrzelew_Click);
					// 
					// cbGot�wka
					// 
					this.cbGot�wka.Checked = true;
					this.cbGot�wka.CheckState = System.Windows.Forms.CheckState.Checked;
					this.cbGot�wka.Location = new System.Drawing.Point(200, 252);
					this.cbGot�wka.Name = "cbGot�wka";
					this.cbGot�wka.Size = new System.Drawing.Size(128, 24);
					this.cbGot�wka.TabIndex = 7;
					this.cbGot�wka.Text = "Zap�acono got�wk�";
					// 
					// cbPrzelew
					// 
					this.cbPrzelew.Checked = true;
					this.cbPrzelew.CheckState = System.Windows.Forms.CheckState.Checked;
					this.cbPrzelew.Location = new System.Drawing.Point(200, 276);
					this.cbPrzelew.Name = "cbPrzelew";
					this.cbPrzelew.Size = new System.Drawing.Size(116, 24);
					this.cbPrzelew.TabIndex = 8;
					this.cbPrzelew.Text = "Na przelew 21 dni";
					// 
					// buttonRW
					// 
					this.buttonRW.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonRW.Location = new System.Drawing.Point(12, 72);
					this.buttonRW.Name = "buttonRW";
					this.buttonRW.Size = new System.Drawing.Size(164, 48);
					this.buttonRW.TabIndex = 1;
					this.buttonRW.Text = "Generowanie dokumentu RW";
					this.buttonRW.Click += new System.EventHandler(this.buttonRW_Click);
					// 
					// buttonKontrahent
					// 
					this.buttonKontrahent.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonKontrahent.Location = new System.Drawing.Point(188, 12);
					this.buttonKontrahent.Name = "buttonKontrahent";
					this.buttonKontrahent.Size = new System.Drawing.Size(164, 48);
					this.buttonKontrahent.TabIndex = 5;
					this.buttonKontrahent.Text = "Zak�adanie karty kontrahenta";
					this.buttonKontrahent.Click += new System.EventHandler(this.buttonKontrahent_Click);
					// 
					// buttonKontrahenci
					// 
					this.buttonKontrahenci.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonKontrahenci.Location = new System.Drawing.Point(12, 304);
					this.buttonKontrahenci.Name = "buttonKontrahenci";
					this.buttonKontrahenci.Size = new System.Drawing.Size(164, 44);
					this.buttonKontrahenci.TabIndex = 4;
					this.buttonKontrahenci.Text = "Filtrowana lista kontrahent�w";
					this.buttonKontrahenci.Click += new System.EventHandler(this.buttonKontrahenci_Click);
					// 
					// buttonTowary
					// 
					this.buttonTowary.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonTowary.Location = new System.Drawing.Point(12, 360);
					this.buttonTowary.Name = "buttonTowary";
					this.buttonTowary.Size = new System.Drawing.Size(164, 44);
					this.buttonTowary.TabIndex = 4;
					this.buttonTowary.Text = "Filtrowana lista towar�w";
					this.buttonTowary.Click += new System.EventHandler(this.buttonTowary_Click);
					// 
					// buttonPZZK
					// 
					this.buttonPZZK.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonPZZK.Location = new System.Drawing.Point(188, 72);
					this.buttonPZZK.Name = "buttonPZZK";
					this.buttonPZZK.Size = new System.Drawing.Size(164, 48);
					this.buttonPZZK.TabIndex = 0;
					this.buttonPZZK.Text = "Generowanie z dokumentu PZ dokumentu ZK";
					this.buttonPZZK.Click += new System.EventHandler(this.buttonPZZK_Click);
					// 
					// buttonRaport
					// 
					this.buttonRaport.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonRaport.Location = new System.Drawing.Point(360, 12);
					this.buttonRaport.Name = "buttonRaport";
					this.buttonRaport.Size = new System.Drawing.Size(164, 48);
					this.buttonRaport.TabIndex = 5;
					this.buttonRaport.Text = "Generowanie raportu kasowego";
					this.buttonRaport.Click += new System.EventHandler(this.buttonRaport_Click);
					// 
					// buttonWp�ata
					// 
					this.buttonWp�ata.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonWp�ata.Location = new System.Drawing.Point(360, 72);
					this.buttonWp�ata.Name = "buttonWp�ata";
					this.buttonWp�ata.Size = new System.Drawing.Size(164, 48);
					this.buttonWp�ata.TabIndex = 5;
					this.buttonWp�ata.Text = "Generowanie wp�aty";
					this.buttonWp�ata.Click += new System.EventHandler(this.buttonWp�ata_Click);
					// 
					// buttonRozliczenie
					// 
					this.buttonRozliczenie.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonRozliczenie.Location = new System.Drawing.Point(360, 132);
					this.buttonRozliczenie.Name = "buttonRozliczenie";
					this.buttonRozliczenie.Size = new System.Drawing.Size(164, 48);
					this.buttonRozliczenie.TabIndex = 5;
					this.buttonRozliczenie.Text = "Rozliczenie faktury";
					this.buttonRozliczenie.Click += new System.EventHandler(this.buttonRozliczenie_Click);
					// 
					// buttonEwidencjaSprzedazy
					// 
					this.buttonEwidencjaSprzedazy.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonEwidencjaSprzedazy.Location = new System.Drawing.Point(360, 190);
					this.buttonEwidencjaSprzedazy.Name = "buttonEwidencjaSprzedazy";
					this.buttonEwidencjaSprzedazy.Size = new System.Drawing.Size(164, 48);
					this.buttonEwidencjaSprzedazy.TabIndex = 9;
					this.buttonEwidencjaSprzedazy.Text = "Ewidencja sprzeda�y";
					this.buttonEwidencjaSprzedazy.Click += new System.EventHandler(this.buttonEwidencjaSprzedazy_Click);
					// 
					// Form1
					// 
					this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
					this.ClientSize = new System.Drawing.Size(532, 418);
					this.Controls.Add(this.buttonEwidencjaSprzedazy);
					this.Controls.Add(this.cbPrzelew);
					this.Controls.Add(this.cbGot�wka);
					this.Controls.Add(this.textID);
					this.Controls.Add(this.buttonKorekta);
					this.Controls.Add(this.buttonPZ);
					this.Controls.Add(this.buttonINW);
					this.Controls.Add(this.buttonPrzelew);
					this.Controls.Add(this.buttonRW);
					this.Controls.Add(this.buttonKontrahent);
					this.Controls.Add(this.buttonKontrahenci);
					this.Controls.Add(this.buttonTowary);
					this.Controls.Add(this.buttonPZZK);
					this.Controls.Add(this.buttonRaport);
					this.Controls.Add(this.buttonWp�ata);
					this.Controls.Add(this.buttonRozliczenie);
					this.Name = "Form1";
					this.Text = "Form1";
					this.Load += new System.EventHandler(this.Form1_Load);
					this.ResumeLayout(false);
					this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            //
            // Przed jakimikolwiek operacjami na logice biznesowej enova
            // nale�y zadba� o to, �eby wszystkie biblioteki by�y za�adowe.
            // Powoduje to ich automatyczne zarejestrowanie i zainicjowanie.
            //
			Soneta.Start.Loader loader = new Soneta.Start.Loader();
			loader.WithExtensions = true;
			loader.Load();

            Application.EnableVisualStyles();
            Application.DoEvents();
            Application.Run(new Form1());
        }

        private System.Windows.Forms.Button buttonPZ;
        private System.Windows.Forms.Button buttonINW;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button buttonKorekta;
        private System.Windows.Forms.Button buttonPrzelew;
        private System.Windows.Forms.CheckBox cbGot�wka;
        private System.Windows.Forms.CheckBox cbPrzelew;
        private System.Windows.Forms.Button buttonRW;
        private System.Windows.Forms.Button buttonKontrahent;
        private System.Windows.Forms.Button buttonKontrahenci;
        private System.Windows.Forms.Button buttonTowary;
        private System.Windows.Forms.Button buttonPZZK;
        private System.Windows.Forms.Button buttonRaport;
        private System.Windows.Forms.Button buttonWp�ata;
        private System.Windows.Forms.Button buttonRozliczenie;
			private Button buttonEwidencjaSprzedazy;

        /// <summary>
        /// To jest pole zawieraj�ce informacje o loginie do bazy danych,
        /// na kt�rym b�d� robione wszystkie operacje.
        /// </summary>
        Login login;

        #region Inicjacja po��czenia do bazy danych

        private void Form1_Load(object sender, System.EventArgs e) {
            /////////////////////////////////////////////////////////////////
            // Nast�pnie uzyskujemy dost�p do obiektu bazy danych
            // reprezentuj�cego baz� danych jako tak�, bez zalogowanego
            // jeszcze operatora. Rejestrowanie bazy danych mo�na zrobi� 
            // przy pomocy programu enova. Napis "Demo" jest nazw� bazy
            // wy�wietlan� w programie enova.
            //
            Database database = BusApplication.Instance["Demo"];

            ////////////////////////////////////////////////////////////////
            // Kolejnym krokiem jest uzyskanie loginu do bazy danych, czyli
            // zalogowanie si� operatora. Oczywi�cie odpowiedni operator
            // musi by� wcze�niej wprowadzony w programie enova.
            // W przyk�adzie poni�ej loguj� si� na operatora "Administrator"
            // z pustym has�em (brak has�a).
            //
            login = database.Login(false, "Administrator", "");
        }

        #endregion

        #region Utworzenie dokumentu PZ

        private void buttonPZ_Click(object sender, System.EventArgs e) {
            ///////////////////////////////////////////////////////////////////
            // Metoda tworzy nowy dokument PZ wype�niaj�c go przyk�adowymi
            // pozycjami
            //

            //////////////////////////////////////////////////////////////////
            // Rozpocz�cie tworzenia dokumentu (w og�le operacji na logice
            // biznesowej) polega na utworzeniu obiektu sesji (Session),
            // w kt�rym b�d� odbywa� si� poszczeg�lne operacje.
            // Pierwszy parametr okre�la, czy sesja jest tylko do odczytu
            // danych, drugi parametr, czy sesja b�dzie modyfikowa� ustawienia
            // konfiguracyjne (tj definicje dokument�w, jednostki, 
            // definicje cen, itp). Standardowo obydwa parametry dajemy false.
            //
            using (Session session = login.CreateSession(false, false)) {

                //////////////////////////////////////////////////////////////////
                // Po utworzeniu sesji dobrze jest sobie przygotowa� odpowiednie 
                // zmiene reprezentuj�ce poszczeg�lne modu�y programu w tej sesji.
                // Wystarczy przygotwa� tylko te modu�y, kt�re b�d� nam potrzebne.
                //
                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                //////////////////////////////////////////////////////////////////
                // Wszystkie operacje wykonujemy w transakcji sesji kt�r� nale�y
                // na pocz�tku otworzy�. W transakcji mo�emy wskaza� czy b�d� 
                // robione zmiany w danych.
                //
                using (ITransaction trans = session.Logout(true)) {

                    //////////////////////////////////////////////////////////////////
                    // Nast�pnie nale�y utworzy� nowy obiekt reprezentuj�cy dokument
                    // handlowy (nag��wek dokumentu). 
                    //
                    DokumentHandlowy dokument = new DokumentHandlowy();
		
                    //////////////////////////////////////////////////////////////////
                    // Nowy dokument nalezy r�wnie� zwi�za� z definicj� dokumentu 
                    // handlowego. W tym przypadku wyszukujemy definicje wyszukujemy
                    // wg jej symbolu "PZ".
                    //
                    DefDokHandlowego definicja = hm.DefDokHandlowych.WgSymbolu["PZ"];
                    if (definicja==null) 
                        throw new InvalidOperationException("Nieznaleziona definicja dokumentu PZ.");
                    dokument.Definicja = definicja;

                    /////////////////////////////////////////////////////////////////
                    // Dokument nale�y te� przypisa� do magazynu, do kt�rego b�dzie
                    // przyjmowany towar. Poni�ej przypisywany jest standardowy
                    // magazyn programu "Firma".
                    //
                    dokument.Magazyn = mm.Magazyny.Firma;

                    /////////////////////////////////////////////////////////////////
                    // Oraz dodajemy nowo utworzony dokument do aktualnej sesji.
                    //
                    hm.DokHandlowe.AddRow(dokument);

                    /////////////////////////////////////////////////////////////////
                    // Przyj�cie magazynowe PZ (z zewn�trz) wymaga r�wnie�
                    // przypisania kontrahenta, od kt�rego towaru jest przyjmowany.
                    // Przyk�ad prezentuje przypisanie dokumentowi kontrahenta
                    // o kodzie "ABC".
                    Kontrahent kontrahent = cm.Kontrahenci.WgKodu["ABC"];
                    if (kontrahent==null) 
                        throw new InvalidOperationException("Nieznaleziony kontrahent o kodzie ABC.");
                    dokument.Kontrahent = kontrahent;

                    /////////////////////////////////////////////////////////////////
                    // PUNKT A ******************************************************
                    // W kartotece towar�w wyszuka� towar. Przyk�ad poni�ej
                    // prezentuje wyszukanie towaru wg kodu EAN "2000000000022". 
                    // Poniewa� w kartotece mo�e znajdowa� si� wiele towar�w o tym 
                    // samym kodzie wybrazy zostanie pierwszy z nich.
                    //
					Towar towar = (Towar)tm.Towary.WgEAN["2000000000954"].GetNext();
                    if (towar!=null) {
                        //////////////////////////////////////////////////////////////
                        // Utworzy� nowy obiekt pozycji dokumentu handlowego, kt�ry
                        // zostanie dodany do sescji.
                        //
                        PozycjaDokHandlowego pozycja = new PozycjaDokHandlowego(dokument);
                        hm.PozycjeDokHan.AddRow(pozycja);

                        //////////////////////////////////////////////////////////////
                        // Przypisa� towar do nowo utworzonej pozycji dokumentu, czyli
                        // wskaza�, kt�ry towar ma by� przyj�ty do magazynu.
                        //
                        pozycja.Towar = towar;

                        //////////////////////////////////////////////////////////////
                        // W pozycji dokumentu nale�y jeszcze wprowadzi� ilo��
                        // towaru przyjmowanego na magazyn. Ilo�� reprezentowana jest
                        // przez liczb� 10 b�d�c� warto�ci� ilo�ci (pierwszy parametr) 
                        // oraz jednostk� opisuj�c� t� ilo�� (drugi parametr). Je�eli
                        // jednostka jest null, to przyjmowana jest jednostka z
                        // karty towarowej.
                        // Poni�ej znajduje si� r�wnie� wykomentowany przyk�ad, w
                        // kt�rym w spos�b jawny jest wskazanie na jednostk� w metrach.
                        //
                        pozycja.Ilosc = new Quantity(10, null);
                        // pozycja.Ilosc = new Quantity(10, "m");

                        //////////////////////////////////////////////////////////////
                        // Pozycji dokumentu nale�y r�wnie� przypisa� cen� w jakiej
                        // b�dzie on wprowadzany do magazynu. (cena zakupu)
                        // Poni�ej przypisywana jest cena w PLN. Dlatego nie jest
                        // wyspecyfikowany drugi parametr okre�laj�cy walut� ceny.
                        //
                        pozycja.Cena = new DoubleCy(12.34);

                        //////////////////////////////////////////////////////////////
                        // Poszczeg�lnym pozycj� mo�na przypisa� r�wnie� dodatkowe
                        // cechy, kt�re zale�ne s� od konfiguracji programu. Przyk�ad
                        // pokazuje jak ustawi� cech� z numerem beli.
                        // Kod jest wykomentowany, poniewa� baza demo nie posiada
                        // zdefiniowanej tej cechy.
                        //
                        //pozycja.Features["Numer beli"] = "123456";
                    }

                    /////////////////////////////////////////////////////////////////
                    // Je�eli na dokument ma zawiera� wi�cej pozycji magazynowych
                    // to nale�y ponownie przej�� do PUNKTU A.
                    //

                    /////////////////////////////////////////////////////////////////
                    // Dokumentowi podobnie jak pozycji dokumentu r�wnie� mo�na
                    // przypisa� dodatkowe cechy zale�ne od konfiguracji programu. 
                    // Przyk�ad pokazuje jak ustawi� cech� z lokalizacj�.
                    // Kod jest wykomentowany, poniewa� baza demo nie posiada
                    // zdefiniowanej tej cechy.
                    //
                    //dokument.Features["Lokalizacja"] = "AB/12";

                    /////////////////////////////////////////////////////////////////
                    // Po dokonaniu wszystkich operacji na dokumencie mo�na ten
                    // dokument wprowadzi� (zatwierdzi�), co powoduje zabezpieczenie 
                    // przed przypadkow� edycj� tego dokumentu oraz przeniesienie go
                    // do ewidencji dokument�w ksi�gowych.
                    //
                    dokument.Stan = StanDokumentuHandlowego.Zatwierdzony;

                    /////////////////////////////////////////////////////////////////
                    // Wszystkie operacje zosta�y poprawnie zako�czone i zapewne 
                    // chcemy zatwierdzi� transakcj� sesji.
                    //
                    trans.Commit();
                }

                ////////////////////////////////////////////////////////////////////
                // Powy�sze operacje by�y wykonywane na sesji, czyli w pami�ci.
                // Teraz nale�y rezultat prac zapisa� do bazy danych.
                //
                session.Save();
            }

            ////////////////////////////////////////////////////////////////////
            // I to wszystko. Dokument PZ znajduje si� w bazie.
            //
        }

        #endregion

        #region Utworzenie dokumentu inwentraryzacji

        private void buttonINW_Click(object sender, System.EventArgs e) {
            ///////////////////////////////////////////////////////////////////
            // Metoda tworzy nowy dokument inwentaryzacji wype�niaj�c go 
            // przyk�adowymi pozycjami
            //

            //////////////////////////////////////////////////////////////////
            // Rozpocz�cie tworzenia dokumentu (w og�le operacji na logice
            // biznesowej) polega na utworzeniu obiektu sesji (Session),
            // w kt�rym b�d� odbywa� si� poszczeg�lne operacje.
            // Pierwszy parametr okre�la, czy sesja jest tylko do odczytu
            // danych, drugi parametr, czy sesja b�dzie modyfikowa� ustawienia
            // konfiguracyjne (tj definicje dokument�w, jednostki, 
            // definicje cen, itp). Standardowo obydwa parametry dajemy false.
            //
            using (Session session = login.CreateSession(false, false)) {

                //////////////////////////////////////////////////////////////////
                // Po utworzeniu sesji dobrze jest sobie przygotowa� odpowiednie 
                // zmiene reprezentuj�ce poszczeg�lne modu�y programu w tej sesji.
                // Wystarczy przygotwa� tylko te modu�y, kt�re b�d� nam potrzebne.
                //
                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                //////////////////////////////////////////////////////////////////
                // Wszystkie operacje wykonujemy w transakcji sesji, kt�r� nale�y
                // na pocz�tku otworzy�. W transakcji mo�emy wskaza� czy b�d� 
                // robione zmiany w danych.
                //
                using (ITransaction trans = session.Logout(true)) {

                    //////////////////////////////////////////////////////////////////
                    // Nast�pnie nale�y utworzy� nowy obiekt reprezentuj�cy dokument
                    // handlowy (nag��wek dokumentu). 
                    //
                    DokumentHandlowy dokument = new DokumentHandlowy();
		
                    //////////////////////////////////////////////////////////////////
                    // Nowy dokument nale�y r�wnie� zwi�za� z definicj� dokumentu 
                    // handlowego. W tym przypadku wyszukujemy definicje wyszukujemy
                    // z kolekcji standardowych definicji.
                    //
                    dokument.Definicja = hm.DefDokHandlowych.Inwentaryzacja;

                    /////////////////////////////////////////////////////////////////
                    // Dokument nale�y te� przypisa� do magazynu, do kt�rego b�dzie
                    // przyjmowany towar. Poni�ej przypisywany jest standardowy
                    // magazyn programu "Firma".
                    //
                    dokument.Magazyn = mm.Magazyny.Firma;
				
                    // Ale mo�na wyszuka� magazyn np wg symbolu
                    //dokument.Magazyn = mm.Magazyny.WgSymbol["MAG1"];

                    /////////////////////////////////////////////////////////////////
                    // Oraz dodajemy nowo utworzony dokument do aktualnej sesji.
                    //
                    hm.DokHandlowe.AddRow(dokument);

                    /////////////////////////////////////////////////////////////////
                    // PUNKT A ******************************************************
                    // W kartotece towar�w wyszuka� towar. Przyk�ad poni�ej
                    // prezentuje wyszukanie towaru wg kodu "Buty"
                    // Poniewa� w kartotece mo�e znajdowa� si� wiele towar�w o tym 
                    // samym kodzie wybrazy zostanie pierwszy z nich.
                    //
                    Towar towar = (Towar)tm.Towary.WgKodu["Buty"];
                    if (towar!=null) {
                        //////////////////////////////////////////////////////////////
                        // Utworzy� nowy obiekt pozycji dokumentu handlowego, kt�ry
                        // zostanie dodany do sescji.
                        //
                        PozycjaDokHandlowego pozycja = new PozycjaDokHandlowego(dokument);
                        hm.PozycjeDokHan.AddRow(pozycja);

                        //////////////////////////////////////////////////////////////
                        // Przypisa� towar do nowo utworzonej pozycji dokumentu, czyli
                        // wskaza�, kt�ry towar ma by� przyj�ty do magazynu.
                        //
                        pozycja.Towar = towar;

                        //////////////////////////////////////////////////////////////
                        // W pozycji dokumentu nale�y jeszcze wprowadzi� ilo��
                        // towaru przyjmowanego na magazyn. Ilo�� reprezentowana jest
                        // przez liczb� 10 b�d�c� warto�ci� ilo�ci (pierwszy parametr) 
                        // oraz jednostk� opisuj�c� t� ilo�� (drugi parametr). Je�eli
                        // jednostka jest null, to przyjmowana jest jednostka z
                        // karty towarowej.
                        // Poni�ej znajduje si� r�wnie� wykomentowany przyk�ad, w
                        // kt�rym w spos�b jawny jest wskazanie na jednostk� w metrach.
                        //
                        pozycja.Ilosc = new Quantity(10, null);
                        // pozycja.Ilosc = new Quantity(10, "m");

                        //////////////////////////////////////////////////////////////
                        // Pozycji dokumentu nale�y r�wnie� przypisa� cen� w jakiej
                        // b�dzie on wprowadzany do magazynu. (cena zakupu)
                        // Poni�ej przypisywana jest cena w PLN. Dlatego nie jest
                        // wyspecyfikowany drugi parametr okre�laj�cy walut� ceny.
                        //
                        pozycja.Cena = new DoubleCy(12.34);

                        //////////////////////////////////////////////////////////////
                        // Poszczeg�lnym pozycj� mo�na przypisa� r�wnie� dodatkowe
                        // cechy, kt�re zale�ne s� od konfiguracji programu. Przyk�ad
                        // pokazuje jak ustawi� cech� z numerem beli.
                        // Kod jest wykomentowany, poniewa� baza demo nie posiada
                        // zdefiniowanej tej cechy.
                        //
                        //pozycja.Features["Numer beli"] = "123456";
                    }

                    /////////////////////////////////////////////////////////////////
                    // Je�eli na dokument ma zawiera� wi�cej pozycji magazynowych
                    // to nale�y ponownie przej�� do PUNKTU A.
                    //

                    /////////////////////////////////////////////////////////////////
                    // Dokumentowi podobnie jak pozycji dokumentu r�wnie� mo�na
                    // przypisa� dodatkowe cechy zale�ne od konfiguracji programu. 
                    // Przyk�ad pokazuje jak ustawi� cech� z lokalizacj�.
                    // Kod jest wykomentowany, poniewa� baza demo nie posiada
                    // zdefiniowanej tej cechy.
                    //
                    //dokument.Features["Lokalizacja"] = "AB/12";

                    /////////////////////////////////////////////////////////////////
                    // Wszystkie operacje zosta�y poprawnie zako�czone i zapewne 
                    // chcemy zatwierdzi� transakcj� sesji.
                    //
                    trans.Commit();
                }

                ////////////////////////////////////////////////////////////////////
                // Powy�sze operacje by�y wykonywane na sesji, czyli w pami�ci.
                // Teraz nale�y rezultat prac zapisa� do bazy danych.
                //
                session.Save();
            }

            ////////////////////////////////////////////////////////////////////
            // I to wszystko. Dokument inwentaryzacji znajduje si� ju� w bazie.
            // Dokument ten znajduje si� w buforze, wi�c �eby stany magazynowe
            // mog�y by� zmodyfikowane nale�y zatwierdzi� ten wygenerowany 
            // w�a�nie dokument.
            //
        }

        #endregion

        #region Korekta dokuemntu o zadanym ID

        private void buttonKorekta_Click(object sender, System.EventArgs e) {
            ///////////////////////////////////////////////////////////////////
            // Metoda tworzy dokuemnt koryguj�cy do faktury o zadanym ID
            // Nie umieszczam, kt�re mo�na znale�� w poprzednich przyk�adach
            //

            using (Session session = login.CreateSession(false, false)) {

                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                using (ITransaction trans = session.Logout(true)) {

                    //////////////////////////////////////////////////////////////////
                    // Wyszuka� dokument sprzeda�y o wcze�niej wprowadzonym ID
                    //
                    int id = int.Parse(textID.Text);
                    DokumentHandlowy dokument = hm.DokHandlowe[id];
		
                    //////////////////////////////////////////////////////////////////
                    // Wyszuka� definicj� relacji korekty dla danego typu dokumentu
                    //
                    DefRelacjiKorekta defKorekta =
                        dokument.Definicja.RelacjaKorektyDefinicja as DefRelacjiKorekta;
                    if (defKorekta==null)
                        throw new InvalidOperationException("Dokument "+dokument+" nie ma zdefiniowanej relacji korekty.");

                    /////////////////////////////////////////////////////////////////
                    // Utworzy� dokument korekty. Dokument korenty ma by� tworzony 
                    // zawsze dla pierwszej faktury. Czyli korekta jest robiona dla
                    // "pierwszej" faktury.
                    //
                    DokumentHandlowy korekta = defKorekta.KorygujDokument(dokument);
				
                    /////////////////////////////////////////////////////////////////
                    // Nast�pnie mo�na zmodyfikowa� pozycje na tym dokumencie.
                    //
                    foreach (PozycjaDokHandlowego pozycja in korekta.Pozycje) {

                        /////////////////////////////////////////////////////////////////
                        // Tutaj nale�y dokona� zmian pozycji
                        //

                    }

                    /////////////////////////////////////////////////////////////////
                    // Na koniec mo�na dokument zatwierdzi�.
                    //

                    korekta.Stan = StanDokumentuHandlowego.Zatwierdzony;

                    trans.Commit();
                }

                session.Save();
            }
        }

        #endregion

        #region Faktura VAT

        ///////////////////////////////////////////////////////////////////
        // Metoda tworzy nowy faktury VAT wype�niaj�c go przyk�adowymi
        // pozycjami.
        // Robimy to tak samo jak dokument PZ, z tym, �e szukamy definicji FV.
        // Nast�pnie modyfikujemy p�atno�ci na przelew lub zap�acone got�wk�.
        private void buttonPrzelew_Click(object sender, System.EventArgs e) {
            using (Session session = login.CreateSession(false, false)) {

                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                using (ITransaction trans = session.Logout(true)) {
                    DokumentHandlowy dokument = new DokumentHandlowy();
                    DefDokHandlowego definicja = hm.DefDokHandlowych.WgSymbolu["FV"];
                    if (definicja==null) 
                        throw new InvalidOperationException("Nieznaleziona definicja dokumentu FV.");
                    dokument.Definicja = definicja;

                    dokument.Magazyn = mm.Magazyny.Firma;

                    hm.DokHandlowe.AddRow(dokument);

                    Kontrahent kontrahent = cm.Kontrahenci.WgKodu["ABC"];
                    if (kontrahent==null) 
                        throw new InvalidOperationException("Nieznaleziony kontrahent o kodzie ABC.");
                    dokument.Kontrahent = kontrahent;

                    Towar towar = (Towar)tm.Towary.WgEAN["2000000000022"].GetNext();
                    if (towar!=null) {
                        PozycjaDokHandlowego pozycja = new PozycjaDokHandlowego(dokument);
                        hm.PozycjeDokHan.AddRow(pozycja);
                        pozycja.Towar = towar;
                        pozycja.Ilosc = new Quantity(10, null);
                        pozycja.Cena = new DoubleCy(12.34);
                    }

                    ///////////////////////////////////////////////////////////////////
                    //Modyfikacja p�atno�ci
                    //Standradowo dokument ma wygenerowan� przez system jedn� p�atno��. Zmienimy w niej
                    //spos�b zap�aty, domy�ln� ewidencj� oraz termin p�atno�ci.
                    //Je�eli chcemy mie� wi�cej ni� jedn� p�atno��, to zmniejszamy kwot� w instniej�cej
                    //i dodajemy kolejne p�atno�ci a� do zr�wnowa�enia kwoty p�atno�ci i dokumentu.
                    //Dodatkowo, je�eli generujemy p�atno�� got�wkow�, to dodamy do niej informacj�
                    //o zap�acieniu i odpowiedni wpis na raport kasowy (musi by� za�o�ony 
                    //  i niezatwierdzony)

                    //Wymuszamy przeliczenie zdarze�. W przeciwnym razie sumy mog� by� nieaktualne
                    //Normalnie robi to za nas UI
                    session.Events.Invoke();

                    KasaModule kasa = KasaModule.GetInstance(session);

                    Naleznosc got�wka = null;
                    Naleznosc przelew = null;
                    //Pobieramy isntniejac� p�atno��. System zrobi� na pewno jedn� (o ile warto��
                    //dokumentu jest r�na od zera).
                    //Mo�emy te� p�atno�� usun�� i odtworzy� dok�adnie tak samo jak to jest 
                    //robione z dodatkow� p�atno�ci�
                    Naleznosc p�atno�� = (Naleznosc)dokument.Platnosci.GetNext();
                    if (cbGot�wka.Checked && cbPrzelew.Checked) {
                        Currency kwota = p�atno��.Kwota;
                        p�atno��.Kwota = p�atno��.Kwota/2;
                        got�wka = p�atno��;
                        //Tworzymy nowy obiekt nale�no�ci
                        przelew = new Naleznosc(dokument);
                        //Dodajemy go do tabeli Platnosci
                        kasa.Platnosci.AddRow(przelew);
                        //I ustawiamy kwot�
                        przelew.Kwota = kwota - got�wka.Kwota;
                    }
                    else if (cbGot�wka.Checked)
                        got�wka = p�atno��;
                    else if (cbPrzelew.Checked)
                        przelew = p�atno��;

                    //Mamy ju� potrzebne p�atno�ci. Teraz musimy im zmodyfikowa� spos�b zap�aty,
                    //ewidencj� SP oraz termin p�atno�ci
                    //Najpier przelew
                    if (przelew!=null) {
                        //Wyszukujemy spos�b zap�aty. Na szcz�cie dla got�wki mamy standardowy
                        //Mo�emy te� szuka� wg nazwy lub Guid.
                        przelew.SposobZaplaty = kasa.SposobyZaplaty.Przelew;

                        //Szukamy ewidencj� SP.
                        przelew.EwidencjaSP = kasa.EwidencjeSP.WgNazwy["Firmowy rachunek bankowy"];

                        //I termin p�atno�ci
                        przelew.TerminDni = 21;
                    }

                    if (got�wka!=null) {
                        //Wyszukujemy spos�b zap�aty. Na szcz�cie dla got�wki mamy standardowy
                        //Mo�emy te� szuka� wg nazwy lub Guid.
                        got�wka.SposobZaplaty = kasa.SposobyZaplaty.Got�wka;

                        //Szukamy ewidencj� SP.
                        got�wka.EwidencjaSP = kasa.EwidencjeSP.WgNazwy["Kasa got�wkowa"];

                        //I termin p�atno�ci
                        got�wka.TerminDni = 0;

                        //Pozostaje to teraz zap�aci�
                        //Szukamy raportu kasowego. Musi by� istnie� i by� otwarty lub 
                        //nie istnie� i mie� flag� automatyczny.
                        //Oczywi�cie ewidencja SP musi by� typu kasa.
                        RaportESP raport = ((Kasa)got�wka.EwidencjaSP).NowyRaport(dokument, dokument.Data);
                        //Tworzymy nowy dokument wp�aty
                        Wplata wp�ata = new Wplata(dokument, raport);
                        //Dodajemy go do tabeli
                        kasa.Zaplaty.AddRow(wp�ata);
                        //Ustawiamy podmiot (taki jak w nale�no�ci)
                        wp�ata.Podmiot = dokument.Kontrahent;
                        //... spos�b zap�aty
                        wp�ata.SposobZaplaty = got�wka.SposobZaplaty;
                        //... opis wystawrczy zainicjowa�, zostanie przeliczony podczas zapisu
                        wp�ata.Opis = "?";
                        //Oraz oczywi�cie kwot�.
                        wp�ata.Kwota = got�wka.Kwota;

                        //Wp�ata z nale�no�ci� zostan� rozliczone podczas zatwierdzania dokumentu
                    }

                    //...
                    dokument.Stan = StanDokumentuHandlowego.Zatwierdzony;

                    trans.Commit();
                }

                session.Save();
            }
        }

        #endregion

        #region Utworzenie dokumentu RW

        private void buttonRW_Click(object sender, System.EventArgs e) {
            ///////////////////////////////////////////////////////////////////
            // Metoda tworzy nowy dokument RW wype�niaj�c go przyk�adowymi
            // pozycjami
            //

            //////////////////////////////////////////////////////////////////
            // Rozpocz�cie tworzenia dokumentu (w og�le operacji na logice
            // biznesowej) polega na utworzeniu obiektu sesji (Session),
            // w kt�rym b�d� odbywa� si� poszczeg�lne operacje.
            // Pierwszy parametr okre�la, czy sesja jest tylko do odczytu
            // danych, drugi parametr, czy sesja b�dzie modyfikowa� ustawienia
            // konfiguracyjne (tj definicje dokument�w, jednostki, 
            // definicje cen, itp). Standardowo obydwa parametry dajemy false.
            //
            using (Session session = login.CreateSession(false, false)) {

                //////////////////////////////////////////////////////////////////
                // Po utworzeniu sesji dobrze jest sobie przygotowa� odpowiednie 
                // zmiene reprezentuj�ce poszczeg�lne modu�y programu w tej sesji.
                // Wystarczy przygotwa� tylko te modu�y, kt�re b�d� nam potrzebne.
                //
                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                //////////////////////////////////////////////////////////////////
                // Wszystkie operacje wykonujemy w transakcji sesji kt�r� nale�y
                // na pocz�tku otworzy�. W transakcji mo�emy wskaza� czy b�d� 
                // robione zmiany w danych.
                //
                using (ITransaction trans = session.Logout(true)) {

                    //////////////////////////////////////////////////////////////////
                    // Nast�pnie nale�y utworzy� nowy obiekt reprezentuj�cy dokument
                    // handlowy (nag��wek dokumentu). 
                    //
                    DokumentHandlowy dokument = new DokumentHandlowy();
		
                    //////////////////////////////////////////////////////////////////
                    // Nowy dokument nalezy r�wnie� zwi�za� z definicj� dokumentu 
                    // handlowego. W tym przypadku wyszukujemy definicje wyszukujemy
                    // wg jej symbolu "PZ".
                    //
                    DefDokHandlowego definicja = hm.DefDokHandlowych.WgSymbolu["RW"];
                    if (definicja==null) 
                        throw new InvalidOperationException("Nieznaleziona definicja dokumentu RW.");
                    dokument.Definicja = definicja;

                    /////////////////////////////////////////////////////////////////
                    // Dokument nale�y te� przypisa� do magazynu, do kt�rego b�dzie
                    // przyjmowany towar. Poni�ej przypisywany jest standardowy
                    // magazyn programu "Firma".
                    //
                    dokument.Magazyn = mm.Magazyny.Firma;

                    /////////////////////////////////////////////////////////////////
                    // Oraz dodajemy nowo utworzony dokument do aktualnej sesji.
                    //
                    hm.DokHandlowe.AddRow(dokument);

                    /////////////////////////////////////////////////////////////////
                    // PUNKT A ******************************************************
                    // W kartotece towar�w wyszuka� towar. Przyk�ad poni�ej
                    // prezentuje wyszukanie towaru wg kodu EAN "2000000000022". 
                    // Poniewa� w kartotece mo�e znajdowa� si� wiele towar�w o tym 
                    // samym kodzie wybrazy zostanie pierwszy z nich.
                    //
					Towar towar = tm.Towary.WgKodu["BIKINI"];
                    if (towar!=null) {
                        //////////////////////////////////////////////////////////////
                        // Utworzy� nowy obiekt pozycji dokumentu handlowego, kt�ry
                        // zostanie dodany do sescji.
                        //
                        PozycjaDokHandlowego pozycja = new PozycjaDokHandlowego(dokument);
                        hm.PozycjeDokHan.AddRow(pozycja);

                        //////////////////////////////////////////////////////////////
                        // Przypisa� towar do nowo utworzonej pozycji dokumentu, czyli
                        // wskaza�, kt�ry towar ma by� wydany z magazynu.
                        //
                        pozycja.Towar = towar;

                        //////////////////////////////////////////////////////////////
                        // W pozycji dokumentu nale�y jeszcze wprowadzi� ilo��
                        // towaru wydawanego z magazynu. Ilo�� reprezentowana jest
                        // przez liczb� 10 b�d�c� warto�ci� ilo�ci (pierwszy parametr) 
                        // oraz jednostk� opisuj�c� t� ilo�� (drugi parametr). Je�eli
                        // jednostka jest null, to przyjmowana jest jednostka z
                        // karty towarowej.
                        // Poni�ej znajduje si� r�wnie� wykomentowany przyk�ad, w
                        // kt�rym w spos�b jawny jest wskazanie na jednostk� w metrach.
                        //
                        pozycja.Ilosc = new Quantity(10, null);
                        // pozycja.Ilosc = new Quantity(10, "m");

                        //////////////////////////////////////////////////////////////
                        // Pozycji dokumentu nale�y r�wnie� przypisa� cen� w jakiej
                        // b�dzie on wprowadzany do magazynu. (cena zakupu)
                        // Poni�ej przypisywana jest cena w PLN. Dlatego nie jest
                        // wyspecyfikowany drugi parametr okre�laj�cy walut� ceny.
                        //
                        pozycja.Cena = new DoubleCy(12.34);

                        //////////////////////////////////////////////////////////////
                        // Poszczeg�lnym pozycj� mo�na przypisa� r�wnie� dodatkowe
                        // cechy, kt�re zale�ne s� od konfiguracji programu. Przyk�ad
                        // pokazuje jak ustawi� cech� z numerem beli.
                        // Kod jest wykomentowany, poniewa� baza demo nie posiada
                        // zdefiniowanej tej cechy.
                        //
                        //pozycja.Features["Numer beli"] = "123456";
                    }

                    /////////////////////////////////////////////////////////////////
                    // Je�eli na dokument ma zawiera� wi�cej pozycji magazynowych
                    // to nale�y ponownie przej�� do PUNKTU A.
                    //

                    /////////////////////////////////////////////////////////////////
                    // Dokumentowi podobnie jak pozycji dokumentu r�wnie� mo�na
                    // przypisa� dodatkowe cechy zale�ne od konfiguracji programu. 
                    // Przyk�ad pokazuje jak ustawi� cech� z lokalizacj�.
                    // Kod jest wykomentowany, poniewa� baza demo nie posiada
                    // zdefiniowanej tej cechy.
                    //
                    //dokument.Features["Lokalizacja"] = "AB/12";

                    /////////////////////////////////////////////////////////////////
                    // W przypadku tego dokumentu przed zatwierdzeniem nale�y 
                    // wcze�niej odpali� zdarzenia, kt�re przelicz� stany magazynowe.
                    session.Events.Invoke();

                    /////////////////////////////////////////////////////////////////
                    // Po dokonaniu wszystkich operacji na dokumencie mo�na ten
                    // dokument wprowadzi� (zatwierdzi�), co powoduje zabezpieczenie 
                    // przed przypadkow� edycj� tego dokumentu oraz przeniesienie go
                    // do ewidencji dokument�w ksi�gowych.
                    //
                    dokument.Stan = StanDokumentuHandlowego.Zatwierdzony;

                    /////////////////////////////////////////////////////////////////
                    // Wszystkie operacje zosta�y poprawnie zako�czone i zapewne 
                    // chcemy zatwierdzi� transakcj� sesji.
                    //
                    trans.Commit();
                }

                ////////////////////////////////////////////////////////////////////
                // Powy�sze operacje by�y wykonywane na sesji, czyli w pami�ci.
                // Teraz nale�y rezultat prac zapisa� do bazy danych.
                //
                session.Save();
            }

            ////////////////////////////////////////////////////////////////////
            // I to wszystko. Dokument RW znajduje si� w bazie.
            //
        }

        #endregion

        #region Zak�adanie karty kontrahenta

        private void buttonKontrahent_Click(object sender, System.EventArgs e) {
            //
            // Przed rozpocz�ciem dodawania nowego obiektu biznesowego 
            // (tj kontrahenta) nale�y tak jak zwykle utworzy� obiekt sesji
            //
            using (Session session = login.CreateSession(false, false)) {

                //
                // Do kontrahent�w wystarczy uzyska� modu� CRM, w kt�rym
                // znajduje si� odpowiednia kolekcja
                //
                CRMModule cm = CRMModule.GetInstance(session);

                //
                // Nast�pnie przeba otworzy� transakcje biznesow� (nie bazodanow�)
                // do edycji
                //
                using (ITransaction trans = session.Logout(true)) {

                    //
                    // Tworzymy nowy, pusty obiekt kontrahenta 
                    //
                    Kontrahent kontrahent = new Kontrahent();

                    //
                    // Nast�pnie dodajemy pusty obiekt kontrahenta do tabeli. 
                    //
                    cm.Kontrahenci.AddRow(kontrahent);
					
                    //
                    // Inicjujemy wymagane pole kod kontrahenta na przypadkow� warto��.
                    // Pole jest unikalne w bazie danych, wie� je�eli kontranhent
                    // o zadanym kodzie ju� istnienie w bazie danych, to podczas podstawiania
                    // warto�ci do property zostanie wygenerowany wyj�tek.
                    //
                    int nr = new Random().Next(10000);
                    kontrahent.Kod = "KOD"+nr;

                    //
                    // Inicjujemy nazw� kontrahenta. To pole nie jest ju� unikalne.
                    // 
                    kontrahent.Nazwa = "Nazwa "+nr;

                    //
                    // Inicjujemy pozosta�e pola, kt�re chcemy zainicjowa�
                    //
                    kontrahent.NIP = "123-45-67-890";
                    kontrahent.Adres.Ulica = "Szara";
                    kontrahent.Adres.NrDomu = "12";
                    kontrahent.Adres.NrLokalu = "34";
                    kontrahent.Adres.Miejscowosc = "Krak�w";
			
                    // 
                    // Zatwierdzamy transakcj� biznesow�
                    //
                    trans.Commit();
                }

                //
                // A na ko�cu ca�o�� zapisujemy do bazy danych
                //
                session.Save();
            }
        }

        #endregion

        #region Przegl�danie listy kontrahent�w

        private void buttonKontrahenci_Click(object sender, System.EventArgs e) {
            //
            // Przygotowa� zmienn� do gromadzenia wynik�w.
            //
            ArrayList rezultat = new ArrayList();

            //
            // Do przegl�dania obiekt�w w bazie danych wystarczy otworzy� sesje
            // w trybie read-only, pierwszy parametr true
            //
            using (Session session = login.CreateSession(true, false)) {

                //
                // Kontrahenci znajduj� si� w module CRM
                //
                CRMModule cm = CRMModule.GetInstance(session);

                //
                // Nast�pnie odczytujemy obiekt reprezentuj�cy tabele 
                // wszystkich kontrahent�w znajduj�cych si� w bazie danych.
                //
                Kontrahenci kontrahenci = cm.Kontrahenci;

                //
                // Je�eli chcemy przegl�dn�� wszystkich kontrahent�w to
                // mo�na wykorzysta� enumerator w celu ich przegl�dni�cia.
                // Przegl�danie odbywa si� wg primary key
                // Zostanie wyci�gni�ta ma�o ciekawa statystyka.
                //
                int suma = 0;
                foreach (Kontrahent kontrahent in kontrahenci) {
                    //
                    // Tutaj mo�na umie�ci� kod przetwarzaj�cy kontrahenta.
                    //
                    suma += kontrahent.Kod.Length;
                }
                rezultat.Add(string.Format(
                    "Suma d�ugo�ci kod�w wszystkich kontrahent�w {0} znak�w", suma));
				
                //
                // Cz�ciej zdarza si� jednak, �e chcemy wyszuka� kontrahent�w 
                // spe�niaj�cych pewne warunki, kt�re najlepiej gdyby liczy�y si�
                // na serwerze SQL. W tym celu nale�y uzyska� obiekt widoku view.
                //
                Soneta.Business.View view = kontrahenci.CreateView();

                //
                // I za�o�y� filtr, np tylko kontrahent�w, zawieraj�cych literk� 
                // 's' w nazwie i o kodzie nie !INCYDENTALNY.
                // Operatory
                // & to jest AND
                // | to jest OR
                // ! to jest NOT
                //
                view.Condition &= new FieldCondition.Like("Nazwa", "*s*")
                    & ! new FieldCondition.Equal("Kod", "!INCYDENTALNY");

                //
                // Teraz mo�emy przegl�dn�� otrzyman� list�
                //
                foreach (Kontrahent kontrahent in view) {
                    rezultat.Add(string.Format("Kod={0}, Nazwa={1}",
                        kontrahent.Kod, kontrahent.Nazwa));
                }

                //
                // No i wy�wietli� okno z rezultatem
                //
                ListaForm form = new ListaForm();
                form.Lista = rezultat;
                form.Owner = this;
                form.Show();

                //
                // Oczywi�cie Session.Save na ko�cu nie jest potrzebny, bo nie 
                // zmienili�my nic w bazie.
                //
            }
        }

        #endregion

        #region Przegl�danie listy towar�w

        private void buttonTowary_Click(object sender, System.EventArgs e) {
            //
            // Przygotowa� zmienn� do gromadzenia wynik�w.
            //
            ArrayList rezultat = new ArrayList();

            //
            // Do przegl�dania obiekt�w w bazie danych wystarczy otworzy� sesje
            // w trybie read-only, pierwszy parametr true
            //
            using (Session session = login.CreateSession(true, false)) {

                //
                // Towary znajduj� si� w module Towary, ale kontrahenci
                // te� si� przydadz�.
                //
                CRMModule cm = CRMModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);

                //
                // Nast�pnie odczytujemy obiekt reprezentuj�cy tabele 
                // wszystkich towar�w znajduj�cych si� w bazie danych.
                //
                Towary towary = tm.Towary;

                //
                // Je�eli chcemy przegl�dn�� wszystkich towar�w to
                // mo�na wykorzysta� enumerator w celu ich przegl�dni�cia.
                // Przegl�danie b�dzie odbywa� si� wg nazwy towaru. 
                // Zostanie wyci�gni�ta ma�o ciekawa statystyka.
                //
                int suma = 0;
                foreach (Towar towar in towary.WgNazwy) {
                    //
                    // Tutaj mo�na umie�ci� kod przetwarzaj�cy towar.
                    //
                    suma += towar.Nazwa.Length;
                }
                rezultat.Add(string.Format(
                    "Suma d�ugo�ci nazw wszystkich towar�w {0} znak�w", suma));

                //
                // Cz�ciej zdarza si� jednak, �e chcemy wyszuka� towary
                // spe�niaj�ce pewne warunki, kt�re najlepiej gdyby liczy�y si�
                // na serwerze SQL. W tym celu nale�y uzyska� obiekt widoku view.
                //
                Soneta.Business.View view = towary.CreateView();

                //
                // I za�o�y� filtr, np tylko towary o cesze 'Kolor' 
                // r�wniej warto�ci 'Czerwony'. Warunek zak�adany jest w�wczas
                // gdy cecha 'Kolor' w og�le istnieje.
                //
                if (towary.FeatureDefinitions.Contains("Kolor"))
                    view.Condition &= new FieldCondition.Equal("Features.Kolor", "Czerwony");

                //
                // Mo�na r�wnie� zak�ada� warunki na pola b�d�ce referencjami
                // do innych obiekt�w.
                // Do��my jeszcze warunek, dla towar�w pochodz�cych od dostawcy
                // 'ABC', o ile taki kontrahent istnieje w bazie.
                //
                Kontrahent kontrahentABC = cm.Kontrahenci.WgKodu["ABC"];
                if (kontrahentABC!=null)
                    view.Condition &= new FieldCondition.Equal("Dostawca", kontrahentABC);

                //
                // Teraz mo�emy przegl�dn�� otrzyman� list�
                //
                foreach (Towar towar in view) {
                    rezultat.Add(string.Format("Kod={0}, Nazwa={1}",
                        towar.Kod, towar.Nazwa));
                }

                //
                // No i wy�wietli� okno z rezultatem
                //
                ListaForm form = new ListaForm();
                form.Lista = rezultat;
                form.Owner = this;
                form.Show();

                //
                // Oczywi�cie Session.Save na ko�cu nie jest potrzebny, bo nie 
                // zmienili�my nic w bazie.
                //
            }
        }

        #endregion

        #region Generowanie z dokumentu PZ dokumentu ZK

        private void buttonPZZK_Click(object sender, System.EventArgs e) {
            //
            // Do poprawnego dzia�ania tej funkcji konieczne jest zdefiniowanie
            // obiegu dokument�w polegaj�cego na wprowadzaniu dokumentu PZ
            // a potem r�cznym generowaniu faktury zakupu ZK.
            //
            // Metoda demonstruje spos�b generowania dokumentu podrz�dnego 
            // relacji do innego dokumentu
            //

            //
            // Standardowo, otwieramy sesj�
            //
            using (Session session = login.CreateSession(false, false)) {

                //
                // Po utworzeniu sesji dobrze jest sobie przygotowa� odpowiednie 
                // zmiene reprezentuj�ce poszczeg�lne modu�y programu w tej sesji.
                // Wystarczy przygotwa� tylko te modu�y, kt�re b�d� nam potrzebne.
                //
                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                //
                // Wszystkie operacje wykonujemy w transakcji sesji kt�r� nale�y
                // na pocz�tku otworzy�. W transakcji mo�emy wskaza� czy b�d� 
                // robione zmiany w danych.
                //
                using (ITransaction trans = session.Logout(true)) {

                    //
                    // Potrzebna definicja dokumentu PZ i dokumentu ZK.
                    //
                    DefDokHandlowego definicjaPZ = hm.DefDokHandlowych.WgSymbolu["PZ"];
                    DefDokHandlowego definicjaZK = hm.DefDokHandlowych.WgSymbolu["ZK"];
                    if (definicjaPZ==null || definicjaZK==null) 
                        throw new InvalidOperationException("Nieznaleziona definicja dokumentu PZ i/lub ZK.");

                    //
                    // Wyszukujemy dokument PZ, z kt�rego ma by� utworzona faktura.
                    //
                    DokumentHandlowy dokumentPZ = hm.DokHandlowe.NumerWgNumeruDokumentu["PZ/000001/05"];
                    if (dokumentPZ==null)
                        throw new InvalidOperationException("Konieczne jest wprowadzenie dokumentu PZ/000001/05.");

                    //
                    // Wyszukujemy definicj� relacji handlowej PZ->ZK
                    //
                    DefRelacjiMagazynowa defRelPZZK = null;
                    foreach (DefRelacjiHandlowej defRel in definicjaPZ.Podrzedne) {
                        if (defRel.DefinicjaPodrzednego==definicjaZK) {
                            defRelPZZK = (DefRelacjiMagazynowa)defRel;
                            break;
                        }
                    }
                    if (defRelPZZK==null)
                        throw new InvalidOperationException("Nieznaleziona definicja relacji PZ->ZK.");

                    //
                    // Alternatywny, szybki spos�b znalezienia tej szczeg�lnej definicji
                    // relacji (czyli to co wy�ej tylko pro�ciej).
                    //
                    defRelPZZK = (DefRelacjiMagazynowa)hm.DefRelHandlowych.PZFZ;
                    if (defRelPZZK==null)
                        throw new InvalidOperationException("Nieznaleziona definicja relacji PZ->ZK.");

                    //
                    // Utworzu� obiekt context, kt�ry b�dzie potrzebny
                    //
                    Context cx = Context.Empty.Clone(session);

                    //
                    // Utworzy� dokument podrz�dny ZK
                    //
                    DokumentDocelowy dd = new DokumentDocelowy(dokumentPZ, defRelPZZK, false, cx);
                    DokumentHandlowy dokumentZK = defRelPZZK.GenerujNowy(dokumentPZ, dd);

                    //
                    // Wszystkie operacje zosta�y poprawnie zako�czone i zapewne 
                    // chcemy zatwierdzi� transakcj� sesji.
                    //
                    trans.Commit();
                }

                ////////////////////////////////////////////////////////////////////
                // Powy�sze operacje by�y wykonywane na sesji, czyli w pami�ci.
                // Teraz nale�y rezultat prac zapisa� do bazy danych.
                //
                session.Save();
            }

            //
            // I to wszystko. Dokument ZK znajduje si� w bazie.
            //
        }

        #endregion

        #region Generowanie raportu kasowego dla ewidencji Kasa Got�wkowa

        private void buttonRaport_Click(object sender, System.EventArgs e) {
            using (Session session = login.CreateSession(false, false)) {
                KasaModule kasa = KasaModule.GetInstance(session);
                RaportESP raport = (RaportESP)kasa.RaportyESP.WgKasa[kasa.EwidencjeSP.Kasa, Date.Today, 1];
                if (raport!=null) 
                    throw new InvalidOperationException("Raport zosta� ju� za�o�ony");

                using (ITransaction t = session.Logout(true)) {
                    raport = new RaportESP(kasa.EwidencjeSP.Kasa, new FromTo(Date.Today, Date.Today));
                    kasa.RaportyESP.AddRow(raport);
                    t.Commit();
                }
                session.Save();
            }
        }

        #endregion

        #region Nowa wp�ata do ewidencji Kasa Got�wkowa

        private void buttonWp�ata_Click(object sender, System.EventArgs e) {
            using (Session session = login.CreateSession(false, false)) {
                KasaModule kasa = KasaModule.GetInstance(session);
                CRMModule crm = CRMModule.GetInstance(session);

                RaportESP raport = (RaportESP)kasa.RaportyESP.WgKasa[kasa.EwidencjeSP.Kasa, Date.Today, 1];
                if (raport==null) 
                    throw new InvalidOperationException("Nie znaleziono raportu kasowego");

                Kontrahent kontrahent = crm.Kontrahenci.WgKodu["ABC"];
                if (kontrahent==null) 
                    throw new InvalidOperationException("Nieznaleziony kontrahent o kodzie ABC.");

                using (ITransaction t = session.Logout(true)) {
                    DokumentWplata wp�ata = new DokumentWplata(raport);
                    kasa.DokumentyKasowe.AddRow(wp�ata);
                    if (!wp�ata.IsReadOnlyData())
                        wp�ata.Data = Date.Today;
                    wp�ata.Zaplata.Podmiot = kontrahent;
                    wp�ata.Zaplata.Kwota = new Currency(100.0m, "PLN");
                    wp�ata.Zaplata.Opis = "Wp�ata do kasy";
                    wp�ata.Zatwierdzony = true;
                    t.Commit();
                }
                session.Save();
            }
        }

        #endregion 

        #region Rozliczenie wp�aty i nale�no�ci dla kontrahenta ABC

        private void buttonRozliczenie_Click(object sender, System.EventArgs e) {
            using (Session session = login.CreateSession(false, false)) {
                KasaModule kasa = KasaModule.GetInstance(session);
                CRMModule crm = CRMModule.GetInstance(session);

                Kontrahent kontrahent = crm.Kontrahenci.WgKodu["ABC"];
                if (kontrahent==null) 
                    throw new InvalidOperationException("Nieznaleziony kontrahent o kodzie ABC.");

                Wplata wp�ata = null;
                Naleznosc nale�no�� = null;

                SubTable st = kasa.RozrachunkiIdx.WgPodmiot[kontrahent, Date.MaxValue];
                foreach (RozrachunekIdx idx in st) {
                    if (idx.Typ==TypRozrachunku.Wp�ata && wp�ata==null)
                        wp�ata = (Wplata)idx.Dokument;
                    if (idx.Typ==TypRozrachunku.Nale�no�� && nale�no��==null)
                        nale�no�� = (Naleznosc)idx.Dokument;
                    if (wp�ata!=null && nale�no��!=null)
                        break;
                }

                if (wp�ata==null || nale�no��==null)
                    throw new InvalidOperationException("Nieznalezione wp�ata lub nale�no�� od kontrahenta ABC");

                using (ITransaction t = session.Logout(true)) {
                    RozliczenieSP rozliczenie = new RozliczenieSP(nale�no��, wp�ata);
                    kasa.RozliczeniaSP.AddRow(rozliczenie);
                    t.Commit();
                }
                session.Save();
            }
        }

        #endregion

			#region Generowanie ewidencji sprzeda�y dla kontrahenta ABC

			private void buttonEwidencjaSprzedazy_Click(object sender, System.EventArgs e) {
				using (Session session = login.CreateSession(false, false)) {
					EwidencjaVatModule vat = EwidencjaVatModule.GetInstance(session);
					CoreModule core = CoreModule.GetInstance(session);
					CRMModule crm = CRMModule.GetInstance(session);
					KsiegaModule ks = KsiegaModule.GetInstance(session);

					Kontrahent kontrahent = crm.Kontrahenci.WgKodu["ABC"];
					if (kontrahent == null)
						throw new InvalidOperationException("Nieznaleziony kontrahent o kodzie ABC.");

					using (ITransaction t = session.Logout(true)) {
						//utowrzenie ewidencji sprzeda�y i dodanie do tabeli ewidencji
						SprzedazEwidencja ewidencja = new SprzedazEwidencja();
						core.DokEwidencja.AddRow(ewidencja);

						//ustawienie dat
						ewidencja.DataWplywu = Date.Today;
						ewidencja.DataDokumentu = Date.Today;
						ewidencja.DataOperacji = Date.Today;

						//ustawienie numeru dokumentu, podmiotu i opisu
						ewidencja.NumerDokumentu = "FV/2007/123456";
						ewidencja.Podmiot = kontrahent;
						ewidencja.Opis = "Faktura sprzeda�y";

						//dodanie element�w VAT
						ElemEwidencjiVATSprzedaz elemVAT = new ElemEwidencjiVATSprzedaz(ewidencja);
						vat.EleEwidencjiVATT.AddRow(elemVAT);
						elemVAT.DefinicjaStawki = core.DefStawekVat[StatusStawkiVat.Opodatkowana, new Percent(0.22m), false];
						elemVAT.Netto = 1000m;

						//P�atno�ci generuj� si� automatycznie po ka�dej zmianie warto�ci ewidencji

						// dodanie opisu analitycznego
						ElementOpisuEwidencji elemOpisu = new ElementOpisuEwidencji(ewidencja);
						ks.OpisAnalityczny.AddRow(elemOpisu);
						elemOpisu.Wymiar = "Przychody";
						elemOpisu.Symbol = "701-0";
						elemOpisu.Kwota = 1000m;

						t.Commit();
					}
					session.Save();
				}
			}

			#endregion

	}
}
