namespace Accounting
{
	partial class FormMain
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
		/// 修改這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
            this.ButtonEnterCalendar = new System.Windows.Forms.Button();
            this.MyMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label_date = new System.Windows.Forms.Label();
            this.textBox_price_calendar = new System.Windows.Forms.TextBox();
            this.label_price_calendar = new System.Windows.Forms.Label();
            this.MyListView = new System.Windows.Forms.ListView();
            this.label_item = new System.Windows.Forms.Label();
            this.textBox_item_name = new System.Windows.Forms.TextBox();
            this.label_price_listview = new System.Windows.Forms.Label();
            this.textBox_item_price = new System.Windows.Forms.TextBox();
            this.ButtonAddList = new System.Windows.Forms.Button();
            this.ButtonDeleteList = new System.Windows.Forms.Button();
            this.ButtonSaveFile = new System.Windows.Forms.Button();
            this.label_calendar_Price = new System.Windows.Forms.Label();
            this.label_Items_Price = new System.Windows.Forms.Label();
            this.label_Totoal_Calendar = new System.Windows.Forms.Label();
            this.label_Items_Total = new System.Windows.Forms.Label();
            this.label_TotalPrice = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.label_Choose_Date = new System.Windows.Forms.Label();
            this.My_menuStrip = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonCheckSaveToExcel = new System.Windows.Forms.Button();
            this.My_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonEnterCalendar
            // 
            this.ButtonEnterCalendar.Location = new System.Drawing.Point(81, 137);
            this.ButtonEnterCalendar.Name = "ButtonEnterCalendar";
            this.ButtonEnterCalendar.Size = new System.Drawing.Size(108, 21);
            this.ButtonEnterCalendar.TabIndex = 0;
            this.ButtonEnterCalendar.Text = "Enter to Calendar";
            this.ButtonEnterCalendar.UseVisualStyleBackColor = true;
            this.ButtonEnterCalendar.Click += new System.EventHandler(this.ButtonEnterCalendarClick);
            // 
            // MyMonthCalendar
            // 
            this.MyMonthCalendar.Location = new System.Drawing.Point(40, 185);
            this.MyMonthCalendar.MaxSelectionCount = 1;
            this.MyMonthCalendar.Name = "MyMonthCalendar";
            this.MyMonthCalendar.TabIndex = 2;
            this.MyMonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateSelected);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(55, 49);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(32, 12);
            this.label_date.TabIndex = 3;
            this.label_date.Text = "Date :";
            // 
            // textBox_price_calendar
            // 
            this.textBox_price_calendar.Location = new System.Drawing.Point(102, 85);
            this.textBox_price_calendar.Name = "textBox_price_calendar";
            this.textBox_price_calendar.Size = new System.Drawing.Size(100, 22);
            this.textBox_price_calendar.TabIndex = 5;
            this.textBox_price_calendar.Text = "0";
            // 
            // label_price_calendar
            // 
            this.label_price_calendar.AutoSize = true;
            this.label_price_calendar.Location = new System.Drawing.Point(54, 88);
            this.label_price_calendar.Name = "label_price_calendar";
            this.label_price_calendar.Size = new System.Drawing.Size(31, 12);
            this.label_price_calendar.TabIndex = 6;
            this.label_price_calendar.Text = "Price:";
            // 
            // MyListView
            // 
            this.MyListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.MyListView.Location = new System.Drawing.Point(323, 185);
            this.MyListView.Name = "MyListView";
            this.MyListView.Size = new System.Drawing.Size(243, 171);
            this.MyListView.TabIndex = 7;
            this.MyListView.UseCompatibleStateImageBehavior = false;
            this.MyListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.MyListView_ItemSelectionChanged);
            // 
            // label_item
            // 
            this.label_item.AutoSize = true;
            this.label_item.Location = new System.Drawing.Point(343, 49);
            this.label_item.Name = "label_item";
            this.label_item.Size = new System.Drawing.Size(32, 12);
            this.label_item.TabIndex = 8;
            this.label_item.Text = "Item :";
            // 
            // textBox_item_name
            // 
            this.textBox_item_name.Location = new System.Drawing.Point(391, 46);
            this.textBox_item_name.Name = "textBox_item_name";
            this.textBox_item_name.Size = new System.Drawing.Size(100, 22);
            this.textBox_item_name.TabIndex = 9;
            // 
            // label_price_listview
            // 
            this.label_price_listview.AutoSize = true;
            this.label_price_listview.Location = new System.Drawing.Point(342, 85);
            this.label_price_listview.Name = "label_price_listview";
            this.label_price_listview.Size = new System.Drawing.Size(31, 12);
            this.label_price_listview.TabIndex = 10;
            this.label_price_listview.Text = "Price:";
            // 
            // textBox_item_price
            // 
            this.textBox_item_price.Location = new System.Drawing.Point(391, 82);
            this.textBox_item_price.Name = "textBox_item_price";
            this.textBox_item_price.Size = new System.Drawing.Size(100, 22);
            this.textBox_item_price.TabIndex = 11;
            // 
            // ButtonAddList
            // 
            this.ButtonAddList.Location = new System.Drawing.Point(323, 137);
            this.ButtonAddList.Name = "ButtonAddList";
            this.ButtonAddList.Size = new System.Drawing.Size(99, 23);
            this.ButtonAddList.TabIndex = 12;
            this.ButtonAddList.Text = "Add/modify";
            this.ButtonAddList.UseVisualStyleBackColor = true;
            this.ButtonAddList.Click += new System.EventHandler(this.ButtonAddListClick);
            // 
            // ButtonDeleteList
            // 
            this.ButtonDeleteList.Location = new System.Drawing.Point(469, 135);
            this.ButtonDeleteList.Name = "ButtonDeleteList";
            this.ButtonDeleteList.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeleteList.TabIndex = 14;
            this.ButtonDeleteList.Text = "Delete";
            this.ButtonDeleteList.UseVisualStyleBackColor = true;
            this.ButtonDeleteList.Click += new System.EventHandler(this.ButtonDeleteListClick);
            // 
            // ButtonSaveFile
            // 
            this.ButtonSaveFile.Location = new System.Drawing.Point(111, 494);
            this.ButtonSaveFile.Name = "ButtonSaveFile";
            this.ButtonSaveFile.Size = new System.Drawing.Size(100, 23);
            this.ButtonSaveFile.TabIndex = 15;
            this.ButtonSaveFile.Text = "Save File";
            this.ButtonSaveFile.UseVisualStyleBackColor = true;
            this.ButtonSaveFile.Click += new System.EventHandler(this.ButtonSaveFileClick);
            // 
            // label_calendar_Price
            // 
            this.label_calendar_Price.AutoSize = true;
            this.label_calendar_Price.Location = new System.Drawing.Point(129, 390);
            this.label_calendar_Price.Name = "label_calendar_Price";
            this.label_calendar_Price.Size = new System.Drawing.Size(145, 12);
            this.label_calendar_Price.TabIndex = 16;
            this.label_calendar_Price.Text = "Current Calendar Total Price :";
            // 
            // label_Items_Price
            // 
            this.label_Items_Price.AutoSize = true;
            this.label_Items_Price.Location = new System.Drawing.Point(185, 424);
            this.label_Items_Price.Name = "label_Items_Price";
            this.label_Items_Price.Size = new System.Drawing.Size(89, 12);
            this.label_Items_Price.TabIndex = 17;
            this.label_Items_Price.Text = "Items Total Price :";
            // 
            // label_Totoal_Calendar
            // 
            this.label_Totoal_Calendar.AutoSize = true;
            this.label_Totoal_Calendar.Location = new System.Drawing.Point(289, 390);
            this.label_Totoal_Calendar.Name = "label_Totoal_Calendar";
            this.label_Totoal_Calendar.Size = new System.Drawing.Size(11, 12);
            this.label_Totoal_Calendar.TabIndex = 18;
            this.label_Totoal_Calendar.Text = "0";
            // 
            // label_Items_Total
            // 
            this.label_Items_Total.AutoSize = true;
            this.label_Items_Total.Location = new System.Drawing.Point(289, 424);
            this.label_Items_Total.Name = "label_Items_Total";
            this.label_Items_Total.Size = new System.Drawing.Size(11, 12);
            this.label_Items_Total.TabIndex = 19;
            this.label_Items_Total.Text = "0";
            // 
            // label_TotalPrice
            // 
            this.label_TotalPrice.AutoSize = true;
            this.label_TotalPrice.Location = new System.Drawing.Point(210, 454);
            this.label_TotalPrice.Name = "label_TotalPrice";
            this.label_TotalPrice.Size = new System.Drawing.Size(64, 12);
            this.label_TotalPrice.TabIndex = 20;
            this.label_TotalPrice.Text = "Totoal Price:";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(289, 454);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(11, 12);
            this.label_Total.TabIndex = 21;
            this.label_Total.Text = "0";
            // 
            // label_Choose_Date
            // 
            this.label_Choose_Date.AutoSize = true;
            this.label_Choose_Date.Location = new System.Drawing.Point(131, 50);
            this.label_Choose_Date.Name = "label_Choose_Date";
            this.label_Choose_Date.Size = new System.Drawing.Size(25, 12);
            this.label_Choose_Date.TabIndex = 22;
            this.label_Choose_Date.Text = "????";
            // 
            // My_menuStrip
            // 
            this.My_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem});
            this.My_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.My_menuStrip.Name = "My_menuStrip";
            this.My_menuStrip.Size = new System.Drawing.Size(581, 24);
            this.My_menuStrip.TabIndex = 23;
            this.My_menuStrip.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileToolStripMenuItem,
            this.SaveFileToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.filesToolStripMenuItem.Text = "files";
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenFileToolStripMenuItem.Text = "Open File";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItemClick);
            // 
            // SaveFileToolStripMenuItem
            // 
            this.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            this.SaveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveFileToolStripMenuItem.Text = "Save File";
            this.SaveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItemClick);
            // 
            // ButtonCheckSaveToExcel
            // 
            this.ButtonCheckSaveToExcel.Location = new System.Drawing.Point(347, 494);
            this.ButtonCheckSaveToExcel.Name = "ButtonCheckSaveToExcel";
            this.ButtonCheckSaveToExcel.Size = new System.Drawing.Size(133, 23);
            this.ButtonCheckSaveToExcel.TabIndex = 24;
            this.ButtonCheckSaveToExcel.Text = "Check and save to excel";
            this.ButtonCheckSaveToExcel.UseVisualStyleBackColor = true;
            this.ButtonCheckSaveToExcel.Click += new System.EventHandler(this.ButtonCheckSaveToExcelClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 556);
            this.Controls.Add(this.ButtonCheckSaveToExcel);
            this.Controls.Add(this.label_Choose_Date);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.label_TotalPrice);
            this.Controls.Add(this.label_Items_Total);
            this.Controls.Add(this.label_Totoal_Calendar);
            this.Controls.Add(this.label_Items_Price);
            this.Controls.Add(this.label_calendar_Price);
            this.Controls.Add(this.ButtonSaveFile);
            this.Controls.Add(this.ButtonDeleteList);
            this.Controls.Add(this.ButtonAddList);
            this.Controls.Add(this.textBox_item_price);
            this.Controls.Add(this.label_price_listview);
            this.Controls.Add(this.textBox_item_name);
            this.Controls.Add(this.label_item);
            this.Controls.Add(this.MyListView);
            this.Controls.Add(this.label_price_calendar);
            this.Controls.Add(this.textBox_price_calendar);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.MyMonthCalendar);
            this.Controls.Add(this.ButtonEnterCalendar);
            this.Controls.Add(this.My_menuStrip);
            this.MainMenuStrip = this.My_menuStrip;
            this.Name = "FormMain";
            this.Text = "Accounting";
            this.My_menuStrip.ResumeLayout(false);
            this.My_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonEnterCalendar;
		private System.Windows.Forms.MonthCalendar MyMonthCalendar;
		private System.Windows.Forms.Label label_date;
		private System.Windows.Forms.TextBox textBox_price_calendar;
		private System.Windows.Forms.Label label_price_calendar;
		private System.Windows.Forms.ListView MyListView;
		private System.Windows.Forms.Label label_item;
		private System.Windows.Forms.TextBox textBox_item_name;
		private System.Windows.Forms.Label label_price_listview;
		private System.Windows.Forms.TextBox textBox_item_price;
		private System.Windows.Forms.Button ButtonAddList;
		private System.Windows.Forms.Button ButtonDeleteList;
		private System.Windows.Forms.Button ButtonSaveFile;
		private System.Windows.Forms.Label label_calendar_Price;
		private System.Windows.Forms.Label label_Items_Price;
		private System.Windows.Forms.Label label_Totoal_Calendar;
		private System.Windows.Forms.Label label_Items_Total;
		private System.Windows.Forms.Label label_TotalPrice;
		private System.Windows.Forms.Label label_Total;
		private System.Windows.Forms.Label label_Choose_Date;
		private System.Windows.Forms.MenuStrip My_menuStrip;
		private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileToolStripMenuItem;
		private System.Windows.Forms.Button ButtonCheckSaveToExcel;
	}
}

