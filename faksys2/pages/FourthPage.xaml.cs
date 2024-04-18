using faksys2.Data;
using faksys2.Lidi;

namespace faksys2.pages;

public partial class FourthPage : ContentPage
{
    Context4 db;
    public FourthPage()
	{
        db = new Context4();
        InitializeComponent();
        OdberatelList.ItemsSource = db.Ods.ToList();
    }

    private void BTNHome_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void AddBTN_Clicked(object sender, EventArgs e)
    {
        string dodavatel = Dodavatel.Text;
        string adresa = Adresa.Text;
        string ic = ICO.Text;
        string dic = DIC.Text;
        string tel = Tel.Text;
        string mail = Mail.Text;
        string cu = CU.Text;


        // DB se sama uzavøe a nebude tak vyset v programu

        //vložení nového auta
        db.Ods.Add(new Od { Dodavatel = dodavatel, Adresa = adresa, Ic = ic, Dic = dic, Tel = tel, Email = mail, CisUc = cu });
        //uložení zmìn textových vstupù
        db.SaveChanges();

        //vymazání obsahz utextových vstupù
        Dodavatel.Text = Adresa.Text = ICO.Text = DIC.Text = Tel.Text = Mail.Text = CU.Text = "";

        //refresh list
        OdberatelList.ItemsSource = null;
        OdberatelList.ItemsSource = db.Ods.ToList();
    }

    private void SmazatBTN_Clicked(object sender, EventArgs e)
    {
        Od l = OdberatelList.SelectedItem as Od;

        if (l != null)
        {
            db.Remove(l);
            db.SaveChanges();

            OdberatelList.ItemsSource = null;
            OdberatelList.ItemsSource = db.Ods.ToList();



        }
    }

    private void FaktBTN_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PdfPage());
    }
}