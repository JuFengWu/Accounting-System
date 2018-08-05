namespace Accounting
{
	partial class Form_Main
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
            this.button_enter_calendar = new System.Windows.Forms.Button();
            this.MyMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label_date = new System.Windows.Forms.Label();
            this.textBox_price_calendar = new System.Windows.Forms.TextBox();
            this.label_price_calendar = new System.Windows.Forms.Label();
            this.MyListView = new System.Windows.Forms.ListView();
            this.label_item = new System.Windows.Forms.Label();
            this.textBox_item = new System.Windows.Forms.TextBox();
            this.label_price_listview = new System.Windows.Forms.Label();
            this.textBox_price_listview = new System.Windows.Forms.TextBox();
            this.button_addList = new System.Windows.Forms.Button();
            this.button_delete_list = new System.Windows.Forms.Button();
            this.button_SaveFile = new System.Windows.Forms.Button();
            this.label_calendar_Price = new System.Windows.Forms.Label();
            this.label_Items_Price = new System.Windows.Forms.Label();
            this.label_Totoal_Calendar = new System.Windows.Forms.Label();
            this.label_Items_Total = new System.Windows.Forms.Label();
            this.label_TotalPrice = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.label_Choose_Date = new System.Windows.Forms.Label();
            this.My_menuStrip = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.My_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_enter_calendar
            // 
            this.button_enter_calendar.Location = new System.Drawing.Point(81, 137);
            this.button_enter_calendar.Name = "button_enter_calendar";
            this.button_enter_calendar.Size = new System.Drawing.Size(108, 21);
            this.button_enter_calendar.TabIndex = 0;
            this.button_enter_calendar.Text = "Enter to Calendar";
            this.button_enter_calendar.UseVisualStyleBackColor = true;
            this.button_enter_calendar.Click += new System.EventHandler(this.button_enter_calendar_Click);
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
            // textBox_item
            // 
            this.textBox_item.Location = new System.Drawing.Point(391, 46);
            this.textBox_item.Name = "textBox_item";
            this.textBox_item.Size = new System.Drawing.Size(100, 22);
            this.textBox_item.TabIndex = 9;
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
            // textBox_price_listview
            // 
            this.textBox_price_listview.Location = new System.Drawing.Point(391, 82);
            this.textBox_price_listview.Name = "textBox_price_listview";
            this.textBox_price_listview.Size = new System.Drawing.Size(100, 22);
            this.textBox_price_listview.TabIndex = 11;
            // 
            // button_addList
            // 
            this.button_addList.Location = new System.Drawing.Point(323, 137);
            this.button_addList.Name = "button_addList";
            this.button_addList.Size = new System.Drawing.Size(99, 23);
            this.button_addList.TabIndex = 12;
            this.button_addList.Text = "Add/modify";
            this.button_addList.UseVisualStyleBackColor = true;
            this.button_addList.Click += new System.EventHandler(this.button_addList_Click);
            // 
            // button_delete_list
            // 
            this.button_delete_list.Location = new System.Drawing.Point(469, 135);
            this.button_delete_list.Name = "button_delete_list";
            this.button_delete_list.Size = new System.Drawing.Size(75, 23);
            this.button_delete_list.TabIndex = 14;
            this.button_delete_list.Text = "Delete";
            this.button_delete_list.UseVisualStyleBackColor = true;
            this.button_delete_list.Click += new System.EventHandler(this.button_delete_list_Click);
            // 
            // button_SaveFile
            // 
            this.button_SaveFile.Location = new System.Drawing.Point(229, 491);
            this.button_SaveFile.Name = "button_SaveFile";
            this.button_SaveFile.Size = new System.Drawing.Size(100, 23);
            this.button_SaveFile.TabIndex = 15;
            this.button_SaveFile.Text = "Save File";
            this.button_SaveFile.UseVisualStyleBackColor = true;
            this.button_SaveFile.Click += new System.EventHandler(this.button_SaveFile_Click);
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
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "files";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 526);
            this.Controls.Add(this.label_Choose_Date);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.label_TotalPrice);
            this.Controls.Add(this.label_Items_Total);
            this.Controls.Add(this.label_Totoal_Calendar);
            this.Controls.Add(this.label_Items_Price);
            this.Controls.Add(this.label_calendar_Price);
            this.Controls.Add(this.button_SaveFile);
            this.Controls.Add(this.button_delete_list);
            this.Controls.Add(this.button_addList);
            this.Controls.Add(this.textBox_price_listview);
            this.Controls.Add(this.label_price_listview);
            this.Controls.Add(this.textBox_item);
            this.Controls.Add(this.label_item);
            this.Controls.Add(this.MyListView);
            this.Controls.Add(this.label_price_calendar);
            this.Controls.Add(this.textBox_price_calendar);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.MyMonthCalendar);
            this.Controls.Add(this.button_enter_calendar);
            this.Controls.Add(this.My_menuStrip);
            this.MainMenuStrip = this.My_menuStrip;
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.My_menuStrip.ResumeLayout(false);
            this.My_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_enter_calendar;
		private System.Windows.Forms.MonthCalendar MyMonthCalendar;
		private System.Windows.Forms.Label label_date;
		private System.Windows.Forms.TextBox textBox_price_calendar;
		private System.Windows.Forms.Label label_price_calendar;
		private System.Windows.Forms.ListView MyListView;
		private System.Windows.Forms.Label label_item;
		private System.Windows.Forms.TextBox textBox_item;
		private System.Windows.Forms.Label label_price_listview;
		private System.Windows.Forms.TextBox textBox_price_listview;
		private System.Windows.Forms.Button button_addList;
		private System.Windows.Forms.Button button_delete_list;
		private System.Windows.Forms.Button button_SaveFile;
		private System.Windows.Forms.Label label_calendar_Price;
		private System.Windows.Forms.Label label_Items_Price;
		private System.Windows.Forms.Label label_Totoal_Calendar;
		private System.Windows.Forms.Label label_Items_Total;
		private System.Windows.Forms.Label label_TotalPrice;
		private System.Windows.Forms.Label label_Total;
		private System.Windows.Forms.Label label_Choose_Date;
		private System.Windows.Forms.MenuStrip My_menuStrip;
		private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
	}
}

