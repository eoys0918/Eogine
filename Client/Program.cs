using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using Eogine;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (ProcessChecker.IsOnlyProcess(Application.ProductName))
            {
                EogineManager.BeforeStart += new EoDelegate.Void(before);
                EogineManager.AfterStart += new EoDelegate.Void(after);
                EogineManager.Start(new MainForm());
            }
        }
        static void before()
        {
            Console.Write("before!!");
        }
        static void after()
        {
            Console.Write("after!!");
        }
    }
}
