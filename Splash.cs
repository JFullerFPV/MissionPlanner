﻿using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();

            string strVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            TXT_version.Text = "Version: " + Application.ProductVersion; // +" Built By Jerry Fuller " + strVersion;

            if (Program.Logo != null)
            {
                pictureBox1.BackgroundImage = MissionPlanner.Properties.Resources.bgdark;
                pictureBox1.Image = Program.Logo;
                pictureBox1.Visible = true;
            }
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }
    }
}