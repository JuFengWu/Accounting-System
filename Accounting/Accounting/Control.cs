using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Accounting
{
	class Control
	{
        public Control(Calendar_Control _CalendarControl, Items_Control _ItemsControl)
		{
            CalendarControl = _CalendarControl;
            ItemsControl = _ItemsControl;
		}

		public static double GetDoubleDicPrice(Dictionary<string, double> dic) 
		{
			double TotalPrice = 0.0;
			foreach (KeyValuePair<string, double> item in dic)
			{
				TotalPrice += item.Value;
			}

			return TotalPrice;
		}

		public void setfilePath(string path)
		{
			if (path != null) 
			{
                filePath = path;
			}
			else
			{
				ShowErrorMessage("Open File Error");
			}
		}

		public void ReadFileToDictionary() 
		{
            if (filePath != null)
            {
                string[] Readlines = File.ReadAllLines(filePath);

                CalendarControl.ReadDataFromFile(Readlines);

                ItemsControl.ReadDataFromFile(Readlines);
            }
            else 
            {
                ShowErrorMessage("Please set file path first!!!");
            }

		}
		public void SaveAllData() 
		{
            if (filePath == null)
            {
                filePath = "Acc.txt";
            }
            List<string> write2File = new List<string>();

            foreach (string line in CalendarControl.SaveDataToFile())
            {
                write2File.Add(line);
            }
            foreach (string line in ItemsControl.SaveDataToFile())
            {
                write2File.Add(line);
            }

            File.WriteAllLines(filePath, write2File);
		}

		private static void ShowErrorMessage(string s) 
		{
			if (ShowDialogEvent != null)
			{
				ShowDialogEvent(s);
			}
		}

        public static event Action<string> ShowDialogEvent = null;

        private Calendar_Control CalendarControl;

        private Items_Control ItemsControl;

        private string filePath = null;
				
	}// end class Control

}
//利用繼承的方式，date & item接繼承MoneyControl，外面的就直接用Control 