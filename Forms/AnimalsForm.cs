using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmingManagement_FMS.Forms
{
    public partial class AnimalsForm : FormBase
    {
        private int fielNo;
        public AnimalsForm(int FieldNo)
        {
            this.fielNo = FieldNo;
            InitializeComponent();
        }

        private void Reload()
        {

        }
        private void AnimalsForm_Load(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
