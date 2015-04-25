using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Save_Name_In_Array_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string name;
        
        string [] nameArray=new string[5];
        
        List<string > list=new List<string>(); 
        private void nameAddButton_Click(object sender, EventArgs e)
        {



            name=nameTextBox.Text;
           
            int totalname = list.Count;

            if (totalname < 5)
            {
                list.Add(name);
                nameArray = list.ToArray();

                nameTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("U can't add name more than five");
            }

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            //nameListBox.DataSource = list;

            foreach (string s in nameArray)
            {
                nameListBox.Items.Add(s);
            }
            totalNameTextBox.Text = nameListBox.Items.Count.ToString();

        }
    }
}
