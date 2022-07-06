using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabClass4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            item item1 = new item();
            item1.number = Convert.ToInt32(txt_Number.Text);
            item1.date = txt_Date.Text;
            item1.inventoryNumber = Convert.ToInt32(txt_InventoryNumber.Text);
            item1.itemName = txt_ItemName.Text;
            item1.quantity = Convert.ToInt32(txt_Quantity.Text);
            item1.price = Convert.ToDouble(txt_Price.Text);

            item1.Save(item1);
            MessageBox.Show($"Item Has been Added! \n Item number: {item1.number}\n Item date: {item1.date}\n Inventory number: {item1.inventoryNumber}\n Item name: {item1.itemName}\n Quantity: {item1.quantity}\n Price: {item1.price} ");
           
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
