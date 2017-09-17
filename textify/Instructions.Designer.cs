namespace Textify
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.how_t = new System.Windows.Forms.Label();
            this.how = new System.Windows.Forms.Label();
            this.what = new System.Windows.Forms.Label();
            this.what_t = new System.Windows.Forms.Label();
            this.sauce_t = new System.Windows.Forms.Label();
            this.Sauce = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Credit = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // how_t
            // 
            this.how_t.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.how_t.AutoSize = true;
            this.how_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.how_t.Location = new System.Drawing.Point(27, 243);
            this.how_t.Name = "how_t";
            this.how_t.Size = new System.Drawing.Size(180, 30);
            this.how_t.TabIndex = 0;
            this.how_t.Text = "HOW TO USE";
            // 
            // how
            // 
            this.how.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.how.Location = new System.Drawing.Point(12, 270);
            this.how.Name = "how";
            this.how.Size = new System.Drawing.Size(211, 106);
            this.how.TabIndex = 2;
            this.how.Text = "1. Type the text you wish to convert in the text box at the top\r\n2. Click on the " +
    "desired typeface\r\n3. Go to your text application\r\n4. Right click\r\n5. Paste\r\n6. S" +
    "panish inquasition\r\n7. Profit";
            // 
            // what
            // 
            this.what.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.what.Location = new System.Drawing.Point(12, 138);
            this.what.Name = "what";
            this.what.Size = new System.Drawing.Size(211, 81);
            this.what.TabIndex = 4;
            this.what.Text = resources.GetString("what.Text");
            // 
            // what_t
            // 
            this.what_t.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.what_t.AutoSize = true;
            this.what_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.what_t.Location = new System.Drawing.Point(25, 111);
            this.what_t.Name = "what_t";
            this.what_t.Size = new System.Drawing.Size(185, 30);
            this.what_t.TabIndex = 3;
            this.what_t.Text = "WHAT IS THIS";
            // 
            // sauce_t
            // 
            this.sauce_t.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sauce_t.AutoSize = true;
            this.sauce_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sauce_t.Location = new System.Drawing.Point(14, 402);
            this.sauce_t.Name = "sauce_t";
            this.sauce_t.Size = new System.Drawing.Size(206, 30);
            this.sauce_t.TabIndex = 5;
            this.sauce_t.Text = "SOURCE CODE";
            // 
            // Sauce
            // 
            this.Sauce.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sauce.AutoSize = true;
            this.Sauce.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.Sauce.Location = new System.Drawing.Point(72, 432);
            this.Sauce.Name = "Sauce";
            this.Sauce.Size = new System.Drawing.Size(90, 17);
            this.Sauce.TabIndex = 7;
            this.Sauce.TabStop = true;
            this.Sauce.Text = "via GitHub. kthnx";
            this.Sauce.UseCompatibleTextRendering = true;
            this.Sauce.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Sauce_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Textify.Properties.Resources.DONTPANIC;
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Credit
            // 
            this.Credit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Credit.AutoSize = true;
            this.Credit.Location = new System.Drawing.Point(98, 474);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(54, 13);
            this.Credit.TabIndex = 9;
            this.Credit.TabStop = true;
            this.Credit.Text = "Ari Hanan";
            this.Credit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Credit_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "❤";
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Sauce);
            this.Controls.Add(this.sauce_t);
            this.Controls.Add(this.what);
            this.Controls.Add(this.what_t);
            this.Controls.Add(this.how);
            this.Controls.Add(this.how_t);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Instructions";
            this.ShowIcon = false;
            this.Text = "How to use";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label how_t;
        private System.Windows.Forms.Label how;
        private System.Windows.Forms.Label what;
        private System.Windows.Forms.Label what_t;
        private System.Windows.Forms.Label sauce_t;
        private System.Windows.Forms.LinkLabel Sauce;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel Credit;
        private System.Windows.Forms.Label label1;
    }
}