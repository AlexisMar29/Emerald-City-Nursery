using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1
{
    public partial class Form1 : Form
    {
        Image[] pics = new Image[6];
        decimal[] prices = new decimal[6];

        decimal[] cart = new decimal[10];
        int cartCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstShrubs.Items.Add("English Holly");
            lstShrubs.Items.Add("Boxwood");
            lstShrubs.Items.Add("Concord Barberry");
            lstShrubs.Items.Add("Golden Globe Arborvitae");
            lstShrubs.Items.Add("Mountain Laurel");
            lstShrubs.Items.Add("Pink Crush Aster");

            pics[0] = Image.FromFile("englishHolly.jpg");
            pics[1] = Image.FromFile("Boxwood.jpg");
            pics[2] = Image.FromFile("concordeBarberry.jpg");
            pics[3] = Image.FromFile("goldenGlobeArborvitae.jpg");
            pics[4] = Image.FromFile("mountainLaurel.jpg");
            pics[5] = Image.FromFile("pinkCrushAster.jpg");

            prices[0] = 44.95M;
            prices[1] = 49.95M;
            prices[2] = 39.95M;
            prices[3] = 29.95M;
            prices[4] = 49.95M;
            prices[5] = 29.95M;


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for shopping at Emerald City", "Emerald City Nursery");
            this.Close();
        }

        private void lstShrubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            picshrubs.Image = pics[lstShrubs.SelectedIndex];
            lblshrubs.Text = lstShrubs.SelectedItem.ToString();
            lblprice.Text = prices[lstShrubs.SelectedIndex].ToString("C");
        }

        private void btncart_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add(lstShrubs.SelectedItem + " - " + prices[lstShrubs.SelectedIndex].ToString("C"));

            cart[cartCount++] = prices[lstShrubs.SelectedIndex];
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            decimal total = 0;

            for (int i = 0; i < cartCount; i++)
                total += cart[i];
            
            Bitmap banner = new Bitmap(Image.FromFile("banner.png"));
            Font bigFont = new Font("Times New Roman", 24);
            Font smallFont = new Font("Times New Roman", 12);

            e.Graphics.DrawImage(banner, 0, 0, 850, 250);
            e.Graphics.DrawString("Emerald City Nursery - Packing Slip", bigFont, Brushes.Green, 100, 300);

            int x = 100, y = 300;

            x = 100;

            y = 350;

            for (int i = 0; i < lstCart.Items.Count; i++)
            {
                e.Graphics.DrawString(lstCart.Items[i].ToString(), smallFont, Brushes.Green, x, y);
                y += 20;
            }

            y += 50;

            e.Graphics.DrawString("Your total: " + total.ToString("C"), smallFont, Brushes.Green, x, y);

            y += 20;
            e.Graphics.DrawString("Thank you for shopping at Emerald City!", smallFont, Brushes.Green, x, y);

        }
    }
}
