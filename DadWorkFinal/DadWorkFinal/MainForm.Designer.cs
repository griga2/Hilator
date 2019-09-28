/*
 * Created by SharpDevelop.
 * User: l-adm
 * Date: 27.09.2019
 * Time: 20:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DadWorkFinal
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SaveVacationDateButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.WorkerInitionsRichTextBox = new System.Windows.Forms.RichTextBox();
			this.GoSchuduleFormButtun = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.ExitMainButton = new System.Windows.Forms.Button();
			this.GoWeekendFormButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.functionToolStripMenuItem,
									this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1441, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// functionToolStripMenuItem
			// 
			this.functionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.exitToolStripMenuItem});
			this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
			this.functionToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.functionToolStripMenuItem.Text = "Function";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
			this.toolStripMenuItem1.Text = "?";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(12, 94);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1144, 510);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panel2.Controls.Add(this.SaveVacationDateButton);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.dateTimePicker2);
			this.panel2.Controls.Add(this.dateTimePicker1);
			this.panel2.Controls.Add(this.WorkerInitionsRichTextBox);
			this.panel2.Location = new System.Drawing.Point(16, 14);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(495, 275);
			this.panel2.TabIndex = 0;
			// 
			// SaveVacationDateButton
			// 
			this.SaveVacationDateButton.Location = new System.Drawing.Point(147, 79);
			this.SaveVacationDateButton.Name = "SaveVacationDateButton";
			this.SaveVacationDateButton.Size = new System.Drawing.Size(61, 55);
			this.SaveVacationDateButton.TabIndex = 5;
			this.SaveVacationDateButton.Text = "Save Date";
			this.SaveVacationDateButton.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "And of vacation";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Start of vacation";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(3, 114);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(121, 20);
			this.dateTimePicker2.TabIndex = 2;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(3, 79);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
			this.dateTimePicker1.TabIndex = 1;
			// 
			// WorkerInitionsRichTextBox
			// 
			this.WorkerInitionsRichTextBox.Location = new System.Drawing.Point(3, 3);
			this.WorkerInitionsRichTextBox.Name = "WorkerInitionsRichTextBox";
			this.WorkerInitionsRichTextBox.Size = new System.Drawing.Size(205, 60);
			this.WorkerInitionsRichTextBox.TabIndex = 0;
			this.WorkerInitionsRichTextBox.Text = "";
			// 
			// GoSchuduleFormButtun
			// 
			this.GoSchuduleFormButtun.BackColor = System.Drawing.SystemColors.HotTrack;
			this.GoSchuduleFormButtun.ForeColor = System.Drawing.SystemColors.Info;
			this.GoSchuduleFormButtun.Location = new System.Drawing.Point(44, 3);
			this.GoSchuduleFormButtun.Name = "GoSchuduleFormButtun";
			this.GoSchuduleFormButtun.Size = new System.Drawing.Size(194, 58);
			this.GoSchuduleFormButtun.TabIndex = 2;
			this.GoSchuduleFormButtun.Text = "Made schedule";
			this.GoSchuduleFormButtun.UseVisualStyleBackColor = false;
			this.GoSchuduleFormButtun.Click += new System.EventHandler(this.GoSchuduleFormButtunClick);
			// 
			// ClearButton
			// 
			this.ClearButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.ClearButton.ForeColor = System.Drawing.SystemColors.Info;
			this.ClearButton.Location = new System.Drawing.Point(44, 385);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(194, 58);
			this.ClearButton.TabIndex = 3;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = false;
			this.ClearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.ExitMainButton);
			this.panel3.Controls.Add(this.GoWeekendFormButton);
			this.panel3.Controls.Add(this.GoSchuduleFormButtun);
			this.panel3.Controls.Add(this.ClearButton);
			this.panel3.Location = new System.Drawing.Point(1162, 94);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(268, 510);
			this.panel3.TabIndex = 4;
			// 
			// ExitMainButton
			// 
			this.ExitMainButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.ExitMainButton.ForeColor = System.Drawing.SystemColors.Info;
			this.ExitMainButton.Location = new System.Drawing.Point(44, 449);
			this.ExitMainButton.Name = "ExitMainButton";
			this.ExitMainButton.Size = new System.Drawing.Size(194, 58);
			this.ExitMainButton.TabIndex = 5;
			this.ExitMainButton.Text = "Exit";
			this.ExitMainButton.UseVisualStyleBackColor = false;
			this.ExitMainButton.Click += new System.EventHandler(this.ExitMainButtonClick);
			// 
			// GoWeekendFormButton
			// 
			this.GoWeekendFormButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.GoWeekendFormButton.ForeColor = System.Drawing.SystemColors.Info;
			this.GoWeekendFormButton.Location = new System.Drawing.Point(44, 67);
			this.GoWeekendFormButton.Name = "GoWeekendFormButton";
			this.GoWeekendFormButton.Size = new System.Drawing.Size(194, 58);
			this.GoWeekendFormButton.TabIndex = 4;
			this.GoWeekendFormButton.Text = "Weekend";
			this.GoWeekendFormButton.UseVisualStyleBackColor = false;
			this.GoWeekendFormButton.Click += new System.EventHandler(this.GoWeekendFormButtonClick);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(0, 0);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 23);
			this.ExitButton.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1441, 612);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.HelpButton = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DadWorkFinal";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button ExitMainButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button GoWeekendFormButton;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button SaveVacationDateButton;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button GoSchuduleFormButtun;
		private System.Windows.Forms.RichTextBox WorkerInitionsRichTextBox;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
