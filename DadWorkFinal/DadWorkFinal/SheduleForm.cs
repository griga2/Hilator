/*
 * Created by SharpDevelop.
 * User: l-adm
 * Date: 27.09.2019
 * Time: 23:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DadWorkFinal
{
	/// <summary>
	/// Description of SheduleForm.
	/// </summary>
	public partial class SheduleForm : Form
	{
		public SheduleForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void ExitMainButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void GoMainFormButtunClick(object sender, EventArgs e)
		{
			this.Hide();
			MainForm MainForm= new MainForm();
			MainForm.Show();
		}
		
		void GoWeekendFormButtonClick(object sender, EventArgs e)
		{
			this.Hide();
			WeekendForm WeekendForm= new WeekendForm();
			WeekendForm.Show();
		}
	}
}
