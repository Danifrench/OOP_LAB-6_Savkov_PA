using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_LAB_6
{
    public partial class Form2 : Form
    {
        public Form2(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxType.SelectedItem)
            {
                case "Greens":
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBoxWeightSize.Enabled = true;
                    textBoxWeightSize.Text = "WEIGHT";
                    textBoxKkalMaterial.Enabled = true;
                    textBoxKkalMaterial.Text = "KKAL";
                    textBoxRAM.Enabled = false;
                    textBoxRAM.Text = "";
                    break;

                case "Clothes":
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBoxWeightSize.Enabled = true;
                    textBoxWeightSize.Text = "SIZE";
                    textBoxKkalMaterial.Enabled = true;
                    textBoxKkalMaterial.Text = "MATERIAL";
                    textBoxRAM.Enabled = false;
                    textBoxRAM.Text = "";
                    break;

                case "Laptop":
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBoxWeightSize.Enabled = true;
                    textBoxWeightSize.Text = "PROCESSOR ID";
                    textBoxKkalMaterial.Enabled = true;
                    textBoxKkalMaterial.Text = "RAM";
                    textBoxRAM.Enabled = true;
                    textBoxRAM.Text = "HDD";
                    break;
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            bool flag = false;

            try
            {
                if (Convert.ToInt32(textBox1.Text) != null)
                {
                    switch (comboBoxType.SelectedItem)
                    {
                        case "Greens":
                            if (Convert.ToInt32(textBoxKkalMaterial.Text) != null &&
                                Convert.ToDouble(textBoxWeightSize.Text) != null)
                            {
                                string str = "Greens " + textBox2.Text + " " + textBox1.Text + " " + textBoxWeightSize.Text +
                                    " " + textBoxKkalMaterial.Text;
                                _form1.AddProduct(str);
                            }

                            break;

                        case "Clothes":
                            if (Convert.ToChar(textBoxWeightSize.Text) != null)
                            {
                                string str = "Clothes " + textBox2.Text + " " + textBox1.Text +
                                    " " + textBoxWeightSize.Text + " " + textBoxKkalMaterial.Text;
                                _form1.AddProduct(str);
                            }

                            break;

                        case "Laptop":
                            if (Convert.ToInt32(textBoxKkalMaterial.Text) != null &&
                                Convert.ToInt32(textBoxRAM.Text) != null)
                            {
                                string str = "Laptop " + textBox2.Text + " " + textBox1.Text + " " + textBoxWeightSize.Text +
                                    " " + textBoxKkalMaterial.Text + " " + textBoxRAM.Text;
                                _form1.AddProduct(str);
                            }
                            break;
                    }
                }
            }

            catch(FormatException)
            {
                MessageBox.Show("ERROR : WRONG ITEMS");
            }

            _form1.Enabled = true;
            this.Close();
        }

        private Form1 _form1;

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBoxWeightSize_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxWeightSize.Text = "";
        }

        private void textBoxKkalMaterial_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxKkalMaterial.Text = "";
        }

        private void textBoxRAM_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxRAM.Text = "";
        }
    }
}
