using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting
{
    class AccountingInvoker
    {
        public void SetCommand(AccountingCommand cmd,string cmdSting)
        {
            cmd.CmdSting = cmdSting;
            cmds.Add(cmd);
        }
        public void Run()
        {
            try
            {
                foreach (AccountingCommand cmd in this.cmds)
                {
                    cmd.Execute();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("before show error message");
                ShowErrorMessage(ex.ToString());
            }
            finally
            {
                cmds.Clear();
            }
            
        }
        public static event Action<string> ShowDialogEvent = null;
        private static void ShowErrorMessage(string s)
        {
            ShowDialogEvent?.Invoke(s);
        }
        private List<AccountingCommand> cmds = new List<AccountingCommand>();
    }

    abstract class AccountingCommand
    {
        public AccountingCommand(InfoAccountingReceiver accountingInfo, FormMain formMain)
        {
            this.accountingInfo = accountingInfo;
            this.formMain = formMain;
        }
        public string CmdSting
        {
            get; set;
        }

        abstract public void Execute();
        protected InfoAccountingReceiver accountingInfo;
        protected FormMain formMain;
        

    }
    
}
