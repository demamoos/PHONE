using Electronic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        Choice GetModelFromUI()
        {
            return new Choice
            {
                Name = textBox1.Text,
                Number = textBox3.Text,
            
           
        

           
                
            };
         }
        private void SetModelToUI(Choice dto)
        {
            textBox1.Text = dto.Name;
            
            textBox3.Text = dto.Number;
            
            
          


        }



         private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var o = new OpenFileDialog() { Filter = "|*.txt" };
            var result = o.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = ElectronicHelper.LoadFromFile(o.FileName);
                SetModelToUI(dto);
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var s = new SaveFileDialog() { Filter = "|*.txt" };
            var result = s.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = GetModelFromUI();
               
                ElectronicHelper.WriteToFile(s.FileName, dto);
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

       


     

       
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void Очистить_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox3.Text = " ";
        }
    }
}
