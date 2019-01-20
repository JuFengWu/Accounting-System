using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accounting;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.IO;

using Excel = Microsoft.Office.Interop.Excel;

namespace Accounting
{
    public struct AccountingInformation
    {   public double totalPrice;

        public string currentDatePrice;
        public string currentDate;
        public string currentItemName;
        public string currentItemPrice;

        public double allDatePrice;
        public double allItemPrice;

        public Dictionary<string, double> dateMoneyRecord;
        public Dictionary<string, double> itemMonryRecord;

        public const string fileDateKeyWord = "DATE";
        public const string fileItemKeyWord = "ITEM";
        public const string modifyKeyWord = "MODIFY";

		public AccountingInformation(double iniDatePrice, double iniItemPrice)
		{
			totalPrice = iniDatePrice + iniItemPrice;

			allDatePrice = iniDatePrice;
			allItemPrice = iniItemPrice;

			dateMoneyRecord = new Dictionary<string, double>();
			itemMonryRecord = new Dictionary<string, double>();

			currentDatePrice = null;
			currentDate = null;
			currentItemName = null;
			currentItemPrice = null;
		}
    }

    class InfoAccountingReceiver
    {
		private AccountingInformation accountingInformation;

        public InfoAccountingReceiver()
        {
            accountingInformation = new AccountingInformation(0, 0);
        }

        public AccountingInformation ModifyDateNameInformation(string dateName)
        {
            accountingInformation.currentDate = dateName;

            return accountingInformation;
        }
        public AccountingInformation ModifyDatePriceInformation(string datePrice)
        {
            accountingInformation.currentDatePrice += datePrice;
            return accountingInformation;
        }
        public AccountingInformation ModifyDateTableAndPriceInformation(string dateInformations)
        {
            string[] dateInformation = dateInformations.Split('=');
            
            if (dateInformation.Length != 3)
            {
                throw new Exception("dateInformations is not correct");
            }
            if (!double.TryParse(dateInformation[2], out double datePrice))
            {
                throw new Exception("datPrice is not double");
            }
            if ( (accountingInformation.dateMoneyRecord.ContainsKey(dateInformation[1]))) //dateInformation[0] == AccountingInformation.modifyKeyWord ||
            {
                
                accountingInformation.dateMoneyRecord.Remove(dateInformation[1]);// date
            }

            if (datePrice != 0)
            {

                accountingInformation.dateMoneyRecord.Add(dateInformation[1], datePrice);

                accountingInformation.currentDate = dateInformation[1];

                accountingInformation.currentDatePrice = dateInformation[2];

            }
            return accountingInformation;
        }

        public AccountingInformation ModifyItemNameInformation(string itemName)
        {
            accountingInformation.currentItemName = itemName;
            return accountingInformation;
        }
        public AccountingInformation ModifyItemPriceInformation(string itemPrice)
        {
            accountingInformation.currentItemPrice = itemPrice;
            return accountingInformation;
        }
        public AccountingInformation ModifyItemTableNameAndPriceInformation(string itemInformations)
        {
            
            string[] itemInformation = itemInformations.Split('=');
            if (itemInformation.Length != 3)
            {
                throw new Exception("itemInformations is not correct");
            }
            if (!double.TryParse(itemInformation[2], out double itemPrice))
            {
                throw new Exception("item price is not double");
            }
            if (itemInformation[0] == AccountingInformation.modifyKeyWord || (accountingInformation.itemMonryRecord.ContainsKey(itemInformation[1])))
            {
                accountingInformation.itemMonryRecord.Remove(itemInformation[1]);// date
                
            }

            accountingInformation.itemMonryRecord.Add(itemInformation[1], itemPrice);
            
            accountingInformation.currentItemName = itemInformation[1];
            accountingInformation.currentItemPrice = itemPrice.ToString();
            return accountingInformation;

        }
        public AccountingInformation ModifyTotalInformation()
        {
            accountingInformation.allDatePrice = accountingInformation.dateMoneyRecord.Skip(0).Sum(i => i.Value);
            accountingInformation.allItemPrice = accountingInformation.itemMonryRecord.Skip(0).Sum(i => i.Value);

            accountingInformation.totalPrice = accountingInformation.allDatePrice + accountingInformation.allItemPrice;
            return accountingInformation;
        }
        public double GetDateMoneyInformation(string key)
        {
            if (true == (accountingInformation.dateMoneyRecord.ContainsKey(key)))
            {
                return accountingInformation.dateMoneyRecord[key];
            }
            else
            {
                return 0;
            }
        }
        public double GetItemMoneyInformation(string key)
        {

            if (true == (accountingInformation.itemMonryRecord.ContainsKey(key)))
            {
                return accountingInformation.itemMonryRecord[key];
            }
            else
            {
                return 0;
            }
        }
        public AccountingInformation DeleteItemCommandInformation(string key)
        {
            accountingInformation.itemMonryRecord.Remove(key);
            return accountingInformation;
        }
        public void SaveAll(string filePath)
        {
            if (null == filePath)
            {
                filePath = "Acc.txt";
            }
            List<string> write2File = new List<string>();

            foreach (string line in accountingInformation.dateMoneyRecord.Select(kvp => kvp.Key + "=" + kvp.Value + "=" + AccountingInformation.fileDateKeyWord).ToArray())
            {
                write2File.Add(line);
            }
            foreach (string line in accountingInformation.itemMonryRecord.Select(kvp => kvp.Key + "=" + kvp.Value + "=" + AccountingInformation.fileItemKeyWord).ToArray())
            {
                write2File.Add(line);
            }

			File.WriteAllLines(filePath, write2File);
		}

		public string GetFilePath(bool isOpenFileDialog,string filterName,string title) 
		{
			FileDialog fileDialog;
			if (isOpenFileDialog)
			{
				fileDialog = new OpenFileDialog();
			}
			else
			{
				fileDialog = new SaveFileDialog();
			}
			fileDialog.Filter = filterName;
			fileDialog.Title = title;
			fileDialog.ShowDialog();
			return fileDialog.FileName;
		}
        public Tuple<Dictionary<string,double>, Dictionary<string,double>> ReadFile(string filePath)
        {
            if (null == filePath || "" == filePath)
            {
                throw new FormatException("file is null");
            }
            else
            { 
                string[] Readlines = File.ReadAllLines(filePath);

                var dateRecord = Readlines.Select(l => l.Split('=')).Where(x => x[2] == AccountingInformation.fileDateKeyWord).ToDictionary(a => a[0], a => double.Parse(a[1]));
                accountingInformation.dateMoneyRecord = dateRecord;

                var itemRecord = Readlines.Select(l => l.Split('=')).Where(x => x[2] == AccountingInformation.fileItemKeyWord).ToDictionary(a => a[0], a => double.Parse(a[1]));
                accountingInformation.itemMonryRecord = itemRecord;

                return Tuple.Create(dateRecord, itemRecord);
            }
        }
		private void WriteDateToExecl(ref int excelCellIndex, Excel.Application app, Dictionary<string, double> saveDictory)
		{
			foreach (KeyValuePair<string, double> item in saveDictory)
			{
				excelCellIndex++;
				app.Cells[excelCellIndex, 1] = item.Key;
				app.Cells[excelCellIndex, 2] = item.Value.ToString();
			}
		}
		private Tuple<Excel.Application, Excel.Workbook> InitialExcel(string excelPath) 
		{
			Excel.Application app = new Excel.Application();
			if (null == app)
			{
				throw new Exception("Excel is not properly installed!!");

			}
			Excel.Workbook workBook;

			if (!File.Exists(excelPath))
			{
				workBook = app.Workbooks.Add();
			}
			else
			{
				workBook = app.Workbooks.Open(excelPath);
			}
			Excel.Worksheet workSheet = workBook.Worksheets.Add();
			workSheet.Name = DateTime.Now.ToString("MMMM,yyyy");
			return Tuple.Create(app, workBook);
		}
        public void SaveToExcel(string excelPath)
        {
			int excelCellIndex = 0;
			var excelItem = InitialExcel(excelPath);
			WriteDateToExecl(ref excelCellIndex, excelItem.Item1, accountingInformation.dateMoneyRecord);
			WriteDateToExecl(ref excelCellIndex, excelItem.Item1, accountingInformation.itemMonryRecord);
            if (File.Exists(excelPath))
            {
				excelItem.Item2.SaveAs(excelPath);
            }
                
            //workBook.Close();
			excelItem.Item2.Close();

			excelItem.Item1.Quit();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }        
        
    }

    class ModifyDateNameCommand : AccountingCommand
    {
        public ModifyDateNameCommand(InfoAccountingReceiver accountingInfo, FormMain formMain) : base(accountingInfo, formMain)
        {
            return;
        }
        public override void Execute()
        {
            AccountingInformation accountingInformation = accountingInfo.ModifyDateNameInformation(CmdSting);
            formMain.ModifyDateNameGui(accountingInformation);
        }
    }
    class ModifyDatePriceCommand : AccountingCommand
    {
        public ModifyDatePriceCommand(InfoAccountingReceiver accountingInfo, FormMain formMain) : base(accountingInfo, formMain)
        {
            return;
        }
        public override void Execute()
        {
            AccountingInformation accountingInformation = accountingInfo.ModifyDatePriceInformation(CmdSting);
            formMain.ModifyDatePriceGui(accountingInformation);
        }
    }
    class ModifyDateTableAndPriceCommand : AccountingCommand
    {
        public ModifyDateTableAndPriceCommand(InfoAccountingReceiver accountingInfo, FormMain formMain) : base(accountingInfo, formMain)
        {
            return;
        }
        public override void Execute()
        {
            AccountingInformation accountingInformation = accountingInfo.ModifyDateTableAndPriceInformation(CmdSting);
            formMain.ModifyDateTableAndPriceGui(accountingInformation);
        }
    }


    class ModifyItemNameCommand : AccountingCommand
    {
        public ModifyItemNameCommand(InfoAccountingReceiver accountingInfo, FormMain formMain) : base(accountingInfo, formMain)
        {
            return;
        }
        public override void Execute()
        {
            AccountingInformation accountingInformation = accountingInfo.ModifyItemNameInformation(CmdSting);
            formMain.ModifyItemNameGui(accountingInformation);
        }
    }

    class ModifyItemPriceCommand : AccountingCommand
    {
        public ModifyItemPriceCommand(InfoAccountingReceiver accountingInfo, FormMain formMain) : base(accountingInfo, formMain)
        {
            return;
        }
        public override void Execute()
        {
            AccountingInformation accountingInformation = accountingInfo.ModifyItemPriceInformation(CmdSting);
            formMain.ModifyItemPriceGui(accountingInformation);

        }
    }

    class ModifyItemTableNameAndPriceCommand : AccountingCommand
    {
        public ModifyItemTableNameAndPriceCommand(InfoAccountingReceiver accountingInfo, FormMain formMain) : base(accountingInfo, formMain)
        {
            return;
        }
        public override void Execute()
        {
            AccountingInformation accountingInformation = accountingInfo.ModifyItemTableNameAndPriceInformation(CmdSting);
            formMain.ModifyItemTableNameAndPriceGui(accountingInformation);

        }
    }

    class ModifyTotalCommand : AccountingCommand
    {
        public ModifyTotalCommand(InfoAccountingReceiver accountingInfo, FormMain formMain) : base(accountingInfo, formMain)
        {
            return;
        }
        public override void Execute()
        {
            AccountingInformation accountingInformation = accountingInfo.ModifyTotalInformation();
            formMain.ModifyTotalGui(accountingInformation);

        }
    }

    class GetDateMoneyCommand : AccountingCommand
    {
        public GetDateMoneyCommand(InfoAccountingReceiver accountingInfo, FormMain formMain) : base(accountingInfo, formMain)
        {
            return;
        }
        public override void Execute()
        {
            DateMoney = accountingInfo.GetDateMoneyInformation(CmdSting);
        }

        public double DateMoney { get; private set; }
    }
    class GetItemMoneyCommnad : AccountingCommand
    {
        public GetItemMoneyCommnad(InfoAccountingReceiver accountingInfo, FormMain formMain) : base(accountingInfo, formMain)
        {
            return;
        }
        public override void Execute()
        {
            ItemMoney = accountingInfo.GetItemMoneyInformation(CmdSting);
        }

        public double ItemMoney { get; private set; }
    }
    class DeleteItemCommand : AccountingCommand
    {
        public DeleteItemCommand(InfoAccountingReceiver accountingInfo, FormMain formMain) : base(accountingInfo, formMain)
        {
            return;
        }
        public override void Execute()
        {
            AccountingInformation accountingInformation = accountingInfo.DeleteItemCommandInformation(CmdSting);
            formMain.DeleteItemTableSubItem(accountingInformation);
        }
    }
	
    class SelectPathCommand : AccountingCommand
    {
		public string Path { get; private set; }
		protected string _filterName = "Txt file|*.txt|Acc file|*.acc";
		protected string _title = "Read Account File";
		protected bool _isOpenFileDialog = true;

        public SelectPathCommand(InfoAccountingReceiver accountingInfo, FormMain formMain) : base(accountingInfo, formMain)
        {
            return;
        }
        public override void Execute()
        {
			Path = accountingInfo.GetFilePath(_isOpenFileDialog, _filterName, _title);
        }
        
    }
	class SelectReadFileCommand : SelectPathCommand
	{
		public SelectReadFileCommand(InfoAccountingReceiver accountingInfo, FormMain formMain) : base(accountingInfo, formMain)
        {
			_filterName = "Txt file|*.txt|Acc file|*.acc";
			_title = "Read Account File";
			_isOpenFileDialog = true;
		}
	}
	class SaveExecelFileCommand : SelectPathCommand
	{
		public SaveExecelFileCommand(InfoAccountingReceiver accountingInfo, FormMain formMain) : base(accountingInfo, formMain) 
		{
			_isOpenFileDialog = false;
			_filterName = "Txt file|*.txt|Acc file|*.acc";
			_title = "Save Account File";
		}
	}
	class SaveFileCommand : SelectPathCommand 
	{
		public SaveFileCommand(InfoAccountingReceiver accountingInfo, FormMain formMain): base(accountingInfo, formMain) 
		{
			_isOpenFileDialog = true;
			_filterName = "excel file|*.xlsx";
			_title = "Save Account File";
		}
	}
    class SaveAllCommand : AccountingCommand
    {
        public SaveAllCommand(InfoAccountingReceiver accountingInfo, FormMain formMain) : base(accountingInfo, formMain)
        {
            return;
        }
        public override void Execute()
        {
            accountingInfo.SaveAll(CmdSting);
        }

    }
    class ReadFileCommand : AccountingCommand
    {
        public ReadFileCommand(InfoAccountingReceiver accountingInfo, FormMain formMain) : base(accountingInfo, formMain)
        {
            return;
        }
        public override void Execute()
        {
            var tup= accountingInfo.ReadFile(CmdSting);
            AllDateValue = tup.Item1;
            AllItemValue = tup.Item2;
        }
        public Dictionary<string, double> AllDateValue { get; private set; }
        public Dictionary<string, double> AllItemValue { get; private set; }
    }
    class SaveToExcelCommand : AccountingCommand
    {
        public SaveToExcelCommand(InfoAccountingReceiver accountingInfo, FormMain formMain) : base(accountingInfo, formMain)
        {
            return;
        }
        public override void Execute()
        {
            accountingInfo.SaveToExcel(CmdSting);
        }
    }
}
