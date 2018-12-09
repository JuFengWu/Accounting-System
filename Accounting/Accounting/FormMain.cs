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
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();

            invoker = new AccountingInvoker();
            receiver = new InfoAccountingReceiver();

            modifyDateCommnad = new ModifyDateNameCommand(receiver,this);
            modifyDatePriceCommand =new ModifyDatePriceCommand(receiver, this);
            modifyDateTableAndPriceCommand = new ModifyDateTableAndPriceCommand(receiver, this);
            modifyItemNameCommand = new ModifyItemNameCommand(receiver, this);
            modifyItemPriceCommand =new ModifyItemPriceCommand(receiver, this);
            modifyItemTableNameAndPriceCommand =new ModifyItemTableNameAndPriceCommand(receiver, this);
            modifyTotalCommand = new ModifyTotalCommand(receiver, this);
            getDateMoneyCommand = new GetDateMoneyCommand(receiver, this);
            getItemMoneyCommnad = new GetItemMoneyCommnad(receiver, this);
            deleteItemCommand = new DeleteItemCommand(receiver, this);
            selectPathCommand = new SelectPathCommand(receiver, this);
            saveAllCommand = new SaveAllCommand(receiver, this);
            readFileCommand =new ReadFileCommand(receiver,this);
            saveToExcelCommand = new SaveToExcelCommand(receiver, this);

            AccountingInvoker.ShowDialogEvent += SetDialogShow;

            label_Choose_Date.Text = MyMonthCalendar.TodayDate.ToString("yyyy/M/d");

			MyListView.GridLines = true;
			MyListView.FullRowSelect = true;

			MyListView.View = View.Details;
			MyListView.Scrollable = true;
			MyListView.MultiSelect = false;
			
			MyListView.Columns.Add("Additional Item", 150, HorizontalAlignment.Center);
			MyListView.Columns.Add("Price", 50, HorizontalAlignment.Center);
		}

        AccountingInvoker invoker;
        InfoAccountingReceiver receiver;
        

        ModifyDateNameCommand modifyDateCommnad;
        ModifyDatePriceCommand modifyDatePriceCommand;
        ModifyDateTableAndPriceCommand modifyDateTableAndPriceCommand;
        ModifyItemNameCommand modifyItemNameCommand;
        ModifyItemPriceCommand modifyItemPriceCommand;
        ModifyItemTableNameAndPriceCommand modifyItemTableNameAndPriceCommand;
        ModifyTotalCommand modifyTotalCommand;
        GetDateMoneyCommand getDateMoneyCommand;
        GetItemMoneyCommnad getItemMoneyCommnad;
        DeleteItemCommand deleteItemCommand;
        SelectPathCommand selectPathCommand;
        SaveAllCommand saveAllCommand;
        ReadFileCommand readFileCommand;
        SaveToExcelCommand saveToExcelCommand;

        private void ButtonEnterCalendarClick(object sender, EventArgs e)
        {
            
            string command = CommandEncoder(true, label_Choose_Date.Text, textBox_price_calendar.Text);

            invoker.SetCommand(modifyDateTableAndPriceCommand, command);
            invoker.SetCommand(modifyTotalCommand, "");
            invoker.Run();

        }
        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            
            label_Choose_Date.Text = MyMonthCalendar.SelectionStart.ToShortDateString();

            invoker.SetCommand(getDateMoneyCommand, label_Choose_Date.Text);
            invoker.Run();
            
            
            if (getDateMoneyCommand.DateMoney != 0)
            {
                textBox_price_calendar.Text = getDateMoneyCommand.DateMoney.ToString();
            }
            else
            {
                textBox_price_calendar.Text = "0";
            }
        }

        private void ButtonAddListClick(object sender, EventArgs e)
        {
            
            string addCommand = CommandEncoder(true, textBox_item_name.Text, textBox_item_price.Text);

            invoker.SetCommand(modifyItemNameCommand, textBox_item_name.Text);
            invoker.SetCommand(modifyItemTableNameAndPriceCommand, addCommand);
            invoker.SetCommand(modifyTotalCommand, "");
            invoker.Run();
            
        }
        private void ButtonDeleteListClick(object sender, EventArgs e)
        {
            if (MyListView.SelectedItems.Count > 0)
            {
                
                invoker.SetCommand(deleteItemCommand, textBox_item_name.Text);
                invoker.SetCommand(modifyTotalCommand, "");
                invoker.Run();
                
                
            }
        }
        private void MyListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (MyListView.SelectedItems.Count > 0)
            {
               
                invoker.SetCommand(getItemMoneyCommnad, MyListView.SelectedItems[0].Text);
                invoker.Run();

                invoker.SetCommand(modifyItemNameCommand, MyListView.SelectedItems[0].Text);
                invoker.SetCommand(modifyItemPriceCommand, getItemMoneyCommnad.ItemMoney.ToString());
                invoker.Run();
                
            }
        }
        private void SaveFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            
            invoker.SetCommand(selectPathCommand, AccountingInformation.saveFileMode);
            invoker.Run();
            FilePath = selectPathCommand.Path;
            invoker.SetCommand(saveAllCommand, FilePath);
            invoker.Run();
            
        }

        private void ButtonSaveFileClick(object sender, EventArgs e)
        {
            
            if ("" == FilePath)
            {
                invoker.SetCommand(selectPathCommand, AccountingInformation.saveFileMode);
                invoker.Run();
                FilePath = selectPathCommand.Path;
            }

            invoker.SetCommand(saveAllCommand, FilePath);
            invoker.Run();
            
        }
        private void OpenFileToolStripMenuItemClick(object sender, EventArgs e) // TODO: use thread
        {
            
            invoker.SetCommand(selectPathCommand, AccountingInformation.readFileMode);
            invoker.Run();

            FilePath = selectPathCommand.Path;

            invoker.SetCommand(readFileCommand, FilePath);
            invoker.Run();

            if (null != readFileCommand.AllDateValue)
            {
                foreach (KeyValuePair<string, double> entry in readFileCommand.AllDateValue.ToArray())
                {
                    string command = CommandEncoder(true, entry.Key, entry.Value.ToString());
                    invoker.SetCommand(modifyDateTableAndPriceCommand, command);
                    invoker.Run();
                }
            }

            if (null != readFileCommand.AllItemValue)
            {
                foreach (KeyValuePair<string, double> entry in readFileCommand.AllItemValue.ToArray())
                {
                    string command = CommandEncoder(true, entry.Key, entry.Value.ToString());
                    invoker.SetCommand(modifyItemTableNameAndPriceCommand, command);
                    invoker.Run();
                }
            }

            invoker.SetCommand(modifyTotalCommand, "");
            invoker.Run();
            
        }
        private void ButtonCheckSaveToExcelClick(object sender, EventArgs e) // TODO: use thread
        {
           
            invoker.SetCommand(selectPathCommand, AccountingInformation.saveExecelFileMode);
            invoker.Run();

            invoker.SetCommand(saveToExcelCommand, selectPathCommand.Path);
            invoker.Run();
          

        }
        private string FilePath = "";
        
        private string CommandEncoder(bool isAdd,string name, string price)
        {
            if (null == name)
            {
                MessageBox.Show("Please name should not be null!!");
            }
            else if (!double.TryParse(price, out double EnterItemPrice))
            {
                MessageBox.Show("Please enter a number!!");
            }
            if (isAdd)
            {
                return "ADD=" + name + "=" + price.ToString();
            }
            else
            {
                return AccountingInformation.modifyKeyWord +"= " + name + "=" + price.ToString(); 
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


        public void ModifyDateNameGui(AccountingInformation backGroundInformation)
        {
            label_Choose_Date.Text = backGroundInformation.currentDate;
        }
        public void ModifyDatePriceGui(AccountingInformation backGroundInformation)
        {
            textBox_price_calendar.Text = backGroundInformation.currentDate;
        }
        public void ModifyDateTableAndPriceGui(AccountingInformation backGroundInformation)
        { 
            List<DateTime> DayList = new List<DateTime>();

            foreach (string d in backGroundInformation.dateMoneyRecord.Keys) 
            {
                DayList.Add(Convert.ToDateTime(d));
            }
            MyMonthCalendar.BoldedDates = DayList.ToArray();
        }
        public void ModifyItemNameGui(AccountingInformation backGroundInformation)
        {
            textBox_item_name.Text = backGroundInformation.currentItemName;
        }
        public void ModifyItemPriceGui(AccountingInformation backGroundInformation)
        {

            textBox_item_price.Text = backGroundInformation.currentItemPrice;
        }
        public void ModifyItemTableNameAndPriceGui(AccountingInformation backGroundInformation)
        {
            ListViewItem foundItem = MyListView.FindItemWithText(backGroundInformation.currentItemName);
            if (foundItem != null)
            {
                //int a = ItemsControl.getListIndex(textBox_item.Text);

                MyListView.Items.Remove(foundItem);
            }

            ListViewItem item = new ListViewItem();
            item.SubItems.Clear();
            item.SubItems[0].Text = backGroundInformation.currentItemName;
            item.SubItems.Add(backGroundInformation.currentItemPrice);
            MyListView.Items.Add(item);
            
        }
        public void DeleteItemTableSubItem(AccountingInformation backGroundInformation)
        {
            ListViewItem foundItem = MyListView.FindItemWithText(backGroundInformation.currentItemName);

            if (null == foundItem)
            {
                MessageBox.Show("backGroundInformation have no such item");
            }
            else
            {
                MyListView.Items.Remove(foundItem);
                textBox_item_name.Text = "";
                textBox_item_price.Text = "";
            }
        }
        public void ModifyTotalGui(AccountingInformation backGroundInformation)
        {
            label_Totoal_Calendar.Text = backGroundInformation.allDatePrice.ToString();
            label_Items_Total.Text = backGroundInformation.allItemPrice.ToString();
            label_Total.Text = backGroundInformation.totalPrice.ToString();
        }



    }
}
