namespace ProiectInfoEducatie
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conturiDataSet = new ProiectInfoEducatie.ConturiDataSet();
            this.accountsTableAdapter = new ProiectInfoEducatie.ConturiDataSetTableAdapters.AccountsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.inv_aud = new System.Windows.Forms.PictureBox();
            this.g_mat = new System.Windows.Forms.PictureBox();
            this.m_viz = new System.Windows.Forms.PictureBox();
            this.inv_vizuala = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conturiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_aud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_mat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_viz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_vizuala)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(996, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "Înapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.back);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.accountsBindingSource;
            this.comboBox1.DisplayMember = "Nume";
            this.comboBox1.Font = new System.Drawing.Font("Kristen ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(61, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 59);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.change);
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.conturiDataSet;
            // 
            // conturiDataSet
            // 
            this.conturiDataSet.DataSetName = "ConturiDataSet";
            this.conturiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(63, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 54);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alege contul!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Scor Joc2:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 45);
            this.label4.TabIndex = 4;
            this.label4.Text = "Scor Joc3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 45);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 45);
            this.label6.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(292, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 45);
            this.label7.TabIndex = 4;
            this.label7.Text = "000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(292, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 45);
            this.label8.TabIndex = 4;
            this.label8.Text = "000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(292, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 45);
            this.label9.TabIndex = 4;
            this.label9.Text = "000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label10.Location = new System.Drawing.Point(582, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(313, 45);
            this.label10.TabIndex = 6;
            this.label10.Text = "Mod de invatare:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scor Joc1:";
            this.label1.Click += new System.EventHandler(this.label3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LavenderBlush;
            this.label11.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label11.Location = new System.Drawing.Point(592, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(267, 39);
            this.label11.TabIndex = 7;
            this.label11.Text = "Invatare auditiva";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LavenderBlush;
            this.label12.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label12.Location = new System.Drawing.Point(592, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(249, 39);
            this.label12.TabIndex = 7;
            this.label12.Text = "Invatare vizuala";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LavenderBlush;
            this.label13.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label13.Location = new System.Drawing.Point(592, 451);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(311, 39);
            this.label13.TabIndex = 7;
            this.label13.Text = "Gandire matematica";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.LavenderBlush;
            this.label16.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label16.Location = new System.Drawing.Point(592, 568);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(256, 39);
            this.label16.TabIndex = 7;
            this.label16.Text = "Memorie vizuala";
            // 
            // inv_aud
            // 
            this.inv_aud.BackColor = System.Drawing.Color.Transparent;
            this.inv_aud.Location = new System.Drawing.Point(884, 224);
            this.inv_aud.Name = "inv_aud";
            this.inv_aud.Size = new System.Drawing.Size(55, 55);
            this.inv_aud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inv_aud.TabIndex = 8;
            this.inv_aud.TabStop = false;
            // 
            // g_mat
            // 
            this.g_mat.BackColor = System.Drawing.Color.Transparent;
            this.g_mat.Location = new System.Drawing.Point(947, 435);
            this.g_mat.Name = "g_mat";
            this.g_mat.Size = new System.Drawing.Size(55, 55);
            this.g_mat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.g_mat.TabIndex = 8;
            this.g_mat.TabStop = false;
            // 
            // m_viz
            // 
            this.m_viz.BackColor = System.Drawing.Color.Transparent;
            this.m_viz.Location = new System.Drawing.Point(884, 552);
            this.m_viz.Name = "m_viz";
            this.m_viz.Size = new System.Drawing.Size(55, 55);
            this.m_viz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_viz.TabIndex = 8;
            this.m_viz.TabStop = false;
            // 
            // inv_vizuala
            // 
            this.inv_vizuala.BackColor = System.Drawing.Color.Transparent;
            this.inv_vizuala.Location = new System.Drawing.Point(884, 326);
            this.inv_vizuala.Name = "inv_vizuala";
            this.inv_vizuala.Size = new System.Drawing.Size(55, 55);
            this.inv_vizuala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inv_vizuala.TabIndex = 8;
            this.inv_vizuala.TabStop = false;
            this.inv_vizuala.Click += new System.EventHandler(this.inv_vizuala_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(350, 606);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 45);
            this.label14.TabIndex = 4;
            this.label14.Text = "000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(59, 606);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(260, 45);
            this.label15.TabIndex = 4;
            this.label15.Text = "Nr.  ascultari:";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 720);
            this.Controls.Add(this.m_viz);
            this.Controls.Add(this.inv_vizuala);
            this.Controls.Add(this.g_mat);
            this.Controls.Add(this.inv_aud);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conturiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_aud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_mat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_viz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_vizuala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private ConturiDataSet conturiDataSet;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private ConturiDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox inv_aud;
        private System.Windows.Forms.PictureBox g_mat;
        private System.Windows.Forms.PictureBox m_viz;
        private System.Windows.Forms.PictureBox inv_vizuala;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}