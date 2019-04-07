namespace جلسه_پنجم
{
	partial class Timer
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
			this.components = new System.ComponentModel.Container();
			this.titleLable = new System.Windows.Forms.Label();
			this.titleTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// titleLable
			// 
			this.titleLable.BackColor = System.Drawing.Color.Coral;
			this.titleLable.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLable.Location = new System.Drawing.Point(35, 30);
			this.titleLable.Name = "titleLable";
			this.titleLable.Size = new System.Drawing.Size(521, 358);
			this.titleLable.TabIndex = 0;
			this.titleLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// titleTimer
			// 
			this.titleTimer.Enabled = true;
			this.titleTimer.Interval = 1000;
			this.titleTimer.Tick += new System.EventHandler(this.titleTimer_Tick);
			// 
			// Timer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 428);
			this.Controls.Add(this.titleLable);
			this.Name = "Timer";
			this.Text = "Timer";
			this.Load += new System.EventHandler(this.Timer_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label titleLable;
		private System.Windows.Forms.Timer titleTimer;
	}
}