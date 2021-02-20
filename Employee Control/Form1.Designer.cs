
namespace Employee_Control
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_text = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_surname = new System.Windows.Forms.Label();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.comboBox_working = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Addnew = new System.Windows.Forms.Button();
            this.label_Search = new System.Windows.Forms.Label();
            this.dataGridView_employee = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_text.Location = new System.Drawing.Point(33, 33);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(55, 20);
            this.label_text.TabIndex = 0;
            this.label_text.Text = "Name:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Name.Location = new System.Drawing.Point(94, 33);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(121, 20);
            this.textBox_Name.TabIndex = 1;
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_surname.Location = new System.Drawing.Point(10, 61);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(78, 20);
            this.label_surname.TabIndex = 2;
            this.label_surname.Text = "Surname:";
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Surname.Location = new System.Drawing.Point(94, 61);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(121, 20);
            this.textBox_Surname.TabIndex = 3;
            // 
            // comboBox_working
            // 
            this.comboBox_working.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_working.FormattingEnabled = true;
            this.comboBox_working.Items.AddRange(new object[] {
            "None",
            "Yes",
            "No"});
            this.comboBox_working.Location = new System.Drawing.Point(94, 87);
            this.comboBox_working.Name = "comboBox_working";
            this.comboBox_working.Size = new System.Drawing.Size(121, 21);
            this.comboBox_working.TabIndex = 4;
            this.comboBox_working.SelectedIndexChanged += new System.EventHandler(this.comboBox_working_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Is Working:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Search);
            this.groupBox1.Controls.Add(this.label_text);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Controls.Add(this.comboBox_working);
            this.groupBox1.Controls.Add(this.label_surname);
            this.groupBox1.Controls.Add(this.textBox_Surname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 181);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter By";
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Search.Location = new System.Drawing.Point(14, 133);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 6;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            // 
            // button_Addnew
            // 
            this.button_Addnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Addnew.Location = new System.Drawing.Point(26, 236);
            this.button_Addnew.Name = "button_Addnew";
            this.button_Addnew.Size = new System.Drawing.Size(75, 23);
            this.button_Addnew.TabIndex = 7;
            this.button_Addnew.Text = "Add New";
            this.button_Addnew.UseVisualStyleBackColor = true;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Search.Location = new System.Drawing.Point(112, 239);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(115, 16);
            this.label_Search.TabIndex = 8;
            this.label_Search.Text = "Waiting for search";
            // 
            // dataGridView_employee
            // 
            this.dataGridView_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employee.Location = new System.Drawing.Point(346, 12);
            this.dataGridView_employee.Name = "dataGridView_employee";
            this.dataGridView_employee.Size = new System.Drawing.Size(677, 399);
            this.dataGridView_employee.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.dataGridView_employee);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.button_Addnew);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.ComboBox comboBox_working;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Addnew;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.DataGridView dataGridView_employee;
    }
}

