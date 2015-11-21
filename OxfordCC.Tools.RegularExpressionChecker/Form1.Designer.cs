namespace OxfordCC.Tools.RegularExpressionChecker
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
			this.lblPattern = new System.Windows.Forms.Label();
			this.txtPattern = new System.Windows.Forms.TextBox();
			this.lblText = new System.Windows.Forms.Label();
			this.txtText = new System.Windows.Forms.TextBox();
			this.btnGO = new System.Windows.Forms.Button();
			this.chkSuccess = new System.Windows.Forms.CheckBox();
			this.lvwGroups = new System.Windows.Forms.ListView();
			this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblGroups = new System.Windows.Forms.Label();
			this.lblSuccess = new System.Windows.Forms.Label();
			this.lblCaptures = new System.Windows.Forms.Label();
			this.lvwCaptures = new System.Windows.Forms.ListView();
			this.Capture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
			this.rbSingleLine = new System.Windows.Forms.RadioButton();
			this.rbMultiLine = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// lblPattern
			// 
			this.lblPattern.AutoSize = true;
			this.lblPattern.Location = new System.Drawing.Point(13, 13);
			this.lblPattern.Name = "lblPattern";
			this.lblPattern.Size = new System.Drawing.Size(41, 13);
			this.lblPattern.TabIndex = 0;
			this.lblPattern.Text = "Pattern";
			// 
			// txtPattern
			// 
			this.txtPattern.Location = new System.Drawing.Point(83, 13);
			this.txtPattern.Name = "txtPattern";
			this.txtPattern.Size = new System.Drawing.Size(671, 20);
			this.txtPattern.TabIndex = 1;
			// 
			// lblText
			// 
			this.lblText.AutoSize = true;
			this.lblText.Location = new System.Drawing.Point(16, 46);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(28, 13);
			this.lblText.TabIndex = 2;
			this.lblText.Text = "Text";
			// 
			// txtText
			// 
			this.txtText.Location = new System.Drawing.Point(83, 46);
			this.txtText.Multiline = true;
			this.txtText.Name = "txtText";
			this.txtText.Size = new System.Drawing.Size(671, 94);
			this.txtText.TabIndex = 3;
			// 
			// btnGO
			// 
			this.btnGO.Location = new System.Drawing.Point(83, 226);
			this.btnGO.Name = "btnGO";
			this.btnGO.Size = new System.Drawing.Size(671, 23);
			this.btnGO.TabIndex = 4;
			this.btnGO.Text = "GO";
			this.btnGO.UseVisualStyleBackColor = true;
			this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
			// 
			// chkSuccess
			// 
			this.chkSuccess.AutoSize = true;
			this.chkSuccess.Location = new System.Drawing.Point(83, 269);
			this.chkSuccess.Name = "chkSuccess";
			this.chkSuccess.Size = new System.Drawing.Size(15, 14);
			this.chkSuccess.TabIndex = 5;
			this.chkSuccess.UseVisualStyleBackColor = true;
			// 
			// lvwGroups
			// 
			this.lvwGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Group});
			this.lvwGroups.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lvwGroups.Location = new System.Drawing.Point(83, 299);
			this.lvwGroups.Name = "lvwGroups";
			this.lvwGroups.Size = new System.Drawing.Size(671, 116);
			this.lvwGroups.TabIndex = 6;
			this.lvwGroups.UseCompatibleStateImageBehavior = false;
			this.lvwGroups.View = System.Windows.Forms.View.Details;
			// 
			// Group
			// 
			this.Group.Text = "Group";
			this.Group.Width = 1000;
			// 
			// lblGroups
			// 
			this.lblGroups.AutoSize = true;
			this.lblGroups.Location = new System.Drawing.Point(16, 299);
			this.lblGroups.Name = "lblGroups";
			this.lblGroups.Size = new System.Drawing.Size(41, 13);
			this.lblGroups.TabIndex = 7;
			this.lblGroups.Text = "Groups";
			// 
			// lblSuccess
			// 
			this.lblSuccess.AutoSize = true;
			this.lblSuccess.Location = new System.Drawing.Point(16, 269);
			this.lblSuccess.Name = "lblSuccess";
			this.lblSuccess.Size = new System.Drawing.Size(48, 13);
			this.lblSuccess.TabIndex = 8;
			this.lblSuccess.Text = "Success";
			// 
			// lblCaptures
			// 
			this.lblCaptures.AutoSize = true;
			this.lblCaptures.Location = new System.Drawing.Point(16, 426);
			this.lblCaptures.Name = "lblCaptures";
			this.lblCaptures.Size = new System.Drawing.Size(49, 13);
			this.lblCaptures.TabIndex = 9;
			this.lblCaptures.Text = "Captures";
			// 
			// lvwCaptures
			// 
			this.lvwCaptures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Capture});
			this.lvwCaptures.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lvwCaptures.Location = new System.Drawing.Point(83, 426);
			this.lvwCaptures.Name = "lvwCaptures";
			this.lvwCaptures.Size = new System.Drawing.Size(671, 113);
			this.lvwCaptures.TabIndex = 10;
			this.lvwCaptures.UseCompatibleStateImageBehavior = false;
			this.lvwCaptures.View = System.Windows.Forms.View.Details;
			// 
			// Capture
			// 
			this.Capture.Text = "Capture";
			this.Capture.Width = 1000;
			// 
			// chkCaseSensitive
			// 
			this.chkCaseSensitive.AutoSize = true;
			this.chkCaseSensitive.Checked = true;
			this.chkCaseSensitive.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCaseSensitive.Location = new System.Drawing.Point(83, 159);
			this.chkCaseSensitive.Name = "chkCaseSensitive";
			this.chkCaseSensitive.Size = new System.Drawing.Size(96, 17);
			this.chkCaseSensitive.TabIndex = 11;
			this.chkCaseSensitive.Text = "Case Sensitive";
			this.chkCaseSensitive.UseVisualStyleBackColor = true;
			// 
			// rbSingleLine
			// 
			this.rbSingleLine.AutoSize = true;
			this.rbSingleLine.Checked = true;
			this.rbSingleLine.Location = new System.Drawing.Point(677, 158);
			this.rbSingleLine.Name = "rbSingleLine";
			this.rbSingleLine.Size = new System.Drawing.Size(77, 17);
			this.rbSingleLine.TabIndex = 12;
			this.rbSingleLine.TabStop = true;
			this.rbSingleLine.Text = "Single Line";
			this.rbSingleLine.UseVisualStyleBackColor = true;
			// 
			// rbMultiLine
			// 
			this.rbMultiLine.AutoSize = true;
			this.rbMultiLine.Location = new System.Drawing.Point(677, 181);
			this.rbMultiLine.Name = "rbMultiLine";
			this.rbMultiLine.Size = new System.Drawing.Size(70, 17);
			this.rbMultiLine.TabIndex = 12;
			this.rbMultiLine.Text = "Multi Line";
			this.rbMultiLine.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.rbMultiLine);
			this.Controls.Add(this.rbSingleLine);
			this.Controls.Add(this.chkCaseSensitive);
			this.Controls.Add(this.lvwCaptures);
			this.Controls.Add(this.lblCaptures);
			this.Controls.Add(this.lblSuccess);
			this.Controls.Add(this.lblGroups);
			this.Controls.Add(this.lvwGroups);
			this.Controls.Add(this.chkSuccess);
			this.Controls.Add(this.btnGO);
			this.Controls.Add(this.txtText);
			this.Controls.Add(this.lblText);
			this.Controls.Add(this.txtPattern);
			this.Controls.Add(this.lblPattern);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegularExpressionChecker";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPattern;
		private System.Windows.Forms.TextBox txtPattern;
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.TextBox txtText;
		private System.Windows.Forms.Button btnGO;
		private System.Windows.Forms.CheckBox chkSuccess;
		private System.Windows.Forms.ListView lvwGroups;
		private System.Windows.Forms.Label lblGroups;
		private System.Windows.Forms.Label lblSuccess;
		private System.Windows.Forms.Label lblCaptures;
		private System.Windows.Forms.ListView lvwCaptures;
		private System.Windows.Forms.ColumnHeader Group;
		private System.Windows.Forms.ColumnHeader Capture;
		private System.Windows.Forms.CheckBox chkCaseSensitive;
		private System.Windows.Forms.RadioButton rbSingleLine;
		private System.Windows.Forms.RadioButton rbMultiLine;
	}
}

