﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media; //allows us to use sound player

namespace SpringfieldNuclear
{
    public partial class NuclearStatus : Form
    {
        public NuclearStatus()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //create sound player and play sound 
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
            alertPlayer.Play();

            //change the colour of the state labels 
            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            
            //change the message in output label 
            outputLabel.Text = "Meltdown Imminent";

            //show changes and then change
            Refresh();
            Thread.Sleep(1000);

            //change the colour of state labels to white 
            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;

            //show changes and then change
            Refresh();
            Thread.Sleep(1000);

            //change the colour of the state labels 
            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;

        }
    }
}
