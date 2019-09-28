/*
 * Created by SharpDevelop.
 * User: l-adm
 * Date: 27.09.2019
 * Time: 23:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DadWorkFinal
{
	partial class WeekendForm
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
			this.GoMainFormButton = new System.Windows.Forms.Button();
			this.GoSchuduleFormButtun = new System.Windows.Forms.Button();
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
			this.panel1.Location = new System.Drawing.Point(12, 77);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1150, 510);
			this.panel1.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.ExitMainButton);
			this.panel3.Controls.Add(this.GoMainFormButton);
			this.panel3.Controls.Add(this.GoSchuduleFormButtun);
			this.panel3.Controls.Add(this.ClearButton);
			this.panel3.Location = new System.Drawing.Point(1168, 77);
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
			// GoMainFormButton
			// 
			this.GoMainFormButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.GoMainFormButton.ForeColor = System.Drawing.SystemColors.Info;
			this.GoMainFormButton.Location = new System.Drawing.Point(44, 3);
			this.GoMainFormButton.Name = "GoMainFormButton";
			this.GoMainFormButton.Size = new System.Drawing.Size(194, 58);
			this.GoMainFormButton.TabIndex = 4;
			this.GoMainFormButton.Text = "Edite Worker Date";
			this.GoMainFormButton.UseVisualStyleBackColor = false;
			this.GoMainFormButton.Click += new System.EventHandler(this.GoMainFormButtonClick);
			// 
			// GoSchuduleFormButtun
			// 
			this.GoSchuduleFormButtun.BackColor = System.Drawing.SystemColors.HotTrack;
			this.GoSchuduleFormButtun.ForeColor = System.Drawing.SystemColors.Info;
			this.GoSchuduleFormButtun.Location = new System.Drawing.Point(44, 67);
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
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.functionToolStripMenuItem,
									this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1448, 24);
			this.menuStrip1.TabIndex = 6;
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
			// WeekendForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1448, 607);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Name = "WeekendForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WeekendForm";
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
		private System.Windows.Forms.Button GoSchuduleFormButtun;
		private System.Windows.Forms.Button GoMainFormButton;
		private System.Windows.Forms.Button ExitMainButton;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
	}
}
