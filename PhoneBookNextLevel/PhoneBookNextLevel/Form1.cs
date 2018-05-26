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
    public struct Phone
    {
        public string Name;
        public string Number;
    }
    public partial class Form1 : Form
    {
        List<Phone> newPhone = new List<Phone>();
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
            int count = 0;
            for (int i = 0; i < PhoneNumberText.Text.Length; ++i)
            {
                if (char.IsLetter(PhoneNumberText.Text[i]))
                {
                    count++;
                }
            }
            if ((PhoneNumberText.Text == "") || (NameText.Text == "") || (SurnameText.Text == ""))
            {
                MessageBox.Show("Ошибка исходных данных.\n" + "Необходимо ввести данные в оба поля");
            }
            else if (count == 0)
            {
                if (gg == true)
                {
                    string textik = File.ReadAllText("{0}//data.dat");
                    if (textik.Contains(NameText.Text) || textik.Contains(PhoneNumberText.Text) || (textik.Contains(SurnameText.Text)))
                    {
                        MessageBox.Show("Контакт уже существует!");
                    }
                    else
                    {
                        int x1 = search(NameText.Text);

                        if (x1 == -1)
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
        int search(string s)
        {
            for (int i = 0; i < newPhone.Count; i++)
            {
                if (newPhone[i].Name.Equals(s))
                {
                    return i;
                }
            }
            return -1;
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
                                where o.НомерТелефона == SearchTxt.Text || o.Имя.Contains(SearchTxt.Text) || o.Фамилия.Contains(SearchTxt.Text) || o.Категория == SearchTxt.Text
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
