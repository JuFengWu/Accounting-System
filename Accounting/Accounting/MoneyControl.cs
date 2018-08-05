using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting
{
    class MoneyControl
    {
        public MoneyControl(string _FileKeyWord) 
        {
            FileKeyWord = _FileKeyWord;
            MoneyRecord = new Dictionary<string, double>();
        }
        // below are piblic methods
        public void AddOrModifyMoney(string key, double Money) 
        {
            if (MoneyRecord.ContainsKey(key))
            {
                MoneyRecord[key] = Money;
            }
            else 
            {
                MoneyRecord.Add(key, Money);
            }
            
        }
        public double GetMoney(string key) 
        {
            if (true == (MoneyRecord.ContainsKey(key)))
            {
                return MoneyRecord[key];
            }
            else
            {
                return 0;
            }
        }
        public double GetAllPrice() 
        {
            double TotalPrice = 0.0;
            foreach (KeyValuePair<string, double> item in MoneyRecord)
            {
                TotalPrice += item.Value; //item.Key is not used 
            }
            return TotalPrice;
        }
        public void ReadDataFromFile(string[] Readlines)
        {
            MoneyRecord = Readlines.Select(l => l.Split('=')).Where(x => x[2] == FileKeyWord).ToDictionary(a => a[0], a => double.Parse(a[1]));
        }
        public string[] SaveDataToFile()
        {
            return MoneyRecord.Select(kvp => kvp.Key + "=" + kvp.Value + "="+FileKeyWord).ToArray();
        }
        //bleow are public variables
        public static event Action<string> ShowDialogEvent = null;

        // below are protected functions
        protected static void ShowErrorMessage(string s)
        {
            if (ShowDialogEvent != null)
            {
                ShowDialogEvent(s);
            }
        }

        //bleow are protected varibales
        protected Dictionary<string, double> MoneyRecord;
        protected string FileKeyWord = "";
    }

    class Calendar_Control : MoneyControl 
    {
        public Calendar_Control() : base("Date") { }
        
        public DateTime[] GetAllModifyDates() 
        {
            List<DateTime> DayList = new List<DateTime>();
            foreach (string d in this.MoneyRecord.Keys) 
            {
                DayList.Add(Convert.ToDateTime(d));
            }
            return DayList.ToArray();
        }
    }

    class Items_Control : MoneyControl
    {
        public Items_Control() : base("Items") { }
        public List<string> GetAllItems() 
        {
            List<string> AllItems = new List<string>();
            foreach (string s in this.MoneyRecord.Keys)
            {
                AllItems.Add(s);
            }
            return AllItems;
        }
        
    }

}
