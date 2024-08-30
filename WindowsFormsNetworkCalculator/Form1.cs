using System.Runtime.CompilerServices;

namespace WindowsFormsNetworkCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private static void ComboBocEinfüllen()
        {




        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNetzwerBerechnen_Click(object sender, EventArgs e)
        {
            string adress = txtAdress.Text;
            string cidr = cboCidr.Text;

            // Adresse ausgeben
            long ipv4 = IP4Helper.GetDez(adress);
            string dezOctet = IP4Helper.GetDezOctet(ipv4);
            string binOctet = IP4Helper.GetBinOctet(ipv4);

            WriteString("Adress: ", dezOctet, binOctet);

        }
        // Hilsmethode zum Schreiben einer Zeile in Listbox
        private void WriteString(string bezeichnung, string decOctet = "",string binOctet = "")
        {
            string zeile = bezeichnung.PadLeft(18)+" "+decOctet.PadRight(18)+binOctet;

            listBox1.Items.Add(zeile);



        }
    }
}
