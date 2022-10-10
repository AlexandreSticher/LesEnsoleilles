namespace WinFormsApp1
{
    partial class Question1
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbResponse1 = new System.Windows.Forms.RadioButton();
            this.rdbResponse2 = new System.Windows.Forms.RadioButton();
            this.rdbResponse3 = new System.Windows.Forms.RadioButton();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pictureBoxQuestion = new System.Windows.Forms.PictureBox();
            this.lblReponse = new System.Windows.Forms.Label();
            this.btnQuestion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "vous devez répondre";
            // 
            // rdbResponse1
            // 
            this.rdbResponse1.AutoSize = true;
            this.rdbResponse1.Location = new System.Drawing.Point(422, 141);
            this.rdbResponse1.Name = "rdbResponse1";
            this.rdbResponse1.Size = new System.Drawing.Size(14, 13);
            this.rdbResponse1.TabIndex = 1;
            this.rdbResponse1.TabStop = true;
            this.rdbResponse1.Tag = "1";
            this.rdbResponse1.UseVisualStyleBackColor = true;
            // 
            // rdbResponse2
            // 
            this.rdbResponse2.AutoSize = true;
            this.rdbResponse2.Location = new System.Drawing.Point(422, 179);
            this.rdbResponse2.Name = "rdbResponse2";
            this.rdbResponse2.Size = new System.Drawing.Size(14, 13);
            this.rdbResponse2.TabIndex = 2;
            this.rdbResponse2.TabStop = true;
            this.rdbResponse2.Tag = "2";
            this.rdbResponse2.UseVisualStyleBackColor = true;
            // 
            // rdbResponse3
            // 
            this.rdbResponse3.AutoSize = true;
            this.rdbResponse3.Location = new System.Drawing.Point(422, 216);
            this.rdbResponse3.Name = "rdbResponse3";
            this.rdbResponse3.Size = new System.Drawing.Size(14, 13);
            this.rdbResponse3.TabIndex = 3;
            this.rdbResponse3.TabStop = true;
            this.rdbResponse3.Tag = "3";
            this.rdbResponse3.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(361, 340);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(361, 77);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(38, 15);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "label2";
            // 
            // pictureBoxQuestion
            // 
            this.pictureBoxQuestion.Image = global::WinFormsApp1.Properties.Resources.fromage;
            this.pictureBoxQuestion.Location = new System.Drawing.Point(12, 42);
            this.pictureBoxQuestion.Name = "pictureBoxQuestion";
            this.pictureBoxQuestion.Size = new System.Drawing.Size(328, 336);
            this.pictureBoxQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQuestion.TabIndex = 6;
            this.pictureBoxQuestion.TabStop = false;
            // 
            // lblReponse
            // 
            this.lblReponse.AutoSize = true;
            this.lblReponse.Location = new System.Drawing.Point(361, 366);
            this.lblReponse.Name = "lblReponse";
            this.lblReponse.Size = new System.Drawing.Size(0, 15);
            this.lblReponse.TabIndex = 7;
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(442, 340);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnQuestion.TabIndex = 8;
            this.btnQuestion.Text = "Question";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // Question1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.lblReponse);
            this.Controls.Add(this.pictureBoxQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.rdbResponse3);
            this.Controls.Add(this.rdbResponse2);
            this.Controls.Add(this.rdbResponse1);
            this.Controls.Add(this.label1);
            this.Name = "Question1";
            this.Text = "Question";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton rdbResponse1;
        private RadioButton rdbResponse2;
        private RadioButton rdbResponse3;
        private Button btnValider;
        private Label lblQuestion;
        private PictureBox pictureBoxQuestion;
        private Label lblReponse;
        private Button btnQuestion;
    }
}