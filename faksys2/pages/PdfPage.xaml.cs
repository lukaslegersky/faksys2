
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Drawing;
using System.Reflection;
using System.Xml.Linq;

namespace faksys2.pages;

public partial class PdfPage : ContentPage
{
    public PdfPage()
    {
        InitializeComponent();
    }

    private void BTNHome_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}

