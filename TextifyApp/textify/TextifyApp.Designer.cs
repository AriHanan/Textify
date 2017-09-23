namespace TextifyApp
{
    partial class TextifyApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextifyApp));
            this.c_txt = new System.Windows.Forms.TextBox();
            this.c_fullwidth = new System.Windows.Forms.RadioButton();
            this.c_circled = new System.Windows.Forms.RadioButton();
            this.c_circledinvert = new System.Windows.Forms.RadioButton();
            this.c_serifbold = new System.Windows.Forms.RadioButton();
            this.c_frakturbold = new System.Windows.Forms.RadioButton();
            this.c_serifbolditalic = new System.Windows.Forms.RadioButton();
            this.c_scriptbold = new System.Windows.Forms.RadioButton();
            this.c_doublestruck = new System.Windows.Forms.RadioButton();
            this.c_monospace = new System.Windows.Forms.RadioButton();
            this.c_sans = new System.Windows.Forms.RadioButton();
            this.c_sansbold = new System.Windows.Forms.RadioButton();
            this.c_sansbolditalic = new System.Windows.Forms.RadioButton();
            this.c_sansitalic = new System.Windows.Forms.RadioButton();
            this.c_squared = new System.Windows.Forms.RadioButton();
            this.c_squaredinvert = new System.Windows.Forms.RadioButton();
            this.c_inverted = new System.Windows.Forms.RadioButton();
            this.c_fraktur = new System.Windows.Forms.RadioButton();
            this.c_smallcaps = new System.Windows.Forms.RadioButton();
            this.c_subscript = new System.Windows.Forms.RadioButton();
            this.c_generator = new System.Windows.Forms.Button();
            this.c_tm = new System.Windows.Forms.RadioButton();
            this.c_ae = new System.Windows.Forms.RadioButton();
            this.c_parenthesized = new System.Windows.Forms.RadioButton();
            this.c_zalgo = new System.Windows.Forms.RadioButton();
            this.c_nibba = new System.Windows.Forms.RadioButton();
            this.c_mixed = new System.Windows.Forms.RadioButton();
            this.c_numberspeak = new System.Windows.Forms.RadioButton();
            this.c_blankbanshee = new System.Windows.Forms.RadioButton();
            this.c_randomcase = new System.Windows.Forms.RadioButton();
            this.zalgo_intensity = new System.Windows.Forms.TrackBar();
            this.zalgo_group = new System.Windows.Forms.GroupBox();
            this.zalgo_buttom = new System.Windows.Forms.CheckBox();
            this.zalgo_middle = new System.Windows.Forms.CheckBox();
            this.zalgo_top = new System.Windows.Forms.CheckBox();
            this.DelayedUpdate = new System.Windows.Forms.Timer(this.components);
            this.c_serifitalic = new System.Windows.Forms.RadioButton();
            this.c_script = new System.Windows.Forms.RadioButton();
            this.c_extrathicc = new System.Windows.Forms.RadioButton();
            this.Halp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zalgo_intensity)).BeginInit();
            this.zalgo_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // c_txt
            // 
            this.c_txt.AcceptsReturn = true;
            this.c_txt.AcceptsTab = true;
            this.c_txt.AllowDrop = true;
            this.c_txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.c_txt.Location = new System.Drawing.Point(0, 0);
            this.c_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_txt.Name = "c_txt";
            this.c_txt.Size = new System.Drawing.Size(600, 27);
            this.c_txt.TabIndex = 0;
            this.c_txt.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // c_fullwidth
            // 
            this.c_fullwidth.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_fullwidth.AutoEllipsis = true;
            this.c_fullwidth.Location = new System.Drawing.Point(200, 27);
            this.c_fullwidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_fullwidth.Name = "c_fullwidth";
            this.c_fullwidth.Size = new System.Drawing.Size(200, 29);
            this.c_fullwidth.TabIndex = 14;
            this.c_fullwidth.Text = "FullWidth";
            this.c_fullwidth.UseVisualStyleBackColor = true;
            this.c_fullwidth.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_circled
            // 
            this.c_circled.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_circled.AutoEllipsis = true;
            this.c_circled.Location = new System.Drawing.Point(200, 114);
            this.c_circled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_circled.Name = "c_circled";
            this.c_circled.Size = new System.Drawing.Size(200, 29);
            this.c_circled.TabIndex = 17;
            this.c_circled.Text = "Circled";
            this.c_circled.UseVisualStyleBackColor = true;
            this.c_circled.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_circledinvert
            // 
            this.c_circledinvert.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_circledinvert.AutoEllipsis = true;
            this.c_circledinvert.Location = new System.Drawing.Point(200, 143);
            this.c_circledinvert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_circledinvert.Name = "c_circledinvert";
            this.c_circledinvert.Size = new System.Drawing.Size(200, 29);
            this.c_circledinvert.TabIndex = 18;
            this.c_circledinvert.Text = "Circled Negative";
            this.c_circledinvert.UseVisualStyleBackColor = true;
            this.c_circledinvert.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_serifbold
            // 
            this.c_serifbold.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_serifbold.AutoEllipsis = true;
            this.c_serifbold.Checked = true;
            this.c_serifbold.Location = new System.Drawing.Point(0, 27);
            this.c_serifbold.Margin = new System.Windows.Forms.Padding(0);
            this.c_serifbold.Name = "c_serifbold";
            this.c_serifbold.Size = new System.Drawing.Size(200, 29);
            this.c_serifbold.TabIndex = 2;
            this.c_serifbold.TabStop = true;
            this.c_serifbold.Text = "Serif Bold";
            this.c_serifbold.UseVisualStyleBackColor = true;
            this.c_serifbold.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_frakturbold
            // 
            this.c_frakturbold.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_frakturbold.AutoEllipsis = true;
            this.c_frakturbold.Location = new System.Drawing.Point(0, 317);
            this.c_frakturbold.Margin = new System.Windows.Forms.Padding(0);
            this.c_frakturbold.Name = "c_frakturbold";
            this.c_frakturbold.Size = new System.Drawing.Size(200, 29);
            this.c_frakturbold.TabIndex = 12;
            this.c_frakturbold.Text = "Fraktur Bold";
            this.c_frakturbold.UseVisualStyleBackColor = true;
            this.c_frakturbold.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_serifbolditalic
            // 
            this.c_serifbolditalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_serifbolditalic.AutoEllipsis = true;
            this.c_serifbolditalic.Location = new System.Drawing.Point(0, 85);
            this.c_serifbolditalic.Margin = new System.Windows.Forms.Padding(0);
            this.c_serifbolditalic.Name = "c_serifbolditalic";
            this.c_serifbolditalic.Size = new System.Drawing.Size(200, 29);
            this.c_serifbolditalic.TabIndex = 4;
            this.c_serifbolditalic.Text = "Serif Bold Italic";
            this.c_serifbolditalic.UseVisualStyleBackColor = true;
            this.c_serifbolditalic.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_scriptbold
            // 
            this.c_scriptbold.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_scriptbold.AutoEllipsis = true;
            this.c_scriptbold.Location = new System.Drawing.Point(0, 259);
            this.c_scriptbold.Margin = new System.Windows.Forms.Padding(0);
            this.c_scriptbold.Name = "c_scriptbold";
            this.c_scriptbold.Size = new System.Drawing.Size(200, 29);
            this.c_scriptbold.TabIndex = 10;
            this.c_scriptbold.Text = "Script Bold";
            this.c_scriptbold.UseVisualStyleBackColor = true;
            this.c_scriptbold.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_doublestruck
            // 
            this.c_doublestruck.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_doublestruck.AutoEllipsis = true;
            this.c_doublestruck.Location = new System.Drawing.Point(200, 56);
            this.c_doublestruck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_doublestruck.Name = "c_doublestruck";
            this.c_doublestruck.Size = new System.Drawing.Size(200, 29);
            this.c_doublestruck.TabIndex = 15;
            this.c_doublestruck.Text = "Double-Struck";
            this.c_doublestruck.UseVisualStyleBackColor = true;
            this.c_doublestruck.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_monospace
            // 
            this.c_monospace.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_monospace.AutoEllipsis = true;
            this.c_monospace.Location = new System.Drawing.Point(0, 346);
            this.c_monospace.Margin = new System.Windows.Forms.Padding(0);
            this.c_monospace.Name = "c_monospace";
            this.c_monospace.Size = new System.Drawing.Size(200, 29);
            this.c_monospace.TabIndex = 13;
            this.c_monospace.Text = "Monospace";
            this.c_monospace.UseVisualStyleBackColor = true;
            this.c_monospace.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_sans
            // 
            this.c_sans.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_sans.AutoEllipsis = true;
            this.c_sans.Location = new System.Drawing.Point(0, 114);
            this.c_sans.Margin = new System.Windows.Forms.Padding(0);
            this.c_sans.Name = "c_sans";
            this.c_sans.Size = new System.Drawing.Size(200, 29);
            this.c_sans.TabIndex = 5;
            this.c_sans.Text = "Sans";
            this.c_sans.UseVisualStyleBackColor = true;
            this.c_sans.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_sansbold
            // 
            this.c_sansbold.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_sansbold.AutoEllipsis = true;
            this.c_sansbold.Location = new System.Drawing.Point(0, 143);
            this.c_sansbold.Margin = new System.Windows.Forms.Padding(0);
            this.c_sansbold.Name = "c_sansbold";
            this.c_sansbold.Size = new System.Drawing.Size(200, 29);
            this.c_sansbold.TabIndex = 6;
            this.c_sansbold.Text = "Sans Bold";
            this.c_sansbold.UseVisualStyleBackColor = true;
            this.c_sansbold.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_sansbolditalic
            // 
            this.c_sansbolditalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_sansbolditalic.AutoEllipsis = true;
            this.c_sansbolditalic.Location = new System.Drawing.Point(0, 201);
            this.c_sansbolditalic.Margin = new System.Windows.Forms.Padding(0);
            this.c_sansbolditalic.Name = "c_sansbolditalic";
            this.c_sansbolditalic.Size = new System.Drawing.Size(200, 29);
            this.c_sansbolditalic.TabIndex = 8;
            this.c_sansbolditalic.Text = "Sans Bold Italic";
            this.c_sansbolditalic.UseVisualStyleBackColor = true;
            this.c_sansbolditalic.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_sansitalic
            // 
            this.c_sansitalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_sansitalic.AutoEllipsis = true;
            this.c_sansitalic.Location = new System.Drawing.Point(0, 172);
            this.c_sansitalic.Margin = new System.Windows.Forms.Padding(0);
            this.c_sansitalic.Name = "c_sansitalic";
            this.c_sansitalic.Size = new System.Drawing.Size(200, 29);
            this.c_sansitalic.TabIndex = 7;
            this.c_sansitalic.Text = "Sans Italic";
            this.c_sansitalic.UseVisualStyleBackColor = true;
            this.c_sansitalic.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_squared
            // 
            this.c_squared.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_squared.AutoEllipsis = true;
            this.c_squared.Location = new System.Drawing.Point(200, 172);
            this.c_squared.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_squared.Name = "c_squared";
            this.c_squared.Size = new System.Drawing.Size(200, 29);
            this.c_squared.TabIndex = 19;
            this.c_squared.Text = "Squared";
            this.c_squared.UseVisualStyleBackColor = true;
            this.c_squared.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_squaredinvert
            // 
            this.c_squaredinvert.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_squaredinvert.AutoEllipsis = true;
            this.c_squaredinvert.Location = new System.Drawing.Point(200, 201);
            this.c_squaredinvert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_squaredinvert.Name = "c_squaredinvert";
            this.c_squaredinvert.Size = new System.Drawing.Size(200, 29);
            this.c_squaredinvert.TabIndex = 20;
            this.c_squaredinvert.Text = "Squared Negative";
            this.c_squaredinvert.UseVisualStyleBackColor = true;
            this.c_squaredinvert.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_inverted
            // 
            this.c_inverted.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_inverted.AutoEllipsis = true;
            this.c_inverted.Location = new System.Drawing.Point(200, 85);
            this.c_inverted.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_inverted.Name = "c_inverted";
            this.c_inverted.Size = new System.Drawing.Size(200, 29);
            this.c_inverted.TabIndex = 16;
            this.c_inverted.Text = "Inverted";
            this.c_inverted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.c_inverted.UseVisualStyleBackColor = true;
            this.c_inverted.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_fraktur
            // 
            this.c_fraktur.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_fraktur.AutoEllipsis = true;
            this.c_fraktur.Location = new System.Drawing.Point(0, 288);
            this.c_fraktur.Margin = new System.Windows.Forms.Padding(0);
            this.c_fraktur.Name = "c_fraktur";
            this.c_fraktur.Size = new System.Drawing.Size(200, 29);
            this.c_fraktur.TabIndex = 11;
            this.c_fraktur.Text = "Fraktur";
            this.c_fraktur.UseVisualStyleBackColor = true;
            this.c_fraktur.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_smallcaps
            // 
            this.c_smallcaps.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_smallcaps.AutoEllipsis = true;
            this.c_smallcaps.Location = new System.Drawing.Point(200, 230);
            this.c_smallcaps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_smallcaps.Name = "c_smallcaps";
            this.c_smallcaps.Size = new System.Drawing.Size(200, 29);
            this.c_smallcaps.TabIndex = 21;
            this.c_smallcaps.Text = "Small Caps";
            this.c_smallcaps.UseVisualStyleBackColor = true;
            this.c_smallcaps.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_subscript
            // 
            this.c_subscript.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_subscript.AutoEllipsis = true;
            this.c_subscript.Location = new System.Drawing.Point(200, 259);
            this.c_subscript.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_subscript.Name = "c_subscript";
            this.c_subscript.Size = new System.Drawing.Size(200, 29);
            this.c_subscript.TabIndex = 22;
            this.c_subscript.Text = "Subscript";
            this.c_subscript.UseVisualStyleBackColor = true;
            this.c_subscript.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_generator
            // 
            this.c_generator.Location = new System.Drawing.Point(512, 0);
            this.c_generator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_generator.Name = "c_generator";
            this.c_generator.Size = new System.Drawing.Size(88, 27);
            this.c_generator.TabIndex = 1;
            this.c_generator.Text = "Generator";
            this.c_generator.UseVisualStyleBackColor = true;
            this.c_generator.Visible = false;
            this.c_generator.Click += new System.EventHandler(this.Generator_Click);
            // 
            // c_tm
            // 
            this.c_tm.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_tm.AutoEllipsis = true;
            this.c_tm.Location = new System.Drawing.Point(400, 56);
            this.c_tm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_tm.Name = "c_tm";
            this.c_tm.Size = new System.Drawing.Size(200, 29);
            this.c_tm.TabIndex = 27;
            this.c_tm.Text = "TM";
            this.c_tm.UseVisualStyleBackColor = true;
            this.c_tm.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_ae
            // 
            this.c_ae.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_ae.AutoEllipsis = true;
            this.c_ae.Location = new System.Drawing.Point(400, 114);
            this.c_ae.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_ae.Name = "c_ae";
            this.c_ae.Size = new System.Drawing.Size(200, 29);
            this.c_ae.TabIndex = 29;
            this.c_ae.Text = "LAEMON";
            this.c_ae.UseVisualStyleBackColor = true;
            this.c_ae.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_parenthesized
            // 
            this.c_parenthesized.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_parenthesized.AutoEllipsis = true;
            this.c_parenthesized.Location = new System.Drawing.Point(200, 288);
            this.c_parenthesized.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_parenthesized.Name = "c_parenthesized";
            this.c_parenthesized.Size = new System.Drawing.Size(200, 29);
            this.c_parenthesized.TabIndex = 23;
            this.c_parenthesized.Text = "Parenthesized";
            this.c_parenthesized.UseVisualStyleBackColor = true;
            this.c_parenthesized.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_zalgo
            // 
            this.c_zalgo.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_zalgo.AutoEllipsis = true;
            this.c_zalgo.Location = new System.Drawing.Point(400, 27);
            this.c_zalgo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_zalgo.Name = "c_zalgo";
            this.c_zalgo.Size = new System.Drawing.Size(200, 29);
            this.c_zalgo.TabIndex = 26;
            this.c_zalgo.Text = "Zalgo";
            this.c_zalgo.UseVisualStyleBackColor = true;
            this.c_zalgo.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_nibba
            // 
            this.c_nibba.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_nibba.AutoEllipsis = true;
            this.c_nibba.Location = new System.Drawing.Point(400, 85);
            this.c_nibba.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_nibba.Name = "c_nibba";
            this.c_nibba.Size = new System.Drawing.Size(200, 29);
            this.c_nibba.TabIndex = 28;
            this.c_nibba.Text = "NiBBa";
            this.c_nibba.UseVisualStyleBackColor = true;
            this.c_nibba.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_mixed
            // 
            this.c_mixed.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_mixed.AutoEllipsis = true;
            this.c_mixed.Location = new System.Drawing.Point(200, 317);
            this.c_mixed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_mixed.Name = "c_mixed";
            this.c_mixed.Size = new System.Drawing.Size(200, 29);
            this.c_mixed.TabIndex = 24;
            this.c_mixed.Text = "Mixed";
            this.c_mixed.UseVisualStyleBackColor = true;
            this.c_mixed.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_numberspeak
            // 
            this.c_numberspeak.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_numberspeak.AutoEllipsis = true;
            this.c_numberspeak.Location = new System.Drawing.Point(400, 143);
            this.c_numberspeak.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_numberspeak.Name = "c_numberspeak";
            this.c_numberspeak.Size = new System.Drawing.Size(200, 29);
            this.c_numberspeak.TabIndex = 30;
            this.c_numberspeak.Text = "number speak";
            this.c_numberspeak.UseVisualStyleBackColor = true;
            this.c_numberspeak.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_blankbanshee
            // 
            this.c_blankbanshee.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_blankbanshee.AutoEllipsis = true;
            this.c_blankbanshee.Location = new System.Drawing.Point(400, 172);
            this.c_blankbanshee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_blankbanshee.Name = "c_blankbanshee";
            this.c_blankbanshee.Size = new System.Drawing.Size(200, 29);
            this.c_blankbanshee.TabIndex = 31;
            this.c_blankbanshee.Text = "BLANK BANSHEE";
            this.c_blankbanshee.UseVisualStyleBackColor = true;
            this.c_blankbanshee.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_randomcase
            // 
            this.c_randomcase.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_randomcase.AutoEllipsis = true;
            this.c_randomcase.Location = new System.Drawing.Point(400, 201);
            this.c_randomcase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_randomcase.Name = "c_randomcase";
            this.c_randomcase.Size = new System.Drawing.Size(200, 29);
            this.c_randomcase.TabIndex = 32;
            this.c_randomcase.Text = "RAndOm CaSE";
            this.c_randomcase.UseVisualStyleBackColor = true;
            this.c_randomcase.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // zalgo_intensity
            // 
            this.zalgo_intensity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zalgo_intensity.LargeChange = 1;
            this.zalgo_intensity.Location = new System.Drawing.Point(86, 13);
            this.zalgo_intensity.Minimum = 2;
            this.zalgo_intensity.Name = "zalgo_intensity";
            this.zalgo_intensity.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.zalgo_intensity.Size = new System.Drawing.Size(45, 96);
            this.zalgo_intensity.TabIndex = 37;
            this.zalgo_intensity.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.zalgo_intensity.Value = 6;
            this.zalgo_intensity.Scroll += new System.EventHandler(this.Zalgo_Refresh);
            // 
            // zalgo_group
            // 
            this.zalgo_group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zalgo_group.Controls.Add(this.zalgo_buttom);
            this.zalgo_group.Controls.Add(this.zalgo_middle);
            this.zalgo_group.Controls.Add(this.zalgo_top);
            this.zalgo_group.Controls.Add(this.zalgo_intensity);
            this.zalgo_group.Location = new System.Drawing.Point(418, 244);
            this.zalgo_group.Name = "zalgo_group";
            this.zalgo_group.Size = new System.Drawing.Size(134, 113);
            this.zalgo_group.TabIndex = 33;
            this.zalgo_group.TabStop = false;
            this.zalgo_group.Text = "Zalgo";
            // 
            // zalgo_buttom
            // 
            this.zalgo_buttom.AutoSize = true;
            this.zalgo_buttom.Checked = true;
            this.zalgo_buttom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zalgo_buttom.Location = new System.Drawing.Point(6, 84);
            this.zalgo_buttom.Name = "zalgo_buttom";
            this.zalgo_buttom.Size = new System.Drawing.Size(79, 23);
            this.zalgo_buttom.TabIndex = 36;
            this.zalgo_buttom.Text = "Buttom";
            this.zalgo_buttom.UseVisualStyleBackColor = true;
            this.zalgo_buttom.CheckedChanged += new System.EventHandler(this.Zalgo_Refresh);
            // 
            // zalgo_middle
            // 
            this.zalgo_middle.AutoSize = true;
            this.zalgo_middle.Checked = true;
            this.zalgo_middle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zalgo_middle.Location = new System.Drawing.Point(6, 55);
            this.zalgo_middle.Name = "zalgo_middle";
            this.zalgo_middle.Size = new System.Drawing.Size(74, 23);
            this.zalgo_middle.TabIndex = 35;
            this.zalgo_middle.Text = "Middle";
            this.zalgo_middle.UseVisualStyleBackColor = true;
            this.zalgo_middle.CheckedChanged += new System.EventHandler(this.Zalgo_Refresh);
            // 
            // zalgo_top
            // 
            this.zalgo_top.AutoSize = true;
            this.zalgo_top.Checked = true;
            this.zalgo_top.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zalgo_top.Location = new System.Drawing.Point(6, 26);
            this.zalgo_top.Name = "zalgo_top";
            this.zalgo_top.Size = new System.Drawing.Size(56, 23);
            this.zalgo_top.TabIndex = 34;
            this.zalgo_top.Text = "Top";
            this.zalgo_top.UseVisualStyleBackColor = true;
            this.zalgo_top.CheckedChanged += new System.EventHandler(this.Zalgo_Refresh);
            // 
            // DelayedUpdate
            // 
            this.DelayedUpdate.Tick += new System.EventHandler(this.DelayedUpdate_Tick);
            // 
            // c_serifitalic
            // 
            this.c_serifitalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_serifitalic.AutoEllipsis = true;
            this.c_serifitalic.Location = new System.Drawing.Point(0, 56);
            this.c_serifitalic.Margin = new System.Windows.Forms.Padding(0);
            this.c_serifitalic.Name = "c_serifitalic";
            this.c_serifitalic.Size = new System.Drawing.Size(200, 29);
            this.c_serifitalic.TabIndex = 3;
            this.c_serifitalic.Text = "Serif Italic";
            this.c_serifitalic.UseVisualStyleBackColor = true;
            this.c_serifitalic.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_script
            // 
            this.c_script.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_script.AutoEllipsis = true;
            this.c_script.Location = new System.Drawing.Point(0, 230);
            this.c_script.Margin = new System.Windows.Forms.Padding(0);
            this.c_script.Name = "c_script";
            this.c_script.Size = new System.Drawing.Size(200, 29);
            this.c_script.TabIndex = 9;
            this.c_script.Text = "Script";
            this.c_script.UseVisualStyleBackColor = true;
            this.c_script.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // c_extrathicc
            // 
            this.c_extrathicc.Appearance = System.Windows.Forms.Appearance.Button;
            this.c_extrathicc.AutoEllipsis = true;
            this.c_extrathicc.Location = new System.Drawing.Point(200, 346);
            this.c_extrathicc.Name = "c_extrathicc";
            this.c_extrathicc.Size = new System.Drawing.Size(200, 29);
            this.c_extrathicc.TabIndex = 25;
            this.c_extrathicc.Text = "EXTRA THICC";
            this.c_extrathicc.UseVisualStyleBackColor = true;
            this.c_extrathicc.CheckedChanged += new System.EventHandler(this.CopyHandler);
            // 
            // Halp
            // 
            this.Halp.Font = new System.Drawing.Font("Arial", 15F);
            this.Halp.Location = new System.Drawing.Point(571, 346);
            this.Halp.Name = "Halp";
            this.Halp.Size = new System.Drawing.Size(29, 29);
            this.Halp.TabIndex = 38;
            this.Halp.Text = "?";
            this.Halp.UseCompatibleTextRendering = true;
            this.Halp.UseVisualStyleBackColor = true;
            this.Halp.Click += new System.EventHandler(this.Halp_Click);
            // 
            // TextifyApp
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 375);
            this.Controls.Add(this.Halp);
            this.Controls.Add(this.c_generator);
            this.Controls.Add(this.c_txt);
            this.Controls.Add(this.zalgo_group);
            this.Controls.Add(this.c_randomcase);
            this.Controls.Add(this.c_blankbanshee);
            this.Controls.Add(this.c_numberspeak);
            this.Controls.Add(this.c_ae);
            this.Controls.Add(this.c_nibba);
            this.Controls.Add(this.c_zalgo);
            this.Controls.Add(this.c_tm);
            this.Controls.Add(this.c_extrathicc);
            this.Controls.Add(this.c_mixed);
            this.Controls.Add(this.c_parenthesized);
            this.Controls.Add(this.c_subscript);
            this.Controls.Add(this.c_smallcaps);
            this.Controls.Add(this.c_inverted);
            this.Controls.Add(this.c_squaredinvert);
            this.Controls.Add(this.c_squared);
            this.Controls.Add(this.c_circledinvert);
            this.Controls.Add(this.c_circled);
            this.Controls.Add(this.c_doublestruck);
            this.Controls.Add(this.c_fullwidth);
            this.Controls.Add(this.c_script);
            this.Controls.Add(this.c_serifitalic);
            this.Controls.Add(this.c_fraktur);
            this.Controls.Add(this.c_sansitalic);
            this.Controls.Add(this.c_sansbolditalic);
            this.Controls.Add(this.c_sansbold);
            this.Controls.Add(this.c_sans);
            this.Controls.Add(this.c_monospace);
            this.Controls.Add(this.c_scriptbold);
            this.Controls.Add(this.c_serifbolditalic);
            this.Controls.Add(this.c_frakturbold);
            this.Controls.Add(this.c_serifbold);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "TextifyApp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Textify";
            this.LocationChanged += new System.EventHandler(this.SaveHandler);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragNDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragNEnter);
            ((System.ComponentModel.ISupportInitialize)(this.zalgo_intensity)).EndInit();
            this.zalgo_group.ResumeLayout(false);
            this.zalgo_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox c_txt;
        private System.Windows.Forms.RadioButton c_fullwidth;
        private System.Windows.Forms.RadioButton c_circled;
        private System.Windows.Forms.RadioButton c_circledinvert;
        private System.Windows.Forms.RadioButton c_serifbold;
        private System.Windows.Forms.RadioButton c_frakturbold;
        private System.Windows.Forms.RadioButton c_serifbolditalic;
        private System.Windows.Forms.RadioButton c_scriptbold;
        private System.Windows.Forms.RadioButton c_doublestruck;
        private System.Windows.Forms.RadioButton c_monospace;
        private System.Windows.Forms.RadioButton c_sans;
        private System.Windows.Forms.RadioButton c_sansbold;
        private System.Windows.Forms.RadioButton c_sansbolditalic;
        private System.Windows.Forms.RadioButton c_sansitalic;
        private System.Windows.Forms.RadioButton c_squared;
        private System.Windows.Forms.RadioButton c_squaredinvert;
        private System.Windows.Forms.RadioButton c_inverted;
        private System.Windows.Forms.RadioButton c_fraktur;
        private System.Windows.Forms.RadioButton c_smallcaps;
        private System.Windows.Forms.RadioButton c_subscript;
        private System.Windows.Forms.Button c_generator;
        private System.Windows.Forms.RadioButton c_tm;
        private System.Windows.Forms.RadioButton c_ae;
        private System.Windows.Forms.RadioButton c_parenthesized;
        private System.Windows.Forms.RadioButton c_zalgo;
        private System.Windows.Forms.RadioButton c_nibba;
        private System.Windows.Forms.RadioButton c_mixed;
        private System.Windows.Forms.RadioButton c_numberspeak;
        private System.Windows.Forms.RadioButton c_blankbanshee;
        private System.Windows.Forms.RadioButton c_randomcase;
        private System.Windows.Forms.TrackBar zalgo_intensity;
        private System.Windows.Forms.GroupBox zalgo_group;
        private System.Windows.Forms.CheckBox zalgo_buttom;
        private System.Windows.Forms.CheckBox zalgo_middle;
        private System.Windows.Forms.CheckBox zalgo_top;
        private System.Windows.Forms.Timer DelayedUpdate;
        private System.Windows.Forms.RadioButton c_serifitalic;
        private System.Windows.Forms.RadioButton c_script;
        private System.Windows.Forms.RadioButton c_extrathicc;
        private System.Windows.Forms.Button Halp;
    }
}

