using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа_11_20
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<Lanch> lanches = new List<Lanch>();
        List<Dish> dishes = new List<Dish>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.ReadOnly = true;
            }

        }
        int count = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= Convert.ToInt32(textBox1.Text))
            {
                Lanch lanch = new Lanch();
                lanch.Id = count;
                lanch.Name = textBox2.Text;
                lanch.Price = Convert.ToDouble(textBox3.Text);
                lanches.Add(lanch);
                textBox2.Text = "";
                textBox3.Text = "";
                listBox1.Items.Add(lanch.Name + " " + lanch.Price);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.ReadOnly = true;
            }
        }

        int count1 = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            count1++;
            if (count1 <= Convert.ToInt32(textBox4.Text))
            {
                Dish dish = new Dish();
                dish.Id = count1;
                dish.Name = textBox5.Text;
                dish.Price = Convert.ToDouble(textBox6.Text);
                dish.Ccal = Convert.ToDouble(textBox7.Text);
                dishes.Add(dish);
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                listBox2.Items.Add(dish.Name + " " + dish.Price + " " + dish.Ccal);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double min = double.MaxValue;
            foreach (var m in lanches)
            {
                if (min > m.Price)
                {
                    min = m.Price;
                }
            }
            textBox8.Text = Convert.ToString(min);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lanches.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dishes.RemoveAt(listBox2.SelectedIndex);
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool b = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (textBox9.Text == lanches[i].Name)
                {
                    b = true;
                    MessageBox.Show($"{lanches[i].Price}");
                }
            }
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (textBox9.Text == dishes[i].Name)
                {
                    b = true;
                    MessageBox.Show($"{dishes[i].Price} {dishes[i].Ccal}");
                }
            }
            if(b == false)
            {
                MessageBox.Show("Неверный индекс");
            }
        }

    }
}

