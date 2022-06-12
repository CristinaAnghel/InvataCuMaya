
namespace ProiectInfoEducatie
{
    partial class MainForm
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
            this.inregistrare = new System.Windows.Forms.Button();
            this.autentificare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // inregistrare
            // 
            this.inregistrare.BackColor = System.Drawing.Color.Transparent;
            this.inregistrare.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inregistrare.ForeColor = System.Drawing.Color.SteelBlue;
            this.inregistrare.Location = new System.Drawing.Point(378, 387);
            this.inregistrare.Name = "inregistrare";
            this.inregistrare.Size = new System.Drawing.Size(239, 92);
            this.inregistrare.TabIndex = 4;
            this.inregistrare.Text = "Creează-ți cont!";
            this.inregistrare.UseVisualStyleBackColor = false;
            this.inregistrare.Click += new System.EventHandler(this.cont_nou);
            // 
            // autentificare
            // 
            this.autentificare.BackColor = System.Drawing.Color.Transparent;
            this.autentificare.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autentificare.ForeColor = System.Drawing.Color.SteelBlue;
            this.autentificare.Location = new System.Drawing.Point(103, 387);
            this.autentificare.Name = "autentificare";
            this.autentificare.Size = new System.Drawing.Size(239, 92);
            this.autentificare.TabIndex = 3;
            this.autentificare.Text = "Intră în cont!";
            this.autentificare.UseVisualStyleBackColor = false;
            this.autentificare.Click += new System.EventHandler(this.autentificareCont);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(79, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume";
            // 
            // nume
            // 
            this.nume.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume.ForeColor = System.Drawing.Color.SteelBlue;
            this.nume.Location = new System.Drawing.Point(237, 197);
            this.nume.Multiline = true;
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(300, 40);
            this.nume.TabIndex = 1;
            // 
            // parola
            // 
            this.parola.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parola.ForeColor = System.Drawing.Color.SteelBlue;
            this.parola.Location = new System.Drawing.Point(237, 277);
            this.parola.Multiline = true;
            this.parola.Name = "parola";
            this.parola.PasswordChar = '*';
            this.parola.Size = new System.Drawing.Size(300, 40);
            this.parola.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(79, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parolă";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ProiectInfoEducatie.Properties.Resources.mayab_roz;
            this.pictureBox1.Location = new System.Drawing.Point(866, 332);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 431);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(316, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(489, 83);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bine ai revenit!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(12, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 79);
            this.button1.TabIndex = 8;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buton_ajutor);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::ProiectInfoEducatie.Properties.Resources.bubble;
            this.pictureBox2.Location = new System.Drawing.Point(623, 315);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 303);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectInfoEducatie.Properties.Resources.pixil_frame_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 720);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autentificare);
            this.Controls.Add(this.inregistrare);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÎnvațăCuMaya";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inregistrare;
        private System.Windows.Forms.Button autentificare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

