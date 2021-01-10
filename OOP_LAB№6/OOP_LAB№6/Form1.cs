using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_LAB_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Reader();
        }

        public void AddProduct(string str)
        {

            _store.AddProduct(str);

            string[] items;
            items = str.Split();

            _comBxCost.Add(Convert.ToInt32(items[2]));

            comboBoxCost.Items.Clear();

            switch (items[0])
            {
                case "Greens":
                    _comBxWeight.Add(Convert.ToDouble(items[3]));
                    _comBxKkal.Add(Convert.ToInt32(items[4]));
                    break;

                case "Clothes":
                    _comBxSize.Add(Convert.ToChar(items[3]));
                    _comBxMaterial.Add(items[4]);
                    break;

                case "Laptop":
                    _comBxRAM.Add(Convert.ToInt32(items[4]));
                    break;
            }
            Draw();
        }

        private void Reader()
        {
            StreamReader sr = new StreamReader("data.txt");

            string str;
            while ((str = sr.ReadLine()) != null)
            {
                AddProduct(str);
            }
        }

        private void addElementButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form2 form2 = new Form2(this);

            form2.Show();
        }

        private void Draw(HashSet<int> ids)
        {
            listBoxProducts.Items.Clear();

            string[] items = new string[6];


            foreach (var i in ids)
            {
                items = _store.GetInfoByID(i);

                listBoxProducts.Items.Add(Convert.ToString(i) + ": " + items[1]);
            }
        }

        private void Draw()
        {
            listBoxProducts.Items.Clear();

            List<int> ids = _store.GetAllIDs();
            string[] items = new string[6];

            
            for (int i = 0; i < ids.Count(); i++)
            {
                items = _store.GetInfoByID(ids[i]);

                listBoxProducts.Items.Add(Convert.ToString(ids[i]) + ": " + items[1]);
            }

            comboBoxCost.Items.Clear();
            comboBoxKkal.Items.Clear();
            comboBoxMaterial.Items.Clear();
            comboBoxRAM.Items.Clear();
            comboBoxSize.Items.Clear();
            comboBoxWeight.Items.Clear();

            foreach (var i in _comBxCost.Reverse())
            {
                comboBoxCost.Items.Add(i);
            }

            foreach (var i in _comBxKkal.Reverse())
            {
                comboBoxKkal.Items.Add(i);
            }

            foreach (var i in _comBxWeight.Reverse())
            {
                comboBoxWeight.Items.Add(i);
            }

            foreach (var i in _comBxSize.Reverse())
            {
                comboBoxSize.Items.Add(i);
            }

            foreach (var i in _comBxMaterial.Reverse())
            {
                comboBoxMaterial.Items.Add(i);
            }

            foreach (var i in _comBxRAM.Reverse())
            {
                comboBoxRAM.Items.Add(i);
            }
        }

        private Store _store = new Store();

        private SortedSet<int> _comBxCost = new SortedSet<int>();
        private SortedSet<int> _comBxKkal = new SortedSet<int>();
        private SortedSet<double> _comBxWeight = new SortedSet<double>();
        private SortedSet<char> _comBxSize = new SortedSet<char>();
        private SortedSet<string> _comBxMaterial = new SortedSet<string>();
        private SortedSet<int> _comBxRAM = new SortedSet<int>();

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex != -1)
            {
                buttonDelete.Enabled = true;

                string id = (Convert.ToString(listBoxProducts.SelectedItem).Split())[0];
                id = id.Remove(id.Length - 1);

                string[] items = _store.GetInfoByID(Convert.ToInt32(id));

                switch (items.Last())
                {
                    case "Greens":
                        richTextBox1.Text = " Type: " + items[4] + "\n Cost: " + items[0]
                          + "\n Weight: " + items[3] + "\n Kkal: " + items[2];
                        break;

                    case "Laptop":
                        richTextBox1.Text = " Type: " + items[5] + "\n Cost: " + items[0]
                          + "\n Processor ID: " + items[2] + "\n RAM: " + items[3] + "\n HDD: " + items[4];
                        break;


                    case "Clothes":
                        richTextBox1.Text = " Type: " + items[4] + "\n Cost: " + items[0]
                          + "\n Size: " + items[2] + "\n Material: " + items[3];
                        break;
                }
            }

            else
            {
                richTextBox1.Text = "";
                buttonDelete.Enabled = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex != -1)
            {
                string id = (Convert.ToString(listBoxProducts.SelectedItem).Split())[0];
                id = id.Remove(id.Length - 1);

                string[] items = _store.GetInfoByID(Convert.ToInt32(id));

                _comBxCost.Remove(Convert.ToInt32(items[0]));

                switch (items.Last())
                {
                    case "Greens":
                        _comBxKkal.Remove(Convert.ToInt32(items[2]));
                        _comBxWeight.Remove(Convert.ToDouble(items[3]));
                        break;

                    case "Clothes":
                        _comBxSize.Remove(Convert.ToChar(items[2]));
                        _comBxMaterial.Remove(items[3]);
                        break;

                    case "Laptop":
                        _comBxRAM.Remove(Convert.ToInt32(items[3]));
                        break;
                }


                _store.DeleteProduct(Convert.ToInt32(id));
                Draw();
            }

            richTextBox1.Text = "";
        }

        private void comboBoxCost_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKkal.Text = "KKAL";
            comboBoxMaterial.Text = "MATERIAL";
            comboBoxSize.Text = "SIZE";
            comboBoxWeight.Text = "WEIGHT";
            comboBoxRAM.Text = "RAM";

            Draw(_store.FindCost(Convert.ToInt32(comboBoxCost.Text)));
        }

        private void comboBoxKkal_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMaterial.Text = "MATERIAL";
            comboBoxCost.Text = "COST";
            comboBoxSize.Text = "SIZE";
            comboBoxWeight.Text = "WEIGHT";
            comboBoxRAM.Text = "RAM";

            Draw(_store.FindKkal(Convert.ToInt32(comboBoxKkal.Text)));
        }

        private void comboBoxWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKkal.Text = "KKAL";
            comboBoxMaterial.Text = "MATERIAL";
            comboBoxCost.Text = "COST";
            comboBoxSize.Text = "SIZE";
            comboBoxRAM.Text = "RAM";

            Draw(_store.FindWeight(Convert.ToDouble(comboBoxWeight.Text)));
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKkal.Text = "KKAL";
            comboBoxMaterial.Text = "MATERIAL";
            comboBoxCost.Text = "COST";
            comboBoxWeight.Text = "WEIGHT";
            comboBoxRAM.Text = "RAM";

            Draw(_store.FindSize(Convert.ToChar(comboBoxSize.Text)));
        }

        private void comboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKkal.Text = "KKAL";
            comboBoxCost.Text = "COST";
            comboBoxSize.Text = "SIZE";
            comboBoxWeight.Text = "WEIGHT";
            comboBoxRAM.Text = "RAM";

            Draw(_store.FindMaterial(comboBoxMaterial.Text));
        }

        private void comboBoxRAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKkal.Text = "KKAL";
            comboBoxMaterial.Text = "MATERIAL";
            comboBoxCost.Text = "COST";
            comboBoxSize.Text = "SIZE";
            comboBoxWeight.Text = "WEIGHT";

            Draw(_store.FindRAM(Convert.ToInt32(comboBoxRAM.Text)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxKkal.Text = "KKAL";
            comboBoxMaterial.Text = "MATERIAL";
            comboBoxCost.Text = "COST";
            comboBoxSize.Text = "SIZE";
            comboBoxWeight.Text = "WEIGHT";
            comboBoxRAM.Text = "RAM";

            Draw();
        }
    }
}