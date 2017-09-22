using System;
using System.IO;
using TextifyLib;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TextifyApp
{
    public partial class TextifyApp : Form
    {
        public static readonly Face CharNibba = new Face(new Dictionary<char, string>()
        {
            { 'B', "🅱" }
        }, false, LetterCase.Mixed);
        public static readonly Face CharAE    = new Face(new Dictionary<char, string>()
        {
            { 'E', "Æ" },
            { 'e', "æ" },
            { '?', "‽" }
        }, false, LetterCase.Mixed);

        private bool working = false;
        private bool save = false;

        public TextifyApp()
        {
            InitializeComponent();
            
            try
            {
                if (File.Exists("sliders"))
                {
                    StreamReader file = new StreamReader("sliders");
                    Int32  .TryParse(file.ReadLine(), out int  intensity);
                    Boolean.TryParse(file.ReadLine(), out bool top      );
                    Boolean.TryParse(file.ReadLine(), out bool mid      );
                    Boolean.TryParse(file.ReadLine(), out bool buttom   );
                    file.Close();
                    zalgo_intensity.Value = Math.Max(Math.Min(intensity, 3), 1);
                    zalgo_top   .Checked = top   ;
                    zalgo_middle.Checked = mid   ;
                    zalgo_buttom.Checked = buttom;
                }
            }
            catch { }
            working = true;

            Labler();
        }
        
        public string RandomConvertString(string cyrillic)
        {
            cyrillic = cyrillic.ToLower();
            if (RandomNumber(0, 2) == 1)
            {
                cyrillic = cyrillic.Replace("tm", "™");
            }
            if (RandomNumber(0, 2) == 1)
            {
                cyrillic = cyrillic.Replace("sm", "℠");
            }

            StringBuilder result = new StringBuilder();
            foreach (char ch in cyrillic)
            {
                if ((ch == '™') || (ch == '℠'))
                {
                    result.Append(ch);
                }
                else
                {
                    result.Append(RandomConvertChar(ch, 23));
                }
            }
            return result.ToString();
        }

        private string RandomConvertChar(char c, int chance)
        {
            if (RandomNumber(0, 2) == 0)
            {
                c = c.ToString().ToUpper()[0];
            }
            else
            {
                c = c.ToString().ToLower()[0];
            }

            while (true)
            {
                switch (RandomNumber(0, 23))
                {
                    case 0:
                        if (Typefaces.CharSerifBold.ContainsChar(c))
                        {
                            return Typefaces.CharSerifBold.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 1:
                        if (Typefaces.CharSerifItalic.ContainsChar(c))
                        {
                            return Typefaces.CharSerifItalic.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 2:
                        if (Typefaces.CharSerifBoldItalic.ContainsChar(c))
                        {
                            return Typefaces.CharSerifBoldItalic.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 3:
                        if (Typefaces.CharSans.ContainsChar(c))
                        {
                            return Typefaces.CharSans.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 4:
                        if (Typefaces.CharSansBold.ContainsChar(c))
                        {
                            return Typefaces.CharSansBold.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 5:
                        if (Typefaces.CharSansItalic.ContainsChar(c))
                        {
                            return Typefaces.CharSansItalic.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 6:
                        if (Typefaces.CharSansBoldItalic.ContainsChar(c))
                        {
                            return Typefaces.CharSansBoldItalic.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 7:
                        if (Typefaces.CharScript.ContainsChar(c))
                        {
                            return Typefaces.CharScript.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 8:
                        if (Typefaces.CharScriptBold.ContainsChar(c))
                        {
                            return Typefaces.CharScriptBold.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 9:
                        if (Typefaces.CharFraktur.ContainsChar(c))
                        {
                            return Typefaces.CharFraktur.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 10:
                        if (Typefaces.CharFrakturBold.ContainsChar(c))
                        {
                            return Typefaces.CharFrakturBold.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 11:
                        if (Typefaces.CharMonospace.ContainsChar(c))
                        {
                            return Typefaces.CharMonospace.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 12:
                        return Typefaces.CharFullwidth.Convert(c);
                    case 13:
                        if (Typefaces.CharDoubleStruck.ContainsChar(c))
                        {
                            return Typefaces.CharDoubleStruck.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 14:
                        if (Typefaces.CharCircled.ContainsChar(c))
                        {
                            return Typefaces.CharCircled.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 15:
                        if (Typefaces.CharCircledInvert.ContainsChar(c))
                        {
                            return Typefaces.CharCircledInvert.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 16:
                        if (Typefaces.CharSquared.ContainsChar(c))
                        {
                            return Typefaces.CharSquared.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 17:
                        if (Typefaces.CharSquaredInvert.ContainsChar(c))
                        {
                            return Typefaces.CharSquaredInvert.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 18:
                        if (Typefaces.CharSmallCaps.ContainsChar(c))
                        {
                            return Typefaces.CharSmallCaps.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 19:
                        if (Typefaces.CharSubscript.ContainsChar(c))
                        {
                            return Typefaces.CharSubscript.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 20:
                        if (Typefaces.CharParenthesized.ContainsChar(c))
                        {
                            return Typefaces.CharParenthesized.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 21:
                        if (Typefaces.CharExtraThicc.ContainsChar(c))
                        {
                            return Typefaces.CharExtraThicc.Convert(c);
                        }
                        else
                        {
                            if (RandomNumber(0, chance) == 0)
                            {
                                return c.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 22:
                        return c.ToString();
                    default:
                        return "#";
                }
            }
        }
        
        private string Randomcase(string txt)
        {
            int length = RandomNumber(0, 3);
            int pos = 0;
            bool cas = RandomNumber(0, 3) == 0;
            StringBuilder result = new StringBuilder();
            foreach (char c in txt)
            {
                if (c == ' ')
                {
                    result.Append(" ");
                    cas = RandomNumber(0, 2) == 0;
                    length = RandomNumber(0, 3);
                    pos = 0;
                }
                else
                {
                    if (pos > length)
                    {
                        length = RandomNumber(0, 3);
                        pos = 0;
                        cas = !cas;
                    }
                    else
                    {
                        pos++;
                    }

                    if (cas)
                    {
                        result.Append(c.ToString().ToUpper());
                    }
                    else
                    {
                        result.Append(c.ToString().ToLower());
                    }
                }
            }
            return result.ToString();
        }
        
        public static int RandomNumber(int Low, int High)
        {
            Random rndNum = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));

            int rnd = rndNum.Next(Low, High);

            return rnd;
        }

        private void Copy()
        {
            if (c_txt.Text != "")
            {
                foreach (Control control in Controls)
                {
                    if (control is RadioButton)
                    {
                        RadioButton radio = control as RadioButton;
                        if (radio.Checked)
                        {
                            Clipboard.SetText(radio.Text);
                        }
                    }
                }
            }
        }

        private void Labler()
        {
            c_serifbold.Text = "𝐒𝐞𝐫𝐢𝐟 𝐁𝐨𝐥𝐝";
            c_serifitalic.Text = "𝑆𝑒𝑟𝑖𝑓 𝐼𝑡𝑎𝑙𝑖𝑐";
            c_serifbolditalic.Text = "𝑺𝒆𝒓𝒊𝒇 𝑩𝒐𝒍𝒅 𝑰𝒕𝒂𝒍𝒊𝒄";
            c_sans.Text = "𝖲𝖺𝗇𝗌";
            c_sansbold.Text = "𝗦𝗮𝗻𝘀 𝗕𝗼𝗹𝗱";
            c_sansitalic.Text = "𝘚𝘢𝘯𝘴 𝘐𝘵𝘢𝘭𝘪𝘤";
            c_sansbolditalic.Text = "𝙎𝙖𝙣𝙨 𝘽𝙤𝙡𝙙 𝙄𝙩𝙖𝙡𝙞𝙘";
            c_script.Text = "𝒮𝒸𝓇𝒾𝓅𝓉";
            c_scriptbold.Text = "𝓢𝓬𝓻𝓲𝓹𝓽 𝓑𝓸𝓵𝓭";
            c_fraktur.Text = "𝔉𝔯𝔞𝔨𝔱𝔲𝔯";
            c_frakturbold.Text = "𝕱𝖗𝖆𝖐𝖙𝖚𝖗 𝕭𝖔𝖑𝖉";

            c_monospace.Text = "𝙼𝚘𝚗𝚘𝚜𝚙𝚊𝚌𝚎";
            c_fullwidth.Text = "Ｆｕｌｌｗｉｄｔｈ";
            c_doublestruck.Text = "𝔻𝕠𝕦𝕓𝕝𝕖-𝕊𝕥𝕣𝕦𝕔𝕜";
            c_inverted.Text = "pǝʇɹǝʌuı";
            c_circled.Text = "Ⓒⓘⓡⓒⓛⓔⓓ";
            c_circledinvert.Text = "🅒🅘🅡🅒🅛🅔🅓 🅑🅛🅐🅒🅚";
            c_squared.Text = "🅂🅀🅄🄰🅁🄴🄳";
            c_squaredinvert.Text = "🆂🆀🆄🅰🆁🅴🅳 🅱🅻🅰🅲🅺";
            c_smallcaps.Text = "ꜱᴍᴀʟʟ ᴄᴀᴩꜱ";
            c_subscript.Text = "ˢᵘᵇˢᶜʳⁱᵖᵗ";
            c_parenthesized.Text = "⒫⒜⒭⒠⒩⒯⒣⒠⒮⒤⒵⒠⒟";
            c_mixed.Text = RandomConvertString("mixed");
            c_extrathicc.Text = "乇乂ㄒ尺卂 ㄒ卄丨匚匚";
            
            c_zalgo.Text = Zalgo.ToZalgo("Zalgo", zalgo_intensity.Value * 0.5f, zalgo_top.Checked, zalgo_middle.Checked, zalgo_buttom.Checked);
            c_tm.Text = "Trademark™";
            c_nibba.Text = "Ni🅱🅱a";
            c_ae.Text = "LÆMON‽";

            c_numberspeak.Text = "num83r5p34k";
            c_blankbanshee.Text = "BLΛNK BΛNSHΣΣ";
            c_randomcase.Text = Randomcase("randomcase");
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            DelayedUpdate.Stop();
            DelayedUpdate.Start();
        }

        private void Generator_Click(object sender, EventArgs e)
        {
            Generator bob = new Generator();
            bob.ShowDialog();
        }

        private void CopyHandler(object sender, EventArgs e)
        {
            Copy();
        }
        
        private void Zalgo_Refresh(object sender, EventArgs e)
        {
            if (working)
            {
                if (c_txt.Text == "")
                {
                    c_zalgo.Text = Zalgo.ToZalgo("Zalgo", zalgo_intensity.Value * 0.5f, zalgo_top.Checked, zalgo_middle.Checked, zalgo_buttom.Checked);
                }
                else
                {
                    c_zalgo.Text = Zalgo.ToZalgo(c_txt.Text, zalgo_intensity.Value * 0.5f, zalgo_top.Checked, zalgo_middle.Checked, zalgo_buttom.Checked);
                }
                Copy();

                if (save)
                {
                    StreamWriter file = new StreamWriter("sliders");
                    file.WriteLine(zalgo_intensity.Value);
                    file.WriteLine(zalgo_top.Checked);
                    file.WriteLine(zalgo_middle.Checked);
                    file.WriteLine(zalgo_buttom.Checked);
                    file.Close();
                }
            }
        }

        private void DelayedUpdate_Tick(object sender, EventArgs e)
        {
            DelayedUpdate.Stop();
            if (c_txt.Text == "")
            {
                Labler();
            }
            else
            {
                c_serifbold.Text       = Typefaces.CharSerifBold      .Convert(c_txt.Text);
                c_serifitalic.Text     = Typefaces.CharSerifItalic    .Convert(c_txt.Text);
                c_serifbolditalic.Text = Typefaces.CharSerifBoldItalic.Convert(c_txt.Text);
                c_sans.Text            = Typefaces.CharSans           .Convert(c_txt.Text);
                c_sansbold.Text        = Typefaces.CharSansBold       .Convert(c_txt.Text);
                c_sansitalic.Text      = Typefaces.CharSansItalic     .Convert(c_txt.Text);
                c_sansbolditalic.Text  = Typefaces.CharSansBoldItalic .Convert(c_txt.Text);
                c_script.Text          = Typefaces.CharScript         .Convert(c_txt.Text);
                c_scriptbold.Text      = Typefaces.CharScriptBold     .Convert(c_txt.Text);
                c_fraktur.Text         = Typefaces.CharFraktur        .Convert(c_txt.Text);
                c_frakturbold.Text     = Typefaces.CharFrakturBold    .Convert(c_txt.Text);
                c_monospace.Text       = Typefaces.CharMonospace      .Convert(c_txt.Text);

                c_fullwidth.Text       = Typefaces.CharFullwidth      .Convert(c_txt.Text);
                c_doublestruck.Text    = Typefaces.CharDoubleStruck   .Convert(c_txt.Text);
                c_inverted.Text        = Typefaces.CharInverted       .Convert(new string(c_txt.Text.Reverse().ToArray()));
                c_circled.Text         = Typefaces.CharCircled        .Convert(c_txt.Text);
                c_circledinvert.Text   = Typefaces.CharCircledInvert  .Convert(c_txt.Text);
                c_squared.Text         = Typefaces.CharSquared        .Convert(c_txt.Text);
                c_squaredinvert.Text   = Typefaces.CharSquaredInvert  .Convert(c_txt.Text);
                c_smallcaps.Text       = Typefaces.CharSmallCaps      .Convert(c_txt.Text);
                c_subscript.Text       = Typefaces.CharSubscript      .Convert(c_txt.Text);
                c_parenthesized.Text   = Typefaces.CharParenthesized  .Convert(c_txt.Text);
                c_mixed.Text           = RandomConvertString                  (c_txt.Text);
                c_extrathicc.Text      = Typefaces.CharExtraThicc     .Convert(c_txt.Text);

                c_zalgo.Text           = Zalgo.ToZalgo                        (c_txt.Text, zalgo_intensity.Value * 0.5f, zalgo_top.Checked, zalgo_middle.Checked, zalgo_buttom.Checked);
                c_tm.Text              = c_txt.Text + "™";
                c_nibba.Text           = CharNibba                    .Convert(c_txt.Text);
                c_ae.Text              = CharAE                       .Convert(c_txt.Text);
                c_numberspeak.Text     = Typefaces.CharNumberspeak    .Convert(c_txt.Text);
                c_blankbanshee.Text    = Typefaces.CharBlankBanshee   .Convert(c_txt.Text);
                c_randomcase.Text      = Randomcase                           (c_txt.Text);
                
                c_generator.Visible = c_txt.Text.ToLower() == "generator";
            }

            Copy();
        }
        
        private void Halp_Click(object sender, EventArgs e)
        {
            Instructions dialog = new Instructions();
            dialog.ShowDialog();
        }
    }

    public static class Zalgo
    {
        static readonly Random Rnd = new Random();
        
        public static char[] ZalgoUp = {
            '\u030d', /*     Ì      */
            '\u030e', /*     ÌŽ     */
            '\u0304', /*     Ì„     */
            '\u0305', /*     Ì…     */
            '\u033f', /*     Ì¿     */
            '\u0311', /*     Ì‘     */
            '\u0306', /*     Ì†     */
            '\u0310', /*     Ì      */
            '\u0352', /*     Í’     */
            '\u0357', /*     Í—     */
            '\u0351', /*     Í‘     */
            '\u0307', /*     Ì‡     */
            '\u0308', /*     Ìˆ     */
            '\u030a', /*     ÌŠ     */
            '\u0342', /*     Í‚     */
            '\u0343', /*     Ì“     */
            '\u0344', /*     ÌˆÌ    */
            '\u034a', /*     ÍŠ     */
            '\u034b', /*     Í‹     */
            '\u034c', /*     ÍŒ     */
            '\u0303', /*     Ìƒ     */
            '\u0302', /*     Ì‚     */
            '\u030c', /*     ÌŒ     */
            '\u0350', /*     Í      */
            '\u0300', /*     Ì€     */
            '\u0301', /*     Ì      */
            '\u030b', /*     Ì‹     */
            '\u030f', /*     Ì      */
            '\u0312', /*     Ì’     */
            '\u0313', /*     Ì“     */
            '\u0314', /*     Ì”     */
            '\u033d', /*     Ì½     */
            '\u0309', /*     Ì‰     */
            '\u0363', /*     Í£     */
            '\u0364', /*     Í¤     */
            '\u0365', /*     Í¥     */
            '\u0366', /*     Í¦     */
            '\u0367', /*     Í§     */
            '\u0368', /*     Í¨     */
            '\u0369', /*     Í©     */
            '\u036a', /*     Íª     */
            '\u036b', /*     Í«     */
            '\u036c', /*     Í¬     */
            '\u036d', /*     Í­      */
            '\u036e', /*     Í®     */
            '\u036f', /*     Í¯     */
            '\u033e', /*     Ì¾     */
            '\u035b', /*     Í›     */
            '\u0346', /*     Í†     */
            '\u031a'  /*     Ìš     */
        };
        public static char[] ZalgoDown = {
            '\u0316', /*     Ì–     */
            '\u0317', /*     Ì—     */
            '\u0318', /*     Ì˜     */
            '\u0319', /*     Ì™     */
            '\u031c', /*     Ìœ     */
            '\u031d', /*     Ì      */
            '\u031e', /*     Ìž     */
            '\u031f', /*     ÌŸ     */
            '\u0320', /*     Ì      */
            '\u0324', /*     Ì¤     */
            '\u0325', /*     Ì¥     */
            '\u0326', /*     Ì¦     */
            '\u0329', /*     Ì©     */
            '\u032a', /*     Ìª     */
            '\u032b', /*     Ì«     */
            '\u032c', /*     Ì¬     */
            '\u032d', /*     Ì­      */
            '\u032e', /*     Ì®     */
            '\u032f', /*     Ì¯     */
            '\u0330', /*     Ì°     */
            '\u0331', /*     Ì±     */
            '\u0332', /*     Ì²     */
            '\u0333', /*     Ì³     */
            '\u0339', /*     Ì¹     */
            '\u033a', /*     Ìº     */
            '\u033b', /*     Ì»     */
            '\u033c', /*     Ì¼     */
            '\u0345', /*     Í…     */
            '\u0347', /*     Í‡     */
            '\u0348', /*     Íˆ     */
            '\u0349', /*     Í‰     */
            '\u034d', /*     Í      */
            '\u034e', /*     ÍŽ     */
            '\u0353', /*     Í“     */
            '\u0354', /*     Í”     */
            '\u0355', /*     Í•     */
            '\u0356', /*     Í–     */
            '\u0359', /*     Í™     */
            '\u035a', /*     Íš     */
            '\u0323'  /*     Ì£     */
        };
        public static char[] ZalgoMid = {
            '\u0315', /*     Ì•     */
            '\u031b', /*     Ì›     */
            '\u0340', /*     Ì€     */
            '\u0341', /*     Ì      */
            '\u0358', /*     Í˜     */
            '\u0321', /*     Ì¡     */
            '\u0322', /*     Ì¢     */
            '\u0327', /*     Ì§     */
            '\u0328', /*     Ì¨     */
            '\u0334', /*     Ì´     */
            '\u0335', /*     Ìµ     */
            '\u0336', /*     Ì¶     */
            '\u034f', /*     Í      */
            '\u035c', /*     Íœ     */
            '\u035d', /*     Í      */
            '\u035e', /*     Íž     */
            '\u035f', /*     ÍŸ     */
            '\u0360', /*     Í      */
            '\u0362', /*     Í¢     */
            '\u0338', /*     Ì¸     */
//          '\u0337', /*     Ì·     */
//          '\u0361', /*     Í¡     */
//          '\u0489'  /*    Ò‰_     */		
        };

        public static bool IsZalgoChar(char c)
        {
            if (ZalgoDown.Contains(c) ||
                ZalgoMid.Contains(c) ||
                ZalgoUp.Contains(c))
                return true;
            return false;
        }
        
        public static string ToZalgo(this string text, float size = 2, bool top = true, bool mid = true, bool buttom = true)
        {
            var newtxt = "";

            for (var i = 0; i < text.Length; i++)
            {
                if (IsZalgoChar(text.ToCharArray()[i]))
                    continue;

                newtxt += text.ToCharArray()[i];
                newtxt += GetZalgo(size, top, mid, buttom);
            }

            return newtxt;
        }

        public static string GetZalgo(float size = 3, bool top = true, bool mid = true, bool buttom = true)
        {
            var newtxt = "";
            var numUp = 0;
            var numMid = 0;
            var numDown = 0;
            size = Math.Max(size, 1);
            try
            {
                if (top)
                {
                    numUp = (int)(Rnd.Next(1, (int)(Math.Pow(2, size + 2))) / Math.Pow(2, size - 1) + Math.Max(size * 2, 0));
                }
                if (mid)
                {
                    numMid = (int)(Rnd.Next(1, (int)((size * 5 - 3) / Math.Pow(2, size - 1))) + Math.Max((size - 1) * 2, 0));
                }
                if (buttom)
                {
                    numDown = (int)(Rnd.Next(1, (int)(Math.Pow(2, size + 2) / Math.Pow(2, size - 1))) + Math.Max(size * 2, 0));
                }
            }
            catch { }
            
            if (top   )
            {
                for (var j = 0; j < numUp; j++)
                {
                    newtxt += RandZalgo(ZalgoUp);
                }
            }
            if (mid   )
            {
                for (var j = 0; j < numMid; j++)
                {
                    newtxt += RandZalgo(ZalgoMid);
                }
            }
            if (buttom)
            {
                for (var j = 0; j < numDown; j++)
                {
                    newtxt += RandZalgo(ZalgoDown);
                }
            }

            return newtxt;
        }
        
        static char RandZalgo(IList<char> set)
        {
            var r = Rnd.Next(1, set.Count);
            return set[r];
        }
    }
}