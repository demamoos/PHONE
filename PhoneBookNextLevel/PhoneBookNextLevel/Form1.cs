using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookNextLevel
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Номертелефона_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                panel1.Enabled = true;
                App.PhoneBook.AddPhoneBookRow(App.PhoneBook.NewPhoneBookRow());
                phoneBookBindingSource.MoveLast();
                PhoneNumberText.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.PhoneBook.RejectChanges();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNumberText_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void ChangeButt_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            PhoneNumberText.Focus(); 
        }
        public static bool gg = false;

        private void Savebtn_Click(object sender, EventArgs e)
        {
            
            if ((PhoneNumberText.Text == "") || (NameText.Text == "") || (SurnameText.Text == ""))
            {
                MessageBox.Show("Ошибка исходных данных.\n" + "Необходимо ввести данные в оба поля");
            }
            else 
            {
                            
                            try
                            {
                                phoneBookBindingSource.EndEdit();
                                App.PhoneBook.AcceptChanges();
                                App.PhoneBook.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));

                                panel1.Enabled = false;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                App.PhoneBook.RejectChanges();
                            }
                        }
                        
         
        }
        static AppData db;
        protected static AppData App
        {
            get
            {
                if (db == null)
                    db = new AppData();
                return db;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = string.Format("{0}//data.dat", Application.StartupPath);
            if (File.Exists(fileName))
                App.PhoneBook.ReadXml(fileName);
            phoneBookBindingSource.DataSource = App.PhoneBook;
            panel1.Enabled = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
 

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить данный контакт?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    phoneBookBindingSource.RemoveCurrent();
            }
        }

        private void SearchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!string.IsNullOrEmpty(SearchTxt.Text))

                {
                    var query = from o in App.PhoneBook
                                where (o.НомерТелефона == SearchTxt.Text || o.Имя.Contains(SearchTxt.Text) || o.Фамилия.Contains(SearchTxt.Text) || o.Категория == SearchTxt.Text)
                                select o;
                    dataGridView1.DataSource = query.ToList();
                }
                else
                    dataGridView1.DataSource = phoneBookBindingSource;
            }
        }

        private void PhoneNumberText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }
    }
}
