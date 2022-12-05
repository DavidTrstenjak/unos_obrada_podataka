using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace LINQ_XML_dokumenti
{
    public partial class unos : Form
    {
        List<osoba> osobe = new List<osoba>();
        string dokument = "osobe.xml";
        public unos()
        {
            InitializeComponent();
        }

        private void buttonUNESI_Click(object sender, EventArgs e)
        {
            osoba Osoba = new osoba(textBoxIme.Text, textBoxPrezime.Text, Convert.ToInt32(textBoxGodRod.Text));

            osobe.Add(Osoba);

            DialogResult upit = MessageBox.Show("Želite li upisati još osoba?", "Upit",
                MessageBoxButtons.YesNo);

            if (upit == DialogResult.Yes)
            {
                textBoxIme.Clear();
                textBoxGodRod.Clear();
                textBoxPrezime.Clear();
            }
            else
            {
                if (File.Exists(dokument))
                {

                    var OsobeXML = XDocument.Load(dokument);

                    foreach (osoba o in osobe)
                    {
                        var osobica = new XElement("Osoba", new XElement("Ime", Osoba.Ime),
                        new XElement("Prezime", Osoba.Prezime), new XElement("GodRod", Osoba.GodRod));

                        OsobeXML.Root.Add(osobica);
                    }
                    OsobeXML.Save(dokument);
                }
                else
                {
                    var OsobeXML = new XDocument();
                    OsobeXML.Add(new XElement("Osobe"));
                    foreach (osoba o in osobe)
                    {
                        var osobica = new XElement("Osoba", new XElement("Ime", Osoba.Ime),
                        new XElement("Prezime", Osoba.Prezime), new XElement("GodRod", Osoba.GodRod));

                        OsobeXML.Root.Add(osobica);
                    }
                    OsobeXML.Save(dokument);


                    if (File.Exists(dokument))
                    {
                        DialogResult overwrite = MessageBox.Show("Dokument već postoji" + "\r\nŽelite li prepisati stari dokument?",
                            "Dokument postoji!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        if (overwrite == DialogResult.Yes)
                        {
                            OsobeXML.Save(dokument);
                        }
                        else
                        {
                            SaveFileDialog noviDokument = new SaveFileDialog();
                            noviDokument.InitialDirectory = @"C:\";
                            noviDokument.Title = "Spremi novi dokument";
                            noviDokument.DefaultExt = "xml";
                            noviDokument.ShowDialog();

                            dokument = noviDokument.FileName;

                            OsobeXML.Save(dokument);

                        }

                    }
                    this.Close();
                }
            }
        }
    }
}