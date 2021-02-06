using Domofon_ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domofon_WinForms
{
    public partial class MainForm : Form
    {
        StringBuilder DisplayText = new StringBuilder(4, 4);
        bool PinMode = false;
        int PinModeApartmentNumber;
        public MainForm()
        {
            InitializeComponent();
            DisplayData();
        }



        private void DisplayData()
        {
            ApartmentsList.Apartments.Clear();

            string[] readData = File.ReadAllLines(ConfigForm.path);

            foreach (string str in readData)
            {
                string[] splitData = str.Split(',');
                Apartment one = new Apartment(splitData[0], Convert.ToInt32(splitData[1]), Convert.ToInt32(splitData[2]));
                ApartmentsList.Apartments.Add(one);
            }
            bsResidents.DataSource = new BindingList<Apartment>(ApartmentsList.Apartments);
            listBox1.DataSource = bsResidents;


        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            ApartmentsList.Apartments.Clear();
            AdminLoginForm logForm = new AdminLoginForm();
            logForm.ShowDialog();
            if (logForm.DialogResult == DialogResult.OK)
            {
                ConfigForm frm = new ConfigForm();
                frm.Show();
                frm.ConfigFormClosed += Frm_ConfigFormClosed;
            }
        }

        private void Frm_ConfigFormClosed(object sender, EventArgs e)
        {
            MessageBox.Show("Lista mieszkańców została zaktualizowana");
            bsResidents.ResetBindings(false);
        }

        private void txt_Display_TextChanged(object sender, EventArgs e)
        {
            if (PinMode && DisplayText.Length > 3)
            {
                var OpenCode = ApartmentsList.Apartments.Where(x => x.Number == PinModeApartmentNumber)
                                                        .Select(x => x.Code).FirstOrDefault();
                if(Convert.ToInt32(DisplayText.ToString()) == OpenCode)
                {
                    SystemSounds.Exclamation.Play();  
                    MessageBox.Show("Proszę wejść!", "Drzwi otwarte!");
                    DisplayText.Clear();
                    txt_Display.Clear();
                    txt_Display.PasswordChar = '\0';
                }
            }
        }


        #region NumericPadButtons
        private void btn_0_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play(); ;
            DisplayText.Append("0");
            txt_Display.Text = DisplayText.ToString();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            try
            {
                SystemSounds.Beep.Play();
                DisplayText.Append("1");
                txt_Display.Text = DisplayText.ToString();
            }
            catch { }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            try
            {
                SystemSounds.Beep.Play();
                DisplayText.Append("2");
                txt_Display.Text = DisplayText.ToString();
            }
            catch { }

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            try
            {
                SystemSounds.Beep.Play();
                DisplayText.Append("3");
                txt_Display.Text = DisplayText.ToString();
            }
            catch { }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            try
            {
                SystemSounds.Beep.Play();
                DisplayText.Append("4");
                txt_Display.Text = DisplayText.ToString();
            }
            catch { }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            try
            {
                SystemSounds.Beep.Play();
                DisplayText.Append("5");
                txt_Display.Text = DisplayText.ToString();
            }
            catch { }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            try
            {
                SystemSounds.Beep.Play();
                DisplayText.Append("6");
                txt_Display.Text = DisplayText.ToString();
            }
            catch { }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            try
            {
                SystemSounds.Beep.Play();
                DisplayText.Append("7");
                txt_Display.Text = DisplayText.ToString();
            }
            catch { }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            try
            {
                SystemSounds.Beep.Play();
                DisplayText.Append("8");
                txt_Display.Text = DisplayText.ToString();
            }
            catch { }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            try
            {
                SystemSounds.Beep.Play();
                DisplayText.Append("9");
                txt_Display.Text = DisplayText.ToString();
            }
            catch { }
        }

        private void btn_Star_Click(object sender, EventArgs e)
        {
            //find match string builder == apartments.number ==> if yes change display do PIN mode
            if (ApartmentsList.Apartments.Any(x => x.Number.ToString() == txt_Display.Text))
            {
                PinMode = true;
                PinModeApartmentNumber = Convert.ToInt32(DisplayText.ToString());
                DisplayText.Clear();
                txt_Display.Clear();
                txt_Display.PasswordChar = '*';

                
            }
        }


        private void btn_Hash_Click(object sender, EventArgs e)
        {
            DisplayText.Clear();
            txt_Display.PasswordChar = '\0';
            PinMode = false;
            txt_Display.Text = DisplayText.ToString();
        }

        #endregion
    }
}
