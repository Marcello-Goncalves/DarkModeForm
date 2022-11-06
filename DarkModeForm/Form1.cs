using System;
using System.Drawing;
using System.Windows.Forms;

namespace DarkModeForm
{
    public partial class Form1 : Form
    {
        #region FORM
        public Form1() => InitializeComponent();
        private void Form1_Load(object sender, EventArgs e) => StartPosition = FormStartPosition.CenterScreen;
        #endregion
        //
        #region EVENTS
        private void radioButtonLight_CheckedChanged  (object sender, EventArgs e) => LightModeTheme();
        private void radioButtonDark_CheckedChanged   (object sender, EventArgs e) => DarkModeTheme();
        private void radioButtonSystem_CheckedChanged (object sender, EventArgs e)
        {
            switch (SystemTheme.Status())
            {
                case 0:  DarkModeTheme();  break;
                case 1:  LightModeTheme(); break;
                default: MessageBox.Show("System Theme Could Not Be Found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }
        
        #endregion
        //
        #region THEMES 
        private void LightModeTheme()
        {
            DarkTitleBar.UseImmersiveDarkMode(Handle, false);

            BackColor = Color.FromArgb(255, 255, 255);
            ForeColor = Color.FromArgb(000, 000, 000);
        }

        private void DarkModeTheme()
        {
            DarkTitleBar.UseImmersiveDarkMode(Handle, true);

            BackColor = Color.FromArgb(032, 032, 032);
            ForeColor = Color.FromArgb(255, 255, 255);
        }
        #endregion
        //
    }
}
