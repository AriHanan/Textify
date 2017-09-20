namespace TextifyApp
{
    partial class Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generator));
            this.originalabc = new System.Windows.Forms.TextBox();
            this.modifiedabc = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // originalabc
            // 
            this.originalabc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.originalabc.Location = new System.Drawing.Point(12, 12);
            this.originalabc.Name = "originalabc";
            this.originalabc.Size = new System.Drawing.Size(243, 20);
            this.originalabc.TabIndex = 0;
            this.originalabc.TextChanged += new System.EventHandler(this.Trygeneratingplz);
            // 
            // modifiedabc
            // 
            this.modifiedabc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modifiedabc.Location = new System.Drawing.Point(12, 38);
            this.modifiedabc.Name = "modifiedabc";
            this.modifiedabc.Size = new System.Drawing.Size(243, 20);
            this.modifiedabc.TabIndex = 1;
            this.modifiedabc.TextChanged += new System.EventHandler(this.Trygeneratingplz);
            // 
            // code
            // 
            this.code.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.code.Location = new System.Drawing.Point(12, 64);
            this.code.Multiline = true;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.code.Size = new System.Drawing.Size(243, 337);
            this.code.TabIndex = 2;
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 413);
            this.Controls.Add(this.code);
            this.Controls.Add(this.modifiedabc);
            this.Controls.Add(this.originalabc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(136, 135);
            this.Name = "Generator";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originalabc;
        private System.Windows.Forms.TextBox modifiedabc;
        private System.Windows.Forms.TextBox code;
    }
}