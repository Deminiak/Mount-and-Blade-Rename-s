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

namespace SubNameWarband
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string s1 = textBox1.Text;
                string s2 = textBox2.Text;

                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] == ' ')
                    {
                        s1 = s1.Replace(' ', '_');
                        break;
                    }
                }
                for (int i = 0; i < s2.Length; i++)
                {
                    if (s2[i] == ' ')
                    {
                        s2 = s2.Replace(' ', '_');
                        break;
                    }
                }

                string str = System.IO.File.ReadAllText("troops.txt", Encoding.Default);
                try
                {
                    str = str.Remove(str.IndexOf(s1), s1.Length).Insert(str.IndexOf(s1), s2);
                str = str.Remove(str.IndexOf(s1), s1.Length).Insert(str.IndexOf(s1), s2);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("troops.txt"))
                    
                        file.Write(str);
                    System.Windows.Forms.MessageBox.Show("Юнит переименован!");
                }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("Такого юнита нет!");
                    }
                }
            else
            {
                System.Windows.Forms.MessageBox.Show("Васян заполни поля!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                string[] names = { "Swadian Recruit", "Swadian Militia", "Swadian Footman", "Swadian Infantry", "Swadian Sergeant", "Swadian Skirmisher", "Swadian Crossbowman", "Swadian Sharpshooter", "Swadian Man at Arms", "Swadian Knight" };
                for(int i = 0;i<names.Length;i++)
                listBox1.Items.Add(names[i]);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                string[] names = { "Rhodok Tribesman", "Rhodok Spearman", "Rhodok Trained Spearman", "Rhodok Veteran Spearman", "Rhodok Sergeant", "Rhodok Crossbowman", "Rhodok Trained Crossbowman", "Rhodok Veteran Crossbowman", "Rhodok Sharpshooter"};
                for (int i = 0; i < names.Length; i++)
                    listBox1.Items.Add(names[i]);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();
                string[] names = { "Nord Recruit", "Nord Footman", "Nord Trained Footman", "Nord Warrior", "Nord Veteran", "Nord Huscarl", "Nord Huntsman", "Nord Archer", "Nord Veteran Archer" };
                for (int i = 0; i < names.Length; i++)
                    listBox1.Items.Add(names[i]);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Clear();
                string[] names = { "Vaegir Recruit", "Vaegir Footman", "Vaegir Skirmisher", "Vaegir Archer", "Vaegir Marksman", "Vaegir Veteran", "Vaegir Infantry", "Vaegir Guard", "Vaegir Horseman", "Vaegir Knight" };
                for (int i = 0; i < names.Length; i++)
                    listBox1.Items.Add(names[i]);
            }
            if (comboBox1.SelectedIndex == 4)
            {
                listBox1.Items.Clear();
                string[] names = { "Khergit Tribesman", "Khergit Skirmisher", "Khergit Horseman", "Khergit Horse Archer", "Khergit Veteran Horse Archer", "Khergit Lancer"};
                for (int i = 0; i < names.Length; i++)
                    listBox1.Items.Add(names[i]);
            }
            if (comboBox1.SelectedIndex == 5)
            {
                listBox1.Items.Clear();
                string[] names = { "Sarranid Recruit",  "Sarranid Footman", "Sarranid Veteran Footman", "Sarranid Infantry", "Sarranid Guard", "Sarranid Skirmisher", "Sarranid Archer", "Sarranid Master Archer", "Sarranid Horseman", "Sarranid Mamluke" };
                for (int i = 0; i < names.Length; i++)
                    listBox1.Items.Add(names[i]);
            }
            if (comboBox1.SelectedIndex == 6)
            {
                listBox1.Items.Clear();
                string[] names = { "Borcha", "Marnid", "Ymira", "Rolf", "Baheshtur", "Firentis", "Deshavi", "Matheld", "Alayen", "Bunduk", "Katrin", "Jeremus", "Nizar", "Lezalit", "Artimenner", "Klethi" };
                for (int i = 0; i < names.Length; i++)
                    listBox1.Items.Add(names[i]);
            }
            if (comboBox1.SelectedIndex == 7)
            {
                listBox1.Items.Clear();
                string[] names = { "King Harlaus", "King Yaroglek", "Sanjar Khan", "King Ragnar", "King Graveth", "Sultan Hakim" };
                for (int i = 0; i < names.Length; i++)
                    listBox1.Items.Add(names[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
