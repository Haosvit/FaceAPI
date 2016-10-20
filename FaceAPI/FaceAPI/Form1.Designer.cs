namespace FaceAPI
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
			this._btnDetect = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this._btnBrowse = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._lblGender = new System.Windows.Forms.Label();
			this._lblAge = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btnDetect
			// 
			this._btnDetect.Location = new System.Drawing.Point(12, 41);
			this._btnDetect.Name = "_btnDetect";
			this._btnDetect.Size = new System.Drawing.Size(116, 23);
			this._btnDetect.TabIndex = 0;
			this._btnDetect.Text = "Detect Face(s)";
			this._btnDetect.UseVisualStyleBackColor = true;
			this._btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// _btnBrowse
			// 
			this._btnBrowse.Location = new System.Drawing.Point(12, 12);
			this._btnBrowse.Name = "_btnBrowse";
			this._btnBrowse.Size = new System.Drawing.Size(75, 23);
			this._btnBrowse.TabIndex = 1;
			this._btnBrowse.Text = "Browse";
			this._btnBrowse.UseVisualStyleBackColor = true;
			this._btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(105, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(147, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Gender:";
			// 
			// _lblGender
			// 
			this._lblGender.AutoSize = true;
			this._lblGender.Location = new System.Drawing.Point(203, 46);
			this._lblGender.Name = "_lblGender";
			this._lblGender.Size = new System.Drawing.Size(10, 13);
			this._lblGender.TabIndex = 4;
			this._lblGender.Text = "-";
			// 
			// _lblAge
			// 
			this._lblAge.AutoSize = true;
			this._lblAge.Location = new System.Drawing.Point(299, 46);
			this._lblAge.Name = "_lblAge";
			this._lblAge.Size = new System.Drawing.Size(10, 13);
			this._lblAge.TabIndex = 5;
			this._lblAge.Text = "-";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(262, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Age:";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitContainer1.Location = new System.Drawing.Point(0, 81);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
			this.splitContainer1.Size = new System.Drawing.Size(730, 631);
			this.splitContainer1.SplitterDistance = 315;
			this.splitContainer1.TabIndex = 7;
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(730, 315);
			this.panel1.TabIndex = 4;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(730, 312);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(730, 712);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this._lblAge);
			this.Controls.Add(this.label5);
			this.Controls.Add(this._lblGender);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._btnBrowse);
			this.Controls.Add(this._btnDetect);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Demo Microsoft Face API";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _btnDetect;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button _btnBrowse;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label _lblGender;
		private System.Windows.Forms.Label _lblAge;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}

