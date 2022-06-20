namespace WinFormsApp5
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.salchikids = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salchikids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp5.Properties.Resources.descarga__1_;
            this.pictureBox1.Location = new System.Drawing.Point(22, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // salchikids
            // 
            this.salchikids.Image = global::WinFormsApp5.Properties.Resources.Salchi_kids;
            this.salchikids.Location = new System.Drawing.Point(468, 49);
            this.salchikids.Name = "salchikids";
            this.salchikids.Size = new System.Drawing.Size(340, 228);
            this.salchikids.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salchikids.TabIndex = 1;
            this.salchikids.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinFormsApp5.Properties.Resources.salchipapa;
            this.pictureBox3.Location = new System.Drawing.Point(230, 388);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(350, 218);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salchipapa combinada";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 63);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sañchi kids";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 612);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 63);
            this.button3.TabIndex = 5;
            this.button3.Text = "Salchipapa clasica";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(833, 699);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.salchikids);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salchikids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox salchikids;
        private PictureBox pictureBox3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}