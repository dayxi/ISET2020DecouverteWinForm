﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISET_2020_Découverte_WinForm
{
    public partial class EcranCarte : Form
    {
        public EcranCarte()
        {
            InitializeComponent();
        }

        public EcranCarte(string sLon , string sLat)
        {
            InitializeComponent();

            wbCarte.Navigate("https://maps.google.com/maps?q=" + sLat + "%2C" + sLon);
                //Envoi le browser sur maps
        }
    }
}
