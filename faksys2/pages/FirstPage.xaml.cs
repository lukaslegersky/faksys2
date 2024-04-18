using faksys2.Lidi;
using faksys2.Data;
using System.Diagnostics;

namespace faksys2.pages;

public partial class NewPage1 : ContentPage
{
    Context db;

    public NewPage1()
	{
        db = new Context();
        InitializeComponent();
        OdList.ItemsSource = db.Lids.ToList();
    }

    private void BTNHome_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void AddBTN_Clicked(object sender, EventArgs e)
    {
        string dodavatel = Dodavatel.Text;
        string typpolozky = Typpolozky.Text;
        string cena = Cena.Text;
        string zplatnost = Zplatnost.Text;


        // DB se sama uzav�e a nebude tak vyset v programu

        //vlo�en� nov�ho auta
        db.Lids.Add(new Lid { Dodavatel = dodavatel, Typpolozky = typpolozky, Cena = cena, Zplatnost = zplatnost });
        //ulo�en� zm�n textov�ch vstup�
        db.SaveChanges();

        //vymaz�n� obsahz utextov�ch vstup�
        Dodavatel.Text = Typpolozky.Text = Cena.Text = Zplatnost.Text = "";

        //refresh list
        OdList.ItemsSource = null;
        OdList.ItemsSource = db.Lids.ToList();

    }

    private async void OdList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Lid l = (sender as ListView).SelectedItem as Lid;

        DisplayAlert("Vybran� Faktura", $" ID: {l.Id} {l.Dodavatel} {l.Typpolozky}", "OK");

    }

    private void SmazatBTN_Clicked(object sender, EventArgs e)
    {
        Lid l = OdList.SelectedItem as Lid;

        if (l != null)
        {
            db.Remove(l);
            db.SaveChanges();

            OdList.ItemsSource = null;
            OdList.ItemsSource = db.Lids.ToList();



        }
    }

    private void FaktBTN_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PdfPage());
    }
}