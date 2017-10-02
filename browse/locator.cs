using Locatronics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browse
{
    public partial class locator : Form
    {
        public locator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            find();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            find();
        }

        private void find()
        {
            // find
            organizer o = new organizer();

            string component = textBox1.Text;
            List<baskets> search = o.search(component);

            string addresses = "";

            foreach (var a in search)
            {
                string name;
                if (a.contents.Length >= 20)
                {
                    name = a.contents.Substring(0, 20);
                }
                else
                {
                    name = a.contents;
                }

                addresses += string.Format("{0} - {1}\r\n", a.location.address, name);
            }

            //MessageBox.Show(addresses);
            textBox2.Text = addresses;
        }
    }
}
