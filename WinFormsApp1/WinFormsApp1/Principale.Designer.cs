namespace WinFormsApp1
{
    partial class Principale
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDe = new System.Windows.Forms.Button();
            this.pctDe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctDe)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(860, 394);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnDe
            // 
            this.btnDe.Location = new System.Drawing.Point(9, 495);
            this.btnDe.Name = "btnDe";
            this.btnDe.Size = new System.Drawing.Size(132, 64);
            this.btnDe.TabIndex = 1;
            this.btnDe.Text = "Lancez le dé";
            this.btnDe.UseVisualStyleBackColor = true;
            this.btnDe.Click += new System.EventHandler(this.btnDe_Click);
            // 
            // pctDe
            // 
            this.pctDe.Image = global::WinFormsApp1.Properties.Resources.DeN1;
            this.pctDe.Location = new System.Drawing.Point(147, 458);
            this.pctDe.Name = "pctDe";
            this.pctDe.Size = new System.Drawing.Size(101, 101);
            this.pctDe.TabIndex = 2;
            this.pctDe.TabStop = false;
            // 
            // Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 571);
            this.Controls.Add(this.pctDe);
            this.Controls.Add(this.btnDe);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Principale";
            this.Text = "JeuPrincipale";
            ((System.ComponentModel.ISupportInitialize)(this.pctDe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDe;
        private PictureBox pctDe;
    }
}