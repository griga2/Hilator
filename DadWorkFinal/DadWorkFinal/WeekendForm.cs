/*
 * Created by SharpDevelop.
 * User: l-adm
 * Date: 27.09.2019
 * Time: 23:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace DadWorkFinal
{
	/// <summary>
	/// Description of WeekendForm.
	/// </summary>
	public partial class WeekendForm : Form
	{
		public WeekendForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void GoSchuduleFormButtunClick(object sender, EventArgs e)
		{
			this.Hide();
			SheduleForm ScheduleForm=new SheduleForm ();
			ScheduleForm.Show();
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void ExitMainButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void GoMainFormButtonClick(object sender, EventArgs e)
		{
			this.Hide();
			MainForm MainForm= new MainForm();
			MainForm.Show();
		}
	}
}
