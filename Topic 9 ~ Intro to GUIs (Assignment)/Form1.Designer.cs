namespace Topic_9___Intro_to_GUIs__Assignment_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblinstructions = new System.Windows.Forms.TextBox();
            this.btnGood = new System.Windows.Forms.Button();
            this.btnBad = new System.Windows.Forms.Button();
            this.imgedsheeran = new System.Windows.Forms.PictureBox();
            this.imgdoggy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgedsheeran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgdoggy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblinstructions
            // 
            this.lblinstructions.BackColor = System.Drawing.Color.Black;
            this.lblinstructions.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinstructions.ForeColor = System.Drawing.Color.MistyRose;
            this.lblinstructions.Location = new System.Drawing.Point(139, 40);
            this.lblinstructions.Multiline = true;
            this.lblinstructions.Name = "lblinstructions";
            this.lblinstructions.Size = new System.Drawing.Size(543, 77);
            this.lblinstructions.TabIndex = 5;
            this.lblinstructions.Text = "Click on one of the following options to get a image!";
            this.lblinstructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblinstructions.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnGood
            // 
            this.btnGood.BackColor = System.Drawing.Color.Maroon;
            this.btnGood.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGood.Location = new System.Drawing.Point(180, 319);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(129, 37);
            this.btnGood.TabIndex = 6;
            this.btnGood.Text = "Good";
            this.btnGood.UseVisualStyleBackColor = false;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnBad
            // 
            this.btnBad.BackColor = System.Drawing.Color.Maroon;
            this.btnBad.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBad.Location = new System.Drawing.Point(492, 270);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(172, 86);
            this.btnBad.TabIndex = 7;
            this.btnBad.Text = "Bad";
            this.btnBad.UseVisualStyleBackColor = false;
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // imgedsheeran
            // 
            this.imgedsheeran.Image = ((System.Drawing.Image)(resources.GetObject("imgedsheeran.Image")));
            this.imgedsheeran.Location = new System.Drawing.Point(319, 132);
            this.imgedsheeran.Name = "imgedsheeran";
            this.imgedsheeran.Size = new System.Drawing.Size(163, 181);
            this.imgedsheeran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgedsheeran.TabIndex = 8;
            this.imgedsheeran.TabStop = false;
            this.imgedsheeran.Visible = false;
            this.imgedsheeran.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imgdoggy
            // 
            this.imgdoggy.Image = ((System.Drawing.Image)(resources.GetObject("imgdoggy.Image")));
            this.imgdoggy.Location = new System.Drawing.Point(315, 132);
            this.imgdoggy.Name = "imgdoggy";
            this.imgdoggy.Size = new System.Drawing.Size(171, 233);
            this.imgdoggy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgdoggy.TabIndex = 9;
            this.imgdoggy.TabStop = false;
            this.imgdoggy.Visible = false;
            this.imgdoggy.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgdoggy);
            this.Controls.Add(this.imgedsheeran);
            this.Controls.Add(this.btnBad);
            this.Controls.Add(this.btnGood);
            this.Controls.Add(this.lblinstructions);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.imgedsheeran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgdoggy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lblinstructions;
        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnBad;
        private System.Windows.Forms.PictureBox imgedsheeran;
        private System.Windows.Forms.PictureBox imgdoggy;
    }
}

