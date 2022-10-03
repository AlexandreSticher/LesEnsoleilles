namespace WinFormsApp1
{
    partial class Joueurs
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
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblAide = new System.Windows.Forms.Label();
            this.lsbNbjoueurs = new System.Windows.Forms.GroupBox();
            this.rdbJoueurs4 = new System.Windows.Forms.RadioButton();
            this.rdbJoueurs3 = new System.Windows.Forms.RadioButton();
            this.rdbJoueurs2 = new System.Windows.Forms.RadioButton();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblJoueur1 = new System.Windows.Forms.Label();
            this.lblJoueur4 = new System.Windows.Forms.Label();
            this.lblJoueur3 = new System.Windows.Forms.Label();
            this.lblJoueur2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.lsbNbjoueurs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(12, 9);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(49, 15);
            this.lblOptions.TabIndex = 0;
            this.lblOptions.Text = "Options";
            // 
            // lblAide
            // 
            this.lblAide.AutoSize = true;
            this.lblAide.Location = new System.Drawing.Point(67, 9);
            this.lblAide.Name = "lblAide";
            this.lblAide.Size = new System.Drawing.Size(31, 15);
            this.lblAide.TabIndex = 1;
            this.lblAide.Text = "Aide";
            // 
            // lsbNbjoueurs
            // 
            this.lsbNbjoueurs.Controls.Add(this.rdbJoueurs4);
            this.lsbNbjoueurs.Controls.Add(this.rdbJoueurs3);
            this.lsbNbjoueurs.Controls.Add(this.rdbJoueurs2);
            this.lsbNbjoueurs.Location = new System.Drawing.Point(39, 45);
            this.lsbNbjoueurs.Name = "lsbNbjoueurs";
            this.lsbNbjoueurs.Size = new System.Drawing.Size(223, 100);
            this.lsbNbjoueurs.TabIndex = 2;
            this.lsbNbjoueurs.TabStop = false;
            this.lsbNbjoueurs.Text = "Nombres de joueurs";
            // 
            // rdbJoueurs4
            // 
            this.rdbJoueurs4.AutoSize = true;
            this.rdbJoueurs4.Location = new System.Drawing.Point(100, 72);
            this.rdbJoueurs4.Name = "rdbJoueurs4";
            this.rdbJoueurs4.Size = new System.Drawing.Size(74, 19);
            this.rdbJoueurs4.TabIndex = 2;
            this.rdbJoueurs4.TabStop = true;
            this.rdbJoueurs4.Text = "4 Joueurs";
            this.rdbJoueurs4.UseVisualStyleBackColor = true;
            // 
            // rdbJoueurs3
            // 
            this.rdbJoueurs3.AutoSize = true;
            this.rdbJoueurs3.Location = new System.Drawing.Point(100, 47);
            this.rdbJoueurs3.Name = "rdbJoueurs3";
            this.rdbJoueurs3.Size = new System.Drawing.Size(74, 19);
            this.rdbJoueurs3.TabIndex = 1;
            this.rdbJoueurs3.TabStop = true;
            this.rdbJoueurs3.Text = "3 Joueurs";
            this.rdbJoueurs3.UseVisualStyleBackColor = true;
            // 
            // rdbJoueurs2
            // 
            this.rdbJoueurs2.AutoSize = true;
            this.rdbJoueurs2.Location = new System.Drawing.Point(100, 22);
            this.rdbJoueurs2.Name = "rdbJoueurs2";
            this.rdbJoueurs2.Size = new System.Drawing.Size(73, 19);
            this.rdbJoueurs2.TabIndex = 0;
            this.rdbJoueurs2.TabStop = true;
            this.rdbJoueurs2.Text = "2 joueurs";
            this.rdbJoueurs2.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(67, 355);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(112, 43);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(608, 355);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 43);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(552, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(552, 195);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 23);
            this.textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(552, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 23);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(552, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 23);
            this.textBox2.TabIndex = 8;
            // 
            // lblJoueur1
            // 
            this.lblJoueur1.AutoSize = true;
            this.lblJoueur1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJoueur1.Location = new System.Drawing.Point(453, 49);
            this.lblJoueur1.Name = "lblJoueur1";
            this.lblJoueur1.Size = new System.Drawing.Size(62, 19);
            this.lblJoueur1.TabIndex = 9;
            this.lblJoueur1.Text = "Joueur 1";
            // 
            // lblJoueur4
            // 
            this.lblJoueur4.AutoSize = true;
            this.lblJoueur4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJoueur4.Location = new System.Drawing.Point(453, 199);
            this.lblJoueur4.Name = "lblJoueur4";
            this.lblJoueur4.Size = new System.Drawing.Size(62, 19);
            this.lblJoueur4.TabIndex = 10;
            this.lblJoueur4.Text = "Joueur 4";
            // 
            // lblJoueur3
            // 
            this.lblJoueur3.AutoSize = true;
            this.lblJoueur3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJoueur3.Location = new System.Drawing.Point(453, 147);
            this.lblJoueur3.Name = "lblJoueur3";
            this.lblJoueur3.Size = new System.Drawing.Size(62, 19);
            this.lblJoueur3.TabIndex = 11;
            this.lblJoueur3.Text = "Joueur 3";
            // 
            // lblJoueur2
            // 
            this.lblJoueur2.AutoSize = true;
            this.lblJoueur2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJoueur2.Location = new System.Drawing.Point(453, 96);
            this.lblJoueur2.Name = "lblJoueur2";
            this.lblJoueur2.Size = new System.Drawing.Size(62, 19);
            this.lblJoueur2.TabIndex = 12;
            this.lblJoueur2.Text = "Joueur 2";
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.ForeColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(682, 45);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(28, 23);
            this.btnRed.TabIndex = 13;
            this.btnRed.Text = "rouge";
            this.btnRed.UseVisualStyleBackColor = false;
            // 
            // btnPurple
            // 
            this.btnPurple.BackColor = System.Drawing.Color.Purple;
            this.btnPurple.ForeColor = System.Drawing.Color.Purple;
            this.btnPurple.Location = new System.Drawing.Point(682, 195);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(28, 24);
            this.btnPurple.TabIndex = 14;
            this.btnPurple.Text = "Purple";
            this.btnPurple.UseVisualStyleBackColor = false;
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.LawnGreen;
            this.btnGreen.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnGreen.Location = new System.Drawing.Point(682, 143);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(28, 25);
            this.btnGreen.TabIndex = 15;
            this.btnGreen.Text = "vert";
            this.btnGreen.UseVisualStyleBackColor = false;
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.ForeColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(682, 92);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(28, 25);
            this.btnBlue.TabIndex = 16;
            this.btnBlue.Text = "bleu";
            this.btnBlue.UseVisualStyleBackColor = false;
            // 
            // Joueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnPurple);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.lblJoueur2);
            this.Controls.Add(this.lblJoueur3);
            this.Controls.Add(this.lblJoueur4);
            this.Controls.Add(this.lblJoueur1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lsbNbjoueurs);
            this.Controls.Add(this.lblAide);
            this.Controls.Add(this.lblOptions);
            this.Name = "Joueurs";
            this.Text = "Enregistrement des joueurs";
            this.Load += new System.EventHandler(this.Joueurs_Load);
            this.lsbNbjoueurs.ResumeLayout(false);
            this.lsbNbjoueurs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblOptions;
        private Label lblAide;
        private GroupBox lsbNbjoueurs;
        private RadioButton rdbJoueurs4;
        private RadioButton rdbJoueurs3;
        private RadioButton rdbJoueurs2;
        private Button btnQuitter;
        private Button btnStart;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label lblJoueur1;
        private Label lblJoueur4;
        private Label lblJoueur3;
        private Label lblJoueur2;
        private ColorDialog colorDialog1;
        private Button btnRed;
        private Button btnPurple;
        private Button btnGreen;
        private Button btnBlue;
    }
}