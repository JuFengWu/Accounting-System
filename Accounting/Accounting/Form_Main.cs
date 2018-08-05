using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounting
{
	public partial class Form_Main : Form
	{
		public Form_Main()
		{
			InitializeComponent();

			label_Choose_Date.Text = MyMonthCalendar.TodayDate.ToString("yyyy/M/d");

			MyListView.GridLines = true;
			MyListView.FullRowSelect = true;

			MyListView.View = View.Details;
			MyListView.Scrollable = true;
			MyListView.MultiSelect = false;
			
			MyListView.Columns.Add("Additional Item", 150, HorizontalAlignment.Center);
			MyListView.Columns.Add("Price", 50, HorizontalAlignment.Center);

			Control.ShowDialogEvent += SetDialogShow;
            MyControl = new Control(CalendarControl, ItemsControl);
		}

		

		private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
		{
			
			label_Choose_Date.Text = MyMonthCalendar.SelectionStart.ToShortDateString();
			//double DayMoney=MyControl.Calendar.GetDateValue(label_Choose_Date.Text);
            double DayMoney = CalendarControl.GetMoney(label_Choose_Date.Text);
			if(DayMoney!=0)
			{
				textBox_price_calendar.Text = DayMoney.ToString();
			}
			else 
			{
				textBox_price_calendar.Text = "0";
			}
		}

		private void button_addList_Click(object sender, EventArgs e)
		{
			double EnterItemPrice = 0;
			if (textBox_item.Text == null) 
			{
				MessageBox.Show("Please add item!!");
			}
			else if (textBox_price_listview.Text == null)
			{
				MessageBox.Show("Please add price on item!!");
			}
            else if (!double.TryParse(textBox_price_listview.Text, out EnterItemPrice))
			{
				MessageBox.Show("Please enter number!!");
			}
			else
			{
                ItemsControl.AddOrModifyMoney(textBox_item.Text, EnterItemPrice);
                ListViewItem foundItem = MyListView.FindItemWithText(textBox_item.Text);

                if (foundItem != null)
                {
                    //int a = ItemsControl.getListIndex(textBox_item.Text);

                    MyListView.Items.Remove(foundItem);
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Clear();
                    item.SubItems[0].Text = textBox_item.Text;
                    item.SubItems.Add(textBox_price_listview.Text);
                    MyListView.Items.Add(item);
                    
                }
                else 
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Clear();
                    item.SubItems[0].Text = textBox_item.Text;
                    item.SubItems.Add(textBox_price_listview.Text);
                    MyListView.Items.Add(item);

                    //MyControl.Items.AddItemMoney(textBox_item.Text);
                    //RenewCurrentPriceAndGUI();
                }
                RenewCurrentPriceAndGUI();
			}
		}

		private void button_delete_list_Click(object sender, EventArgs e)
		{
            if (MyListView.SelectedItems.Count > 0)
            {
                MyListView.Items.Remove(MyListView.SelectedItems[0]);
                textBox_item.Text = "";
                textBox_price_listview.Text = "";
            }
		}

		private void button_enter_calendar_Click(object sender, EventArgs e)
		{
			double EnterCalendarPrice = 0;
			bool canConvert = double.TryParse(textBox_price_calendar.Text, out EnterCalendarPrice);
			if (canConvert) 
			{
				
                CalendarControl.AddOrModifyMoney(label_Choose_Date.Text, EnterCalendarPrice);
                
				RenewCurrentPriceAndGUI();
                ReNewCalendarGUI();
                ReNewItemGUI();
				
			}
			else 
			{
				MessageBox.Show("You should enter number!!");
			}
			
		}
		private void RenewCurrentPriceAndGUI() 
		{
			//label_Totoal_Calendar.Text = MyControl.Calendar.GetCalendarPrice().ToString();

            label_Totoal_Calendar.Text = CalendarControl.GetAllPrice().ToString();

            label_Items_Total.Text = ItemsControl.GetAllPrice().ToString();

            label_Total.Text = (CalendarControl.GetAllPrice() + ItemsControl.GetAllPrice()).ToString();

            textBox_price_calendar.Text = CalendarControl.GetMoney(label_Choose_Date.Text).ToString();
            
		}
        private void ReNewCalendarGUI() 
        {
            MyMonthCalendar.BoldedDates = CalendarControl.GetAllModifyDates();
        }
        private void ReNewItemGUI() 
        {
            List<string> AllItem = ItemsControl.GetAllItems();
            
            for (int i = 0; i < AllItem.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();
                item.SubItems[0].Text = AllItem[i];
                item.SubItems.Add(ItemsControl.GetMoney(AllItem[i]).ToString());
                MyListView.Items.Add(item);
            }
        }
		private void SetDialogShow(string input) 
		{
			if (this.InvokeRequired)
			{
			    this.Invoke(new Action<string>(SetDialogShow), input);
			    return;
			}// this is for protection

			MessageBox.Show(input);
			
		}

		private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Title = "Select file";
			dialog.InitialDirectory = ".\\";
			dialog.Filter = "xls files (*.*)|*.txt";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				//MessageBox.Show(dialog.FileName);
				MyControl.setfilePath(dialog.FileName);
				MyControl.ReadFileToDictionary();
				RenewCurrentPriceAndGUI();
                ReNewCalendarGUI();
                ReNewItemGUI();
			}
			
		}

		private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyControl.SaveAllData();
		}

		private void button_SaveFile_Click(object sender, EventArgs e)
		{
			MyControl.SaveAllData();
		}

        private void MyListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (MyListView.SelectedItems.Count > 0) 
            {
                textBox_item.Text = MyListView.SelectedItems[0].Text;
                textBox_price_listview.Text = ItemsControl.GetMoney(MyListView.SelectedItems[0].Text).ToString();
            }
        }
        private Calendar_Control CalendarControl = new Calendar_Control();

        private Items_Control ItemsControl = new Items_Control();

        private Control MyControl;

	}
}
