using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLL
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var login = new QLL.UI.frmDangNhap())
    {
        if (login.ShowDialog() != DialogResult.OK)
            return;

        Application.Run(new QLL.UI.frmMain(login.TaiKhoanDangNhap));
    }
        }
    }
}
