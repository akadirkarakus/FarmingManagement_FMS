﻿using System;
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
    public partial class ManageFarmingData : FormBase
    {
        public ManageFarmingData()
        {
            InitializeComponent();
        }

        private void pcLand_Click(object sender, EventArgs e)
        {
            ManageLand land = new ManageLand();
            land.Show();
        }

        private void pcField_Click(object sender, EventArgs e)
        {
            Fields f = new Fields();
            f.Show();
      
        }

        private void lblField_Click(object sender, EventArgs e)
        {
            Fields f = new Fields();
            f.Show();
        
        }

        private void lblLand_Click(object sender, EventArgs e)
        {
            ManageLand land = new ManageLand();
            land.Show();
        }

        private void pcFarm_Click(object sender, EventArgs e)
        {
            Farms f = new Farms();
            f.Show();
         
        }

        private void ManageFarmingData_Load(object sender, EventArgs e)
        {

        }

        private void lblFarm_Click(object sender, EventArgs e)
        {
            Farms f = new Farms();
            f.Show();
        
        }

        private void pcBarn_Click(object sender, EventArgs e)
        {
            BarnForm b = new BarnForm();
            b.Show();
            
        }

        private void lblBarn_Click(object sender, EventArgs e)
        {
            BarnForm b = new BarnForm();
            b.Show();
           
        }

        private void pcStorage_Click(object sender, EventArgs e)
        {
            StorageForm f = new StorageForm();
            f.Show();
   
        }

        private void lblStorage_Click(object sender, EventArgs e)
        {
            StorageForm f = new StorageForm();
            f.Show();
       
        }
    }
}
