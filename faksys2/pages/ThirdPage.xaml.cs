using faksys2.Data;
using faksys2.Lidi;

namespace faksys2.pages;

public partial class ThirdPage : ContentPage
{
    Context3 db;
	public ThirdPage()
	{
        db = new Context3();
        InitializeComponent();
        OdberatelList.ItemsSource = db.Komus.ToList();
    }

    private void BTNHome_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void AddBTN_Clicked(object sender, EventArgs e)
    {
        string odberatel = Odberatel.Text;
        string adresa = Adresa.Text;
        string ic = ICO.Text;
        string dic = DIC.Text;
        string tel = Tel.Text;
        string mail = Mail.Text;
        string cu = CU.Text;


        // DB se sama uzav�e a nebude tak vyset v programu

        //vlo�en� nov�ho auta
        db.Komus.Add(new Komu { Odberatel = odberatel, Adresa = adresa, Ic = ic, Dic  = dic, Tel = tel, Email = mail, CisUc = cu});
        //ulo�en� zm�n textov�ch vstup�
        db.SaveChanges();

        //vymaz�n� obsahz utextov�ch vstup�
        Odberatel.Text = Adresa.Text = ICO.Text = DIC.Text = Tel.Text = Mail.Text = CU.Text = "";

        //refresh list
        OdberatelList.ItemsSource = null;
        OdberatelList.ItemsSource = db.Komus.ToList();
    }

    private void SmazatBTN_Clicked(object sender, EventArgs e)
    {
        Odberatell l = OdberatelList.SelectedItem as Odberatell;

        if (l != null)
        {
            db.Remove(l);
            db.SaveChanges();

            OdberatelList.ItemsSource = null;
            OdberatelList.ItemsSource = db.Komus.ToList();



        }
    }

    private void FaktBTN_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PdfPage());
    }
}