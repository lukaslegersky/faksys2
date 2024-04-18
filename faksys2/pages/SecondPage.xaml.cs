using faksys2.Data;
using faksys2.Lidi;


namespace faksys2.pages;


public partial class SecondPage : ContentPage
{
    Context2 db;

    public SecondPage()
	{
        db = new Context2();
        InitializeComponent();
        ListKomu.ItemsSource = db.Odberatells.ToList();
    }

    private void BTN1_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void Add2BTN_Clicked(object sender, EventArgs e)
    {
        string odberatel = Odberatel.Text;
        string typpolozky = Typpolozky.Text;
        string cena = Cena.Text;
        string zplatnost = Zplatnost.Text;


        // DB se sama uzav�e a nebude tak vyset v programu

        //vlo�en� nov�ho auta
        db.Odberatells.Add(new Odberatell { Odberatel = odberatel, Typpolozky = typpolozky, Cena = cena, Zplatnost = zplatnost });
        //ulo�en� zm�n textov�ch vstup�
        db.SaveChanges();

        //vymaz�n� obsahz utextov�ch vstup�
        Odberatel.Text = Typpolozky.Text = Cena.Text = Zplatnost.Text = "";

        //refresh list
        ListKomu.ItemsSource = null;
        ListKomu.ItemsSource = db.Odberatells.ToList();
    }

    private void Smazat2BTN_Clicked(object sender, EventArgs e)
    {
        Odberatell l = ListKomu.SelectedItem as Odberatell;

        if (l != null)
        {
            db.Remove(l);
            db.SaveChanges();

            ListKomu.ItemsSource = null;
            ListKomu.ItemsSource = db.Odberatells.ToList();



        }
    }

    private void FaktBTN_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PdfPage());
    }
}