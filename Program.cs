using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(new AdminPanel());

            /*
            // DENEMELERİ HIZLANDIRMAK İÇİN İPTAL EDİLDİ. TEKRAR AÇILACAK!!!!
            while (true)
            {
                using (var login = new Form1())
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        Form panel = null;

                        if (login.userType == "admin")
                            panel = new AdminPanel();
                        else
                            panel = new PersonnelPanel();

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

            */
        }
    }
}
