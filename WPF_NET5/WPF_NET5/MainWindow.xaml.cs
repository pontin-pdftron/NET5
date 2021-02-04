using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using pdftron;
using pdftron.Common;
using pdftron.PDF;
using pdftron.PDF.Annots;
using pdftron.SDF;

namespace WpfAppTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PDFNet.Initialize();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (PDFDoc doc = new PDFDoc())
                {
                    doc.InitSecurityHandler();

                    pdftron.PDF.Page newPg = doc.PageCreate();
                    doc.PagePushBack(newPg);

                    Ink ink = Ink.Create(doc, new pdftron.PDF.Rect(110, 10, 300, 200));
                    pdftron.PDF.Point pt3 = new pdftron.PDF.Point(110, 10);
                    //pt3.x = 110; pt3.y = 10;
                    ink.SetPoint(0, 0, pt3);
                    pt3.x = 150; pt3.y = 50;
                    ink.SetPoint(0, 1, pt3);
                    pt3.x = 190; pt3.y = 60;
                    ink.SetPoint(0, 2, pt3);
                    pt3.x = 180; pt3.y = 90;
                    ink.SetPoint(1, 0, pt3);
                    pt3.x = 190; pt3.y = 95;
                    ink.SetPoint(1, 1, pt3);
                    pt3.x = 200; pt3.y = 100;
                    ink.SetPoint(1, 2, pt3);
                    pt3.x = 166; pt3.y = 86;
                    ink.SetPoint(2, 0, pt3);s
                    pt3.x = 196; pt3.y = 96;
                    ink.SetPoint(2, 1, pt3);
                    pt3.x = 221; pt3.y = 121;
                    ink.SetPoint(2, 2, pt3);
                    pt3.x = 288; pt3.y = 188;
                    ink.SetPoint(2, 3, pt3);
                    ink.SetColor(new ColorPt(0, 1, 1), 3);
                    newPg.AnnotPushBack(ink);

                    // Save as a linearized file which is most popular  
                    // and effective format for quick PDF Viewing.
                    doc.Save("linearized_output.pdf", SDFDoc.SaveOptions.e_linearized);

                    System.Console.WriteLine("Done. Results saved in linearized_output.pdf");

                    MessageBox.Show("Done. Results saved in linearized_output.pdf", "Document Creation");
                }
            }
            catch (PDFNetException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
