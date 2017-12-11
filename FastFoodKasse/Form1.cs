using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MaterialSkin;
using MaterialSkin.Controls;

namespace FastFoodKasse
{
    public partial class FastFoodKasse : MaterialForm
    {
        private List<Artikel> articleList;
        private int bestCounter = 0;

        //Public Var Summe
        public float sum;

        //Intialisierung der Methoden
        public FastFoodKasse()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            articleList = new List<Artikel>();
            bestCounter = getLastBestID();
            Console.WriteLine($"bestellungscounter set to {bestCounter}");
            generateButtonsFromSQL();

        }


        // Methode zum Hinzufügen von Artikeln zu einem Objekt "Artikel" zur zwischenspeicherung der Daten und späteren Benutzung durch die Buttons
        private void AddArtikel(string n, float p, string c)
        {
            var temp = new Artikel(n, p, c);
            list_items.Items.Add(temp);
            articleList.Add(temp);

            sum += p;
            lbl_sum.Text = sum.ToString();
        }



        // Methode zum generieren von buttons. Es werden einige Werte mitgegeben: Zwischenabstände, Offset, Namen Array, Preis Array (Arrays werden durchgeloopt und ausgelesen)
        private void generateButtons(int yOffset, int xOffset, string[] names, float[] prices,string[] category, int height, int width, int xMargin = 0, int yMargin = 0)
        {
            int xCount = 0;
            int yCount = 0;
            for (int i = 0; i < names.Length; i++)
            {
                ArticleButton btn = new ArticleButton()
                {
                    Name = "btn_" + names[i],
                    //Berechnung der Position der Buttons mit gegebenem Versatz und Zwischenabständen
                    Top = yOffset + yCount * height + yMargin * yCount,
                    Left = xOffset + xCount * width + xMargin * xCount,
                    // Attribute aus der Datenbank
                    Text = names[i],
                    Price = prices[i],
                    Category = category[i],
                    ArticleName = names[i],
                    Height = height,
                    Width = width,
                };
                // Den Buttons Funktionen zuweisen
                btn.Click += (s, e) => AddArtikel(btn.ArticleName, btn.Price, btn.Category);
                this.Controls.Add(btn);

                //Beschränkung der Spaltenanzahl auf 5
                if (++xCount == 5)
                {
                    xCount = 0;
                    yCount++;
                }
            }

        }

        // Methode um die Letzte Bestellungs ID aus der Datenbank zu bekommen um nicht die gleichen Bestellungs IDs mehrfach zu benutzen
        private int getLastBestID()
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;uid=itt35;pwd=itt35;database=kasse"))
            {
                using (var command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "Select order_ID FROM history ORDER BY order_ID Desc";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                            return int.Parse(reader.GetString(0)) + 1;
                        else
                            return 0;
                    }
                }
            }
        }

        //Generieren der Buttons mit Hilfe der Datenbank und der Methode "GenerateButtons"
        private void generateButtonsFromSQL()
        {
            List<string> names = new List<string>();
            List<float> prices = new List<float>();
            List<string> category = new List<string>();

            

            //Hier wird eine neue Datenbankverbindung aufgebaut
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;uid=itt35;pwd=itt35;database=kasse"))
            {
                using (var command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "Select item_name,item_price,item_category FROM items";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            names.Add(reader.GetString(0));
                            prices.Add(float.Parse(reader.GetString(1)));
                            category.Add(reader.GetString(2));
                        }
                    }
                }
            }

            generateButtons(
                yOffset :80,
                xOffset: 20,
                names: names.ToArray(),
                prices: prices.ToArray(),
                category: category.ToArray(),
                height: 110,
                width: 110,
                xMargin: 5,
                yMargin: 5
                );
            
        }

        // Methode zur speicherung aktuell beendeter Bestellungen in der Datenbank Tabelle "History" wenn abgeschlossen
        private void finishOrder()
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;uid=itt35;pwd=itt35;database=kasse"))
            {
                using (var command = connection.CreateCommand())
                {
                    connection.Open();
                    foreach (var a in articleList)
                    {
                        double vat = a.Price * 0.19;
                        Console.WriteLine(a.Name);
                        command.CommandText = $"INSERT INTO `history`(`order_ID`, `itemname`, `price`,  `vat_tax`) VALUES ({bestCounter}, '{a.Name}', {a.Price.ToString().Replace(',', '.')}, {vat.ToString().Replace(',','.')})";
                        command.ExecuteNonQuery();
                    }
                    bestCounter++;
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FastFoodKasse_Load(object sender, EventArgs e)
        {

        }

        private void btn_rm_all_Click(object sender, EventArgs e)
        {
            articleList.Clear();
            list_items.Items.Clear();
            sum = 0;
            lbl_sum.Text = sum.ToString();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            finishOrder();
            articleList.Clear();
            list_items.Items.Clear();
        }

        private void btn_rm_selected_Click(object sender, EventArgs e)
        {
            // Schleife um alle selektierten Elemente in der List Box zu löschen (Multiselect)
            while (list_items.SelectedItems.Count > 0)
            {
                list_items.Items.Remove(list_items.SelectedItems[0]);
                sum -= (float)list_items.SelectedItems[0];
                lbl_sum.Text = sum.ToString();
            }
        }

        // Rechner Buttons
        private void calc_btn_0_Click(object sender, EventArgs e)
        {
            calc_txt.Text += "0";
        }
        private void calc_btn_1_Click(object sender, EventArgs e)
        {
            calc_txt.Text += "1";
        }
        private void calc_btn_2_Click(object sender, EventArgs e)
        {
            calc_txt.Text += "2";
        }
        private void calc_btn_3_Click(object sender, EventArgs e)
        {
            calc_txt.Text += "3";
        }
        private void calc_btn_4_Click(object sender, EventArgs e)
        {
            calc_txt.Text += "4";
        }
        private void calc_btn_5_Click(object sender, EventArgs e)
        {
            calc_txt.Text += "5";
        }
        private void calc_btn_6_Click(object sender, EventArgs e)
        {
            calc_txt.Text += "6";
        }
        private void calc_btn_7_Click(object sender, EventArgs e)
        {
            calc_txt.Text += "7";
        }
        private void calc_btn_8_Click(object sender, EventArgs e)
        {
            calc_txt.Text += "8";
        }
        private void calc_btn_9_Click(object sender, EventArgs e)
        {
            calc_txt.Text += "9";
        }
        private void calc_del_Click(object sender, EventArgs e)
        {
            calc_txt.Text = "";
        }
        private void calc_btn_dot_Click(object sender, EventArgs e)
        {
            calc_txt.Text += ".";
        }

        private void btn_costumer_pays_Click(object sender, EventArgs e)
        {
            lbl_customerpays.Text = calc_txt.Text + " €";
            float cashback = (float.Parse(calc_txt.Text)) - sum;
            lbl_cashback.Text = cashback.ToString() + " €";
        }
    }
    // Klasse zur Zwischenspeicherung der Daten in Buttons und zur Benutzung in der Anwendung mit Anschließendem speichern in der History Tabelle
    class ArticleButton : MaterialRaisedButton
    {
        public string ArticleName;
        public float Price;
        public string Category;
    }

    // Klasse Artikel zum speichern der Artikel
    class Artikel
    {
        public string Name;
        public float Price;
        public string Category;

        public Artikel(string n, float p, string c)
        {
            Name = n;
            Price = p;
            Category = c;
        }

        // Überschreibt die ToString Methode um Preis (Floats) richtig darzustellen
        public override string ToString()
        {
            return Name + " : " + Math.Round(Price, 2) + "€ cat:" + Category;
        }
    }
}
