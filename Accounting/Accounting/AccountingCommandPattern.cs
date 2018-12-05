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
            foreach (AccountingCommand cmd in this.cmds)
            {
                cmd.Execute();
            }
            cmds.Clear();
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
