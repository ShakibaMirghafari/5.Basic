using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace جلسه_پنجم
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void exitAltToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Close();
			//System.Windows.Forms.Application.Exit();
			System.Windows.Forms.DialogResult result =
				System.Windows.Forms.MessageBox.Show
				(text: "آیا به خروج از برنامه اطمینان دارید؟",
				caption: "سوال",
				buttons: MessageBoxButtons.YesNo,
				icon: MessageBoxIcon.Question,
				defaultButton: MessageBoxDefaultButton.Button2,
				options: MessageBoxOptions.RtlReading | 
				MessageBoxOptions.RightAlign
				);
			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}

		}
	}
}
