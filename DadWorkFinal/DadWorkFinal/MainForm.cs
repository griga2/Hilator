/*
 * Created by SharpDevelop.
 * User: l-adm
 * Date: 27.09.2019
 * Time: 20:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DadWorkFinal
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	
		void GoSchuduleFormButtunClick(object sender, EventArgs e)
		{
			this.Hide();
			SheduleForm ScheduleForm=new SheduleForm ();
			ScheduleForm.Show();
		}
		
		void GoWeekendFormButtonClick(object sender, EventArgs e)
		{
			this.Hide();
			WeekendForm WeekendForm= new WeekendForm();
			WeekendForm.Show();
		}
		
		void ExitMainButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void ClearButtonClick(object sender, EventArgs e)
		{
			WorkerInitionsRichTextBox.Clear();
		}
	}
}
