namespace WinFormAppDotNet8SQLite
{
	partial class SignIn
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 24F);
			label1.Location = new Point(165, 171);
			label1.Name = "label1";
			label1.Size = new Size(103, 45);
			label1.TabIndex = 0;
			label1.Text = "Email:";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 24F);
			label2.Location = new Point(165, 235);
			label2.Name = "label2";
			label2.Size = new Size(153, 45);
			label2.TabIndex = 1;
			label2.Text = "Password";
			// 
			// textBox1
			// 
			textBox1.Anchor = AnchorStyles.None;
			textBox1.Font = new Font("Segoe UI", 24F);
			textBox1.Location = new Point(335, 168);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(300, 50);
			textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			textBox2.Anchor = AnchorStyles.None;
			textBox2.Font = new Font("Segoe UI", 24F);
			textBox2.Location = new Point(335, 232);
			textBox2.Name = "textBox2";
			textBox2.PasswordChar = '*';
			textBox2.Size = new Size(300, 50);
			textBox2.TabIndex = 3;
			// 
			// SignIn
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "SignIn";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			Load += SignIn_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox textBox1;
		private TextBox textBox2;
	}
}
