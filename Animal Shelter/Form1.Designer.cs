namespace Animal_Shelter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBadHabits = new System.Windows.Forms.TextBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbSpecies = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAnimalAdd = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstAnimals = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAnimalReserve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReservor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.nudFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.btnFoodAdd = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lstWebshop = new System.Windows.Forms.ListBox();
            this.btnAnimalInWebshop = new System.Windows.Forms.Button();
            this.btnWebshopRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodPrice)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBadHabits
            // 
            this.txtBadHabits.Enabled = false;
            this.txtBadHabits.Location = new System.Drawing.Point(6, 19);
            this.txtBadHabits.Name = "txtBadHabits";
            this.txtBadHabits.Size = new System.Drawing.Size(109, 20);
            this.txtBadHabits.TabIndex = 5;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Location = new System.Drawing.Point(6, 19);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 3;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(60, 19);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 4;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(109, 20);
            this.txtName.TabIndex = 2;
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.cmbSpecies.Location = new System.Drawing.Point(6, 19);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(109, 21);
            this.cmbSpecies.TabIndex = 1;
            this.cmbSpecies.SelectedIndexChanged += new System.EventHandler(this.cmbSpecies_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMale);
            this.groupBox1.Controls.Add(this.radFemale);
            this.groupBox1.Location = new System.Drawing.Point(10, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 47);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(10, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 47);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBadHabits);
            this.groupBox3.Location = new System.Drawing.Point(10, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 47);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bad habits";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbSpecies);
            this.groupBox4.Location = new System.Drawing.Point(10, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(121, 47);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Species";
            // 
            // btnAnimalAdd
            // 
            this.btnAnimalAdd.Location = new System.Drawing.Point(12, 224);
            this.btnAnimalAdd.Name = "btnAnimalAdd";
            this.btnAnimalAdd.Size = new System.Drawing.Size(119, 23);
            this.btnAnimalAdd.TabIndex = 6;
            this.btnAnimalAdd.Text = "Add animal";
            this.btnAnimalAdd.UseVisualStyleBackColor = true;
            this.btnAnimalAdd.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstAnimals);
            this.groupBox5.Location = new System.Drawing.Point(137, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(416, 100);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Animals";
            // 
            // lstAnimals
            // 
            this.lstAnimals.FormattingEnabled = true;
            this.lstAnimals.Location = new System.Drawing.Point(9, 19);
            this.lstAnimals.Name = "lstAnimals";
            this.lstAnimals.Size = new System.Drawing.Size(400, 69);
            this.lstAnimals.TabIndex = 0;
            this.lstAnimals.SelectedIndexChanged += new System.EventHandler(this.lstAnimals_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAnimalInWebshop);
            this.groupBox6.Controls.Add(this.btnAnimalReserve);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.txtReservor);
            this.groupBox6.Location = new System.Drawing.Point(137, 118);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(416, 47);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Reserve animal";
            // 
            // btnAnimalReserve
            // 
            this.btnAnimalReserve.Enabled = false;
            this.btnAnimalReserve.Location = new System.Drawing.Point(165, 16);
            this.btnAnimalReserve.Name = "btnAnimalReserve";
            this.btnAnimalReserve.Size = new System.Drawing.Size(119, 23);
            this.btnAnimalReserve.TabIndex = 4;
            this.btnAnimalReserve.Text = "Reserve selected";
            this.btnAnimalReserve.UseVisualStyleBackColor = true;
            this.btnAnimalReserve.Click += new System.EventHandler(this.btnReserveAnimal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // txtReservor
            // 
            this.txtReservor.Location = new System.Drawing.Point(50, 18);
            this.txtReservor.Name = "txtReservor";
            this.txtReservor.Size = new System.Drawing.Size(109, 20);
            this.txtReservor.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 1);
            this.panel1.TabIndex = 15;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.nudFoodPrice);
            this.groupBox7.Controls.Add(this.txtFoodName);
            this.groupBox7.Location = new System.Drawing.Point(12, 260);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(119, 72);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Food";
            // 
            // nudFoodPrice
            // 
            this.nudFoodPrice.DecimalPlaces = 2;
            this.nudFoodPrice.Location = new System.Drawing.Point(4, 45);
            this.nudFoodPrice.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudFoodPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFoodPrice.Name = "nudFoodPrice";
            this.nudFoodPrice.Size = new System.Drawing.Size(109, 20);
            this.nudFoodPrice.TabIndex = 17;
            this.nudFoodPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(4, 19);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(109, 20);
            this.txtFoodName.TabIndex = 3;
            // 
            // btnFoodAdd
            // 
            this.btnFoodAdd.Location = new System.Drawing.Point(12, 338);
            this.btnFoodAdd.Name = "btnFoodAdd";
            this.btnFoodAdd.Size = new System.Drawing.Size(121, 23);
            this.btnFoodAdd.TabIndex = 17;
            this.btnFoodAdd.Text = "Add food";
            this.btnFoodAdd.UseVisualStyleBackColor = true;
            this.btnFoodAdd.Click += new System.EventHandler(this.btnFoodAdd_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lstWebshop);
            this.groupBox8.Location = new System.Drawing.Point(139, 260);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(414, 100);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Webshop";
            // 
            // lstWebshop
            // 
            this.lstWebshop.FormattingEnabled = true;
            this.lstWebshop.Location = new System.Drawing.Point(9, 19);
            this.lstWebshop.Name = "lstWebshop";
            this.lstWebshop.Size = new System.Drawing.Size(398, 69);
            this.lstWebshop.TabIndex = 0;
            this.lstWebshop.SelectedIndexChanged += new System.EventHandler(this.lstWebshop_SelectedIndexChanged);
            // 
            // btnAnimalInWebshop
            // 
            this.btnAnimalInWebshop.Enabled = false;
            this.btnAnimalInWebshop.Location = new System.Drawing.Point(290, 16);
            this.btnAnimalInWebshop.Name = "btnAnimalInWebshop";
            this.btnAnimalInWebshop.Size = new System.Drawing.Size(119, 23);
            this.btnAnimalInWebshop.TabIndex = 5;
            this.btnAnimalInWebshop.Text = "Place in webshop";
            this.btnAnimalInWebshop.UseVisualStyleBackColor = true;
            this.btnAnimalInWebshop.Click += new System.EventHandler(this.btnAnimalInWebshop_Click);
            // 
            // btnWebshopRemove
            // 
            this.btnWebshopRemove.Enabled = false;
            this.btnWebshopRemove.Location = new System.Drawing.Point(148, 366);
            this.btnWebshopRemove.Name = "btnWebshopRemove";
            this.btnWebshopRemove.Size = new System.Drawing.Size(119, 23);
            this.btnWebshopRemove.TabIndex = 6;
            this.btnWebshopRemove.Text = "Remove selected";
            this.btnWebshopRemove.UseVisualStyleBackColor = true;
            this.btnWebshopRemove.Click += new System.EventHandler(this.btnWebshopRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 398);
            this.Controls.Add(this.btnWebshopRemove);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.btnFoodAdd);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnAnimalAdd);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodPrice)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBadHabits;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAnimalAdd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAnimalReserve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReservor;
        private System.Windows.Forms.ListBox lstAnimals;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown nudFoodPrice;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Button btnFoodAdd;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ListBox lstWebshop;
        private System.Windows.Forms.Button btnAnimalInWebshop;
        private System.Windows.Forms.Button btnWebshopRemove;
    }
}

