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
	public partial class outLook : Form
	{
		public outLook()
		{
			InitializeComponent();
		}

		int currentLeftPanel;
		private void leftPanel_DoubleClick(object sender, EventArgs e)
		{
			
			if (leftPanel.Width != 10)
				{
					currentLeftPanel = leftPanel.Width;
					leftPanel.Width = 10;
				}
				else
				{
					leftPanel.Width = currentLeftPanel;
				}
		}

	}
}
