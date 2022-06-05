#region

using System;
using System.Diagnostics;
using System.Windows.Forms;
using Themer;

#endregion

namespace Themer.Sample
{
    public partial class Showcase : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;

        private ThemerApplier _themer;

        protected override void OnLoad(EventArgs e)
        {
            // Initialize themer
            _themer = new ThemerApplier(this.Handle);
        }
        public Showcase()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m); // moveable window in borderless form
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)HT_CAPTION;
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                // toggle free mode
                guna2ControlBox1.Visible = false;
                guna2ControlBox2.Visible = false;
                guna2Panel1.Visible = false;
            }
            else
            {
                guna2ControlBox1.Visible = true;
                guna2ControlBox2.Visible = true;
                guna2Panel1.Visible = true;
            }
        }

        #region Events

        private void Showcase_Load(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            _themer.Apply(Themes.Acrylic);
            lbl.Text = "Acrylic";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            _themer.Apply(Themes.AeroGlass);
            lbl.Text = "Glass";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            _themer.Apply(Themes.Transparent);
            lbl.Text = "Transparent";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            _themer.Apply(Themes.None);
            lbl.Text = "Disabled";
        }

        private void lblSizeChanged(object sender, EventArgs e)
        {
            lbl.Left = (guna2Panel1.ClientSize.Width - lbl.Size.Width) / 2;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Themer is made to show you rare WinForm effecs made with DWM API. Explore different effects for your WinForm. You can use it by downloading the framework in my github.",
                "Themer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/arshx86");
        }

        #endregion
    }
}