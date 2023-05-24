namespace LogIn_page
{
	partial class Form1
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
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.linkLabel2);
			this.groupBox1.Controls.Add(this.linkLabel1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(418, 73);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(303, 362);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Well Come Back ";
			this.groupBox1.UseWaitCursor = true;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// button1
			// 
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.BackColor = System.Drawing.Color.Fuchsia;
			this.button1.Cursor = System.Windows.Forms.Cursors.Default;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(41, 80);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.button2.Location = new System.Drawing.Point(152, 80);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(122, 33);
			this.button2.TabIndex = 0;
			this.button2.Text = "SignUp";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.textBox1.ForeColor = System.Drawing.Color.Silver;
			this.textBox1.Location = new System.Drawing.Point(41, 142);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(233, 29);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "Email Address...";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.ForeColor = System.Drawing.Color.Silver;
			this.textBox2.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
			this.textBox2.Location = new System.Drawing.Point(41, 194);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(233, 29);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "Password...";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 326);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "  Not a member ?";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkColor = System.Drawing.Color.Magenta;
			this.linkLabel1.Location = new System.Drawing.Point(38, 235);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(118, 16);
			this.linkLabel1.TabIndex = 3;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Forgot password ?";
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.LinkColor = System.Drawing.Color.Magenta;
			this.linkLabel2.Location = new System.Drawing.Point(152, 326);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(79, 16);
			this.linkLabel2.TabIndex = 3;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "SignUp now";
			this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Fuchsia;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.label2.Font = new System.Drawing.Font("Footlight MT Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(60, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 30);
			this.label2.TabIndex = 2;
			this.label2.Text = "Login Form";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Fuchsia;
			this.button3.Cursor = System.Windows.Forms.Cursors.Default;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(41, 269);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(233, 33);
			this.button3.TabIndex = 0;
			this.button3.Text = "Login";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::LogIn_page.Properties.Resources.walpaper;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1053, 567);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button3;
	}
}

