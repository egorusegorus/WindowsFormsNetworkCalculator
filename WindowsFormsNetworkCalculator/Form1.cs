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
            int[] ipAdresse = IPAdresseArr(adress);
            
            // Adresse ausgeben
            long ipv4 = IP4Helper.GetDez(adress);
            string dezOctet = IP4Helper.GetDezOctet(ipv4);
            string binOctet = IP4Helper.GetBinOctet(ipv4);
            int[] SubmaskeInt = SubMaske();
            string Submaske = SubmaskeInt[0] + "." + SubmaskeInt[1] + "." + SubmaskeInt[2] + "." + SubmaskeInt[3];
            int[] WildCard = { 255 - SubmaskeInt[0], 255 - SubmaskeInt[1], 255 - SubmaskeInt[2], 255 - SubmaskeInt[3] };           
            string WildCardstr = WildCard[0] + "." + WildCard[1] + "." + WildCard[2] + "." + WildCard[3];
            int[] NetzwerkAdresse= NetzwerkAdresseMethode(SubmaskeInt,ipAdresse);
            string NetzwerkAdresseStr= NetzwerkAdresse[0] + "." + NetzwerkAdresse[1] + "." + NetzwerkAdresse[2] + "." + NetzwerkAdresse[3];
            
            WriteString("Adress:           ", dezOctet, binOctet);
            WriteString("Netzerk Submaske: ", string.Join("."), Submaske);
            WriteString("Wild Card: ", string.Join("."), WildCardstr);
            WriteString("Netzweradresse: ", string.Join("."), NetzwerkAdresseStr);
            WriteString("Erste freie Adresse: " + NetzwerkAdresse[0] + "." + NetzwerkAdresse[1] + "." + NetzwerkAdresse[2] + "." + (NetzwerkAdresse[3] +1));
            WriteString("Letzte freie Adresse: " + NetzwerkAdresse[0]+".");//TODO
            WriteString("Broadcast freie Adresse: ", string.Join("."), NetzwerkAdresseStr);

        }
        
        public int[] IPAdresseArr(string adress)
        {
            string[] strParts = adress.Split('.');
            if (strParts.Length != 4)
            {
                throw new FormatException("Ungültiges IP-Adressformat.");
            }

            int[] adressIp = new int[4];
            for (int i = 0; i < 4; i++)
            {
                if (!int.TryParse(strParts[i], out adressIp[i]) || adressIp[i] < 0 || adressIp[i] > 255)
                {
                    throw new FormatException($"Ungültiger IP-Adressenteil: {strParts[i]}");
                }
            }
            return adressIp;
        }

        public int[] NetzwerkAdresseMethode( int[] SubmaskeInt, int[] ipAdresse)// hier
        {
            int[] NetzwerkAdresse = new int[4];
            for (int i = 0; i < 4; i++)
            {
                if (SubmaskeInt[i] == 255)
                {
                    NetzwerkAdresse[i] = ipAdresse[i];
                }
                else
                {
                    NetzwerkAdresse[i] = SubmaskeInt[i] & ipAdresse[i];
                    break;
                }
                
            }
            return NetzwerkAdresse;
        }
        public int[] SubMaske()
        {
            // Daten aus der Benutzeroberfläche abrufen
            string adressStr = txtAdress.Text;
            string cidrStr = cboCidr.Text;

            // CIDR-String in eine Zahl konvertieren
            if (!int.TryParse(cidrStr, out int cidrIp) || cidrIp < 0 || cidrIp > 32)
            {
                throw new ArgumentException("Ungültiger CIDR-Wert.");
            }

            // IP-Adresse in Teile aufteilen
            string[] strParts = adressStr.Split('.');
            if (strParts.Length != 4)
            {
                throw new FormatException("Ungültiges IP-Adressformat.");
            }

            int[] adressIp = new int[4];
            for (int i = 0; i < 4; i++)
            {
                if (!int.TryParse(strParts[i], out adressIp[i]) || adressIp[i] < 0 || adressIp[i] > 255)
                {
                    throw new FormatException($"Ungültiger IP-Adressenteil: {strParts[i]}");
                }
            }

            // Subnetzmaske berechnen
            int remainingBits = cidrIp % 8;
            int fullOctets = cidrIp / 8;
            int[] SubnetzMaske = new int[4] {0,0,0,0 };

            for (int i = 0;i < fullOctets;i++ ) {
            SubnetzMaske[i] = 255;
            }
            for (int i = 0; i < 4; i++)
            {
                if (SubnetzMaske[i] != 255 && SubnetzMaske[i] == 0)
                {
                    switch (remainingBits)
                    {
                        case 0:
                            SubnetzMaske[i] = 0;
                            break;
                        case 1:
                            SubnetzMaske[i] = 128;
                            break;
                        case 2:
                            SubnetzMaske[i] = 192;
                            break;
                        case 3:
                            SubnetzMaske[i] = 224;
                            break;
                        case 4:
                            SubnetzMaske[i] = 240;
                            break;
                        case 5:
                            SubnetzMaske[i] = 248;
                            break;
                        case 6:
                            SubnetzMaske[i] = 252;
                            break;
                        case 7:
                            SubnetzMaske[i] = 254;
                            break;

                    }
                    break;
                }
            }


                return SubnetzMaske;
        }


        // Hilsmethode zum Schreiben einer Zeile in Listbox
        private void WriteString(string bezeichnung, string decOctet = "",string binOctet = "")
        {
            string zeile = bezeichnung.PadLeft(18)+" "+decOctet.PadRight(18)+binOctet;

            listBox1.Items.Add(zeile);



        }
    }
}
