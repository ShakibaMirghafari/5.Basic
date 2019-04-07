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
	public partial class Timer : Form
	{
		public Timer()
		{
			InitializeComponent();
		}
		int minute = 0;
		int second = 0;
		private void Timer_Load(object sender, EventArgs e)
		{
			//minute = 0;
			//second = 0;
		}
		private void titleTimer_Tick(object sender, EventArgs e)
		{
			//int minute = 0;
			//int second = 0;

			titleLable.Text = $" { minute } : { second } ";
			second++;

			if (second>60)
			{
				second = 0;
				minute ++;

				if (minute>60)
				{
					second = 0;
					minute = 0;
				}
			}
			

		}

		
	}
}
