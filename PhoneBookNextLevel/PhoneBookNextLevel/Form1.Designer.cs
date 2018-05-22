namespace PhoneBookNextLevel
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Номертелефона = new System.Windows.Forms.Label();
            this.Имя = new System.Windows.Forms.Label();
            this.Фамилия = new System.Windows.Forms.Label();
            this.PhoneNumberText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.SurnameText = new System.Windows.Forms.TextBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.ChangeButt = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Категория = new System.Windows.Forms.Label();
            this.CategoryName = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new PhoneBookNextLevel.AppData();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CategoryName);
            this.panel1.Controls.Add(this.Категория);
            this.panel1.Controls.Add(this.SurnameText);
            this.panel1.Controls.Add(this.NameText);
            this.panel1.Controls.Add(this.PhoneNumberText);
            this.panel1.Controls.Add(this.Фамилия);
            this.panel1.Controls.Add(this.Имя);
            this.panel1.Controls.Add(this.Номертелефона);
            this.panel1.Location = new System.Drawing.Point(99, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 186);
            this.panel1.TabIndex = 1;
            // 
            // Номертелефона
            // 
            this.Номертелефона.AutoSize = true;
            this.Номертелефона.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Номертелефона.Location = new System.Drawing.Point(12, 11);
            this.Номертелефона.Name = "Номертелефона";
            this.Номертелефона.Size = new System.Drawing.Size(183, 25);
            this.Номертелефона.TabIndex = 5;
            this.Номертелефона.Text = "Номер телефона";
            this.Номертелефона.Click += new System.EventHandler(this.Номертелефона_Click);
            // 
            // Имя
            // 
            this.Имя.AutoSize = true;
            this.Имя.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Имя.Location = new System.Drawing.Point(12, 48);
            this.Имя.Name = "Имя";
            this.Имя.Size = new System.Drawing.Size(53, 25);
            this.Имя.TabIndex = 15;
            this.Имя.Text = "Имя";
            // 
            // Фамилия
            // 
            this.Фамилия.AutoSize = true;
            this.Фамилия.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Фамилия.Location = new System.Drawing.Point(12, 96);
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.Size = new System.Drawing.Size(104, 25);
            this.Фамилия.TabIndex = 16;
            this.Фамилия.Text = "Фамилия";
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "НомерТелефона", true));
            this.PhoneNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberText.Location = new System.Drawing.Point(214, 8);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(194, 31);
            this.PhoneNumberText.TabIndex = 0;
            this.PhoneNumberText.TextChanged += new System.EventHandler(this.PhoneNumberText_TextChanged);
            this.PhoneNumberText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberText_KeyPress);
            // 
            // NameText
            // 
            this.NameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "Имя", true));
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(214, 60);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(194, 31);
            this.NameText.TabIndex = 1;
            // 
            // SurnameText
            // 
            this.SurnameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "Фамилия", true));
            this.SurnameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameText.Location = new System.Drawing.Point(214, 108);
            this.SurnameText.Name = "SurnameText";
            this.SurnameText.Size = new System.Drawing.Size(194, 31);
            this.SurnameText.TabIndex = 2;
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Location = new System.Drawing.Point(590, 12);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(211, 34);
            this.NewButton.TabIndex = 4;
            this.NewButton.Text = "Новый контакт";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeButt
            // 
            this.ChangeButt.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButt.Location = new System.Drawing.Point(590, 70);
            this.ChangeButt.Name = "ChangeButt";
            this.ChangeButt.Size = new System.Drawing.Size(211, 33);
            this.ChangeButt.TabIndex = 5;
            this.ChangeButt.Text = "Изменить контакт";
            this.ChangeButt.UseVisualStyleBackColor = true;
            this.ChangeButt.Click += new System.EventHandler(this.ChangeButt_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Savebtn.Location = new System.Drawing.Point(590, 121);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(211, 31);
            this.Savebtn.TabIndex = 6;
            this.Savebtn.Text = "Сохранить контакт";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Категория
            // 
            this.Категория.AutoSize = true;
            this.Категория.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Категория.Location = new System.Drawing.Point(12, 151);
            this.Категория.Name = "Категория";
            this.Категория.Size = new System.Drawing.Size(115, 25);
            this.Категория.TabIndex = 23;
            this.Категория.Text = "Категория";
            // 
            // CategoryName
            // 
            this.CategoryName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "Категория", true));
            this.CategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryName.FormattingEnabled = true;
            this.CategoryName.Items.AddRange(new object[] {
            "Домашний",
            "Мобильный"});
            this.CategoryName.Location = new System.Drawing.Point(214, 148);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(194, 33);
            this.CategoryName.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phoneBookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(63, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 199);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Поиск";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTxt.Location = new System.Drawing.Point(247, 225);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(430, 31);
            this.SearchTxt.TabIndex = 1;
            this.SearchTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.SearchTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTxt_KeyPress);
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "НомерТелефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "НомерТелефона";
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            this.номерТелефонаDataGridViewTextBoxColumn.Width = 150;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 150;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 250;
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.Width = 200;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneBookBindingSource
            // 
            this.phoneBookBindingSource.DataMember = "PhoneBook";
            this.phoneBookBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 532);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ChangeButt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NewButton);
            this.Name = "Form1";
            this.Text = "Phone Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Номертелефона;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.TextBox SurnameText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox PhoneNumberText;
        private System.Windows.Forms.Label Фамилия;
        private System.Windows.Forms.Label Имя;
        private System.Windows.Forms.ComboBox CategoryName;
        private System.Windows.Forms.Label Категория;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button ChangeButt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.BindingSource phoneBookBindingSource;
        private AppData appData;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}

