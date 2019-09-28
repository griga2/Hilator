/*
 * Created by SharpDevelop.
 * User: l-adm
 * Date: 27.09.2019
 * Time: 23:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DadWorkFinal
{
	partial class SheduleForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.ExitMainButton = new System.Windows.Forms.Button();
			this.GoWeekendFormButton = new System.Windows.Forms.Button();
			this.GoMainFormButtun = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.panel3.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Location = new System.Drawing.Point(12, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1146, 510);
			this.panel1.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.ExitMainButton);
			this.panel3.Controls.Add(this.GoWeekendFormButton);
			this.panel3.Controls.Add(this.GoMainFormButtun);
			this.panel3.Controls.Add(this.ClearButton);
			this.panel3.Location = new System.Drawing.Point(1164, 64);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(268, 510);
			this.panel3.TabIndex = 5;
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
			// GoMainFormButtun
			// 
			this.GoMainFormButtun.BackColor = System.Drawing.SystemColors.HotTrack;
			this.GoMainFormButtun.ForeColor = System.Drawing.SystemColors.Info;
			this.GoMainFormButtun.Location = new System.Drawing.Point(44, 3);
			this.GoMainFormButtun.Name = "GoMainFormButtun";
			this.GoMainFormButtun.Size = new System.Drawing.Size(194, 58);
			this.GoMainFormButtun.TabIndex = 2;
			this.GoMainFormButtun.Text = "Edit Worker Date";
			this.GoMainFormButtun.UseVisualStyleBackColor = false;
			this.GoMainFormButtun.Click += new System.EventHandler(this.GoMainFormButtunClick);
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
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.functionToolStripMenuItem,
									this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1445, 24);
			this.menuStrip1.TabIndex = 7;
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
			// SheduleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1445, 637);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Name = "SheduleForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SheduleForm";
			this.panel3.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button GoMainFormButtun;
		private System.Windows.Forms.Button GoWeekendFormButton;
		private System.Windows.Forms.Button ExitMainButton;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
	}
}
