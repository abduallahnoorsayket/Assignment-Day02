using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayketwindowsForm2
{
    public partial class From03 : Form
    {
        public From03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox.Text  += "\n\n\tCustomer Name :" + nameTextBox.Text + "\n\n";
            richTextBox.Text += "\tContact No :" + contactNoTextBox.Text + "\n\n";
            richTextBox.Text += "\tAddress :" + addressTextBox.Text + "\n\n";
            if (orderComboBox.Text== "Black-120")
            {
                int price =Convert.ToInt32(quantityTextBox.Text);
                price = price * 120;

                richTextBox.Text += "\tOrder:Black\n\n";
              richTextBox.Text += "\tTotal Price :" + price+ "\n\n";
                richTextBox.Text += "\tPrice per Unit :" + 120 + "\n\n";
            }

            else if (orderComboBox.Text == "Cold-100")
                {


                int price = Convert.ToInt32(quantityTextBox.Text);
                price = price * 100;

                richTextBox.Text += "\tOrder: Cold \n\n";
                richTextBox.Text += "\tTotal Price :" + price + "\n\n";
                richTextBox.Text += "\tPrice per Unit :" + 100 + "\n\n";

            }

            else if (orderComboBox.Text == "Hot-90")
            {


                int price = Convert.ToInt32(quantityTextBox.Text);
                price = price * 90;
                richTextBox.Text += "\tOrder: Hot \n\n";
                richTextBox.Text += "\tTotal Price :" + price + "\n\n";
                richTextBox.Text += "\tPrice per Unit :" + 90 + "\n\n";

            }


            else if (orderComboBox.Text == "Regular-80")
            {


                int price = Convert.ToInt32(quantityTextBox.Text);
                price = price * 80;
                richTextBox.Text += "\tOrder: Regular\n\n";
                richTextBox.Text += "\tTotal Price :" + price + "\n\n";
                richTextBox.Text += "\tPrice per Unit :" + 80 + "\n\n";

            }

            else
            {
                richTextBox.Text += "\tPlease Select Item ";
            }


            richTextBox.Text += "\tQuantity :" + quantityTextBox.Text + "\n\n";
            
        }

       
    }
}
