using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmingManagement_FMS.Forms;

namespace FarmingManagement_FMS
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Login());
            //Application.Run(new AdminPanel());
             //Application.Run(new PersonnelStart("10045206006"));

            while (true)
            {
                using (var login = new Login())
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        Form panel = null;

                        if (login.userType == "admin")
                            panel = new AdminPanel();
                        else
                            panel = new PersonnelStart(FormBase.getEmpID());

                        using (panel)
                        {
                            var result = panel.ShowDialog();

                            if (result != DialogResult.Retry)
                                break; // logout değilse uygulamayı kapat
                        }
                    }
                    else break;
                }
            }


        }
    }
}
