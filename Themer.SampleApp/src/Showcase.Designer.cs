using Themer.Sample.Properties;

namespace Themer.Sample
{
	partial class Showcase
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lbl = new System.Windows.Forms.Label();
			this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
			this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
			this.guna2Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl
			// 
			this.lbl.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl.Location = new System.Drawing.Point(199, 78);
			this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(142, 42);
			this.lbl.TabIndex = 0;
			this.lbl.Text = "Themer";
			this.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lbl.SizeChanged += new System.EventHandler(this.lblSizeChanged);
			// 
			// guna2HtmlToolTip1
			// 
			this.guna2HtmlToolTip1.AllowLinksHandling = true;
			this.guna2HtmlToolTip1.BackColor = System.Drawing.Color.Black;
			this.guna2HtmlToolTip1.BorderColor = System.Drawing.Color.DarkSlateBlue;
			this.guna2HtmlToolTip1.ForeColor = System.Drawing.Color.White;
			this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
			this.guna2HtmlToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
			// 
			// guna2ControlBox1
			// 
			this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox1.Animated = true;
			this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2ControlBox1.BorderRadius = 3;
			this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
			this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new System.Drawing.Point(644, 12);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 10;
			this.guna2HtmlToolTip1.SetToolTip(this.guna2ControlBox1, "Exit");
			// 
			// guna2ControlBox2
			// 
			this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox2.Animated = true;
			this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
			this.guna2ControlBox2.BorderRadius = 3;
			this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
			this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox2.Location = new System.Drawing.Point(593, 12);
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
			this.guna2ControlBox2.TabIndex = 11;
			this.guna2HtmlToolTip1.SetToolTip(this.guna2ControlBox2, "Minimize");
			// 
			// guna2Button5
			// 
			this.guna2Button5.Animated = true;
			this.guna2Button5.BorderRadius = 11;
			this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
			this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button5.ForeColor = System.Drawing.Color.White;
			this.guna2Button5.Image = global::Themer.Sample.Properties.Resources.icons8_info_3;
			this.guna2Button5.Location = new System.Drawing.Point(3, 225);
			this.guna2Button5.Name = "guna2Button5";
			this.guna2Button5.Size = new System.Drawing.Size(49, 38);
			this.guna2Button5.TabIndex = 12;
			this.guna2HtmlToolTip1.SetToolTip(this.guna2Button5, "Whats this?");
			this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
			// 
			// guna2Button4
			// 
			this.guna2Button4.Animated = true;
			this.guna2Button4.BorderRadius = 11;
			this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
			this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button4.ForeColor = System.Drawing.Color.White;
			this.guna2Button4.Image = global::Themer.Sample.Properties.Resources.icons8_restore;
			this.guna2Button4.Location = new System.Drawing.Point(330, 123);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.Size = new System.Drawing.Size(49, 38);
			this.guna2Button4.TabIndex = 9;
			this.guna2HtmlToolTip1.SetToolTip(this.guna2Button4, "None");
			this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
			// 
			// guna2Button3
			// 
			this.guna2Button3.Animated = true;
			this.guna2Button3.BorderRadius = 11;
			this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
			this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button3.ForeColor = System.Drawing.Color.White;
			this.guna2Button3.Image = global::Themer.Sample.Properties.Resources.icons8_air;
			this.guna2Button3.Location = new System.Drawing.Point(275, 123);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Size = new System.Drawing.Size(49, 38);
			this.guna2Button3.TabIndex = 8;
			this.guna2HtmlToolTip1.SetToolTip(this.guna2Button3, "Transparent");
			this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
			// 
			// guna2Button2
			// 
			this.guna2Button2.Animated = true;
			this.guna2Button2.BorderRadius = 11;
			this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
			this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button2.ForeColor = System.Drawing.Color.White;
			this.guna2Button2.Image = global::Themer.Sample.Properties.Resources.icons8_blur;
			this.guna2Button2.Location = new System.Drawing.Point(220, 123);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(49, 38);
			this.guna2Button2.TabIndex = 7;
			this.guna2HtmlToolTip1.SetToolTip(this.guna2Button2, "Aero Glass");
			this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
			// 
			// guna2Button1
			// 
			this.guna2Button1.Animated = true;
			this.guna2Button1.BorderRadius = 11;
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.Image = global::Themer.Sample.Properties.Resources.icons8_visualy_impaired;
			this.guna2Button1.Location = new System.Drawing.Point(165, 123);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(49, 38);
			this.guna2Button1.TabIndex = 6;
			this.guna2HtmlToolTip1.SetToolTip(this.guna2Button1, "Acrylic");
			this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// guna2Button6
			// 
			this.guna2Button6.Animated = true;
			this.guna2Button6.BorderRadius = 11;
			this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button6.FillColor = System.Drawing.Color.Transparent;
			this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button6.ForeColor = System.Drawing.Color.White;
			this.guna2Button6.Image = global::Themer.Sample.Properties.Resources.icons8_github_1;
			this.guna2Button6.Location = new System.Drawing.Point(525, 225);
			this.guna2Button6.Name = "guna2Button6";
			this.guna2Button6.Size = new System.Drawing.Size(49, 38);
			this.guna2Button6.TabIndex = 13;
			this.guna2HtmlToolTip1.SetToolTip(this.guna2Button6, "Follow my github :)");
			this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
			// 
			// guna2ToggleSwitch1
			// 
			this.guna2ToggleSwitch1.Animated = true;
			this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
			this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
			this.guna2ToggleSwitch1.Location = new System.Drawing.Point(307, 365);
			this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
			this.guna2ToggleSwitch1.Size = new System.Drawing.Size(47, 20);
			this.guna2ToggleSwitch1.TabIndex = 15;
			this.guna2HtmlToolTip1.SetToolTip(this.guna2ToggleSwitch1, "Free Mode");
			this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
			this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
			this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.guna2Panel1.Controls.Add(this.guna2Button6);
			this.guna2Panel1.Controls.Add(this.guna2Button5);
			this.guna2Panel1.Controls.Add(this.guna2Button1);
			this.guna2Panel1.Controls.Add(this.guna2Button2);
			this.guna2Panel1.Controls.Add(this.guna2Button3);
			this.guna2Panel1.Controls.Add(this.guna2Button4);
			this.guna2Panel1.Controls.Add(this.lbl);
			this.guna2Panel1.Location = new System.Drawing.Point(62, 85);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(577, 274);
			this.guna2Panel1.TabIndex = 14;
			// 
			// guna2ResizeForm1
			// 
			this.guna2ResizeForm1.TargetForm = this;
			// 
			// Showcase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.ClientSize = new System.Drawing.Size(701, 408);
			this.Controls.Add(this.guna2ToggleSwitch1);
			this.Controls.Add(this.guna2ControlBox2);
			this.Controls.Add(this.guna2ControlBox1);
			this.Controls.Add(this.guna2Panel1);
			this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Showcase";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Themer";
			this.Load += new System.EventHandler(this.Showcase_Load);
			this.guna2Panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbl;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
		private Guna.UI2.WinForms.Guna2Button guna2Button2;
		private Guna.UI2.WinForms.Guna2Button guna2Button3;
		private Guna.UI2.WinForms.Guna2Button guna2Button4;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
		private Guna.UI2.WinForms.Guna2Button guna2Button5;
		private Guna.UI2.WinForms.Guna2Button guna2Button6;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
		private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
	}
}

