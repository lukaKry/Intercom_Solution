using Domofon_ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domofon_WinForms
{
    public partial class ConfigForm : Form
    {
        public event EventHandler ConfigFormClosed;

        StringBuilder errorMessage = new StringBuilder();
        public static string  path = @".\ApartmentsList.txt";


        public ConfigForm()
        {
            InitializeComponent();
            ReadData();
            bsApartments.DataSource = new BindingList<Apartment>(ApartmentsList.Apartments);
            numUpDown_Number.Value = ApartmentsList.Apartments.Count() + 1;

        }

        protected virtual void OnConfigFormClosed(EventArgs e)
        {
            EventHandler handler = ConfigFormClosed;
            handler?.Invoke(this, e);
        }

        private void btn_SaveAndClose_Click(object sender, EventArgs e)
        {
            SaveData();
            Close();
            OnConfigFormClosed(e);

        }

        private void ReadData()
        {
            ApartmentsList.Apartments.Clear();

            string [] readData = File.ReadAllLines(path);
            
            foreach(string str in readData)
            {
                string[] splitData = str.Split(',');
                Apartment one = new Apartment(splitData[0], Convert.ToInt32(splitData[1]), Convert.ToInt32(splitData[2]));
                ApartmentsList.Apartments.Add(one);

            }
            lbl_NumberOfResidents.Text = "Liczba mieszkań: " + ApartmentsList.Apartments.Count().ToString();
            
        }

        private void SaveData()
        {
            string[] saveData = new string[ApartmentsList.Apartments.Count];
            int i = 0;
            foreach(var item in ApartmentsList.Apartments)
            {
                saveData[i] = item.ToStringForSave();
                i++;
            }
            File.WriteAllLines(path, saveData);
        }

        

        #region AddTab

        //Add button click
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (IsDataCorrect())
            {
                Apartment apartment = new Apartment(
                    txt_LastName.Text,
                    (int)numUpDown_Number.Value,
                    Int32.Parse(txt_Code.Text));

                ApartmentsList.AddApartment(apartment);
                lbl_NumberOfResidents.Text = "Liczba mieszkań: " + ApartmentsList.Apartments.Count().ToString();
                bsApartments.ResetBindings(false);
                er_CodeRepeat.Clear();
                txt_LastName.Clear();
                txt_Code.Clear();
                numUpDown_Number.Value = ApartmentsList.Apartments.Count() + 1;
                txt_RepeatCode.Clear();
            }
            else
            {
                if (errorMessage.Length > 0)
                    MessageBox.Show(errorMessage.ToString(), "Nieprawidłowe dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorMessage.Clear();
            }
        }

        //Final text boxes Validation; Raised when Add button is clicked
        private bool IsDataCorrect()
        {
            bool result = true;

            if (ApartmentsList.Apartments.Any(p => p.Number == numUpDown_Number.Value))
            {
                DialogResult res = MessageBox.Show("Podany numer mieszkania jest już na liście.\nPomimo to chcesz zapisać?", "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                result = res == DialogResult.Yes;
            }

            if (txt_Code.Text != txt_RepeatCode.Text)
            {
                errorMessage.Append("Wartosci kodu sa rozne.\n");
                result = false;
            }

            if (txt_Code.Text.Length < 4)
            {
                errorMessage.Append("Wymagana dlugosc kodu to 4 cyfry.\n");
                result = false;
            }


            if (string.IsNullOrEmpty(txt_LastName.Text) || string.IsNullOrEmpty(txt_Code.Text) || string.IsNullOrEmpty(txt_RepeatCode.Text))
            {
                errorMessage.Append("Wszystkie pola musza byc uzupelnione\n");
                result = false;
            }

            

            return result;
        }

        //Type-time events preventing from incorrect data input
        #region TextValidationErrors
        private void txt_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_Code_TextChanged(object sender, EventArgs e)
        {
            er_MinLength.SetError(txt_Code, "Kod musi być liczbą z zakresu 1000-9999");
            if (txt_Code.Text.Length == 4)
                er_MinLength.Clear();
        }

        private void txt_RepeatCode_TextChanged(object sender, EventArgs e)
        {
            if (txt_Code.Text == txt_RepeatCode.Text)
                er_CodeRepeat.Clear();
        }

        private void txt_LastName_TextChanged(object sender, EventArgs e)
        {
            if (txt_LastName.Text.Length > 0)
                er_MantadoryField.Clear();

            if (string.IsNullOrEmpty(txt_LastName.Text))
                er_MantadoryField.SetError(txt_LastName, "Pole nie moze byc puste.");
        }
        #endregion

        #endregion

        #region EditTab

       
        //Modify button
        private void btn_Modify_Click(object sender, EventArgs e)
        {
            if (IsEditDataCorrect())
            {
                int currentRowIndex = dataGridView1.CurrentRow.Index;
                ApartmentsList.Apartments[currentRowIndex] = 
                    new Apartment(
                                    txt_EditLastName.Text,
                                    (int)numUpDown_EditNumber.Value,
                                    Int32.Parse(txt_EditCode.Text));

                lbl_NumberOfResidents.Text = "Liczba mieszkań: " + ApartmentsList.Apartments.Count().ToString();
                bsApartments.ResetBindings(false);
                er_CodeRepeat.Clear();
                txt_EditLastName.Clear();
                txt_EditCode.Clear();
                txt_EditRepeatCode.Clear();
            }
            else
            {
                if(errorMessage.Length > 0)
                    MessageBox.Show(errorMessage.ToString(), "Nieprawidłowe dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorMessage.Clear();
            }
        }

        //Final text boxes Validation; Raised when Edit button is clicked
        private bool IsEditDataCorrect()
        {
            bool result = true;

            if (ApartmentsList.Apartments.Any(p => p.Number == numUpDown_EditNumber.Value))
            {
                DialogResult res = MessageBox.Show("Podany numer mieszkania jest już na liście.\nPomimo to chcesz zapisać?", "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                result = res == DialogResult.Yes;
            }

            if (txt_EditCode.Text != txt_EditRepeatCode.Text)
            {
                errorMessage.Append("Wartosci kodu sa rozne.\n");
                result = false;
            }

            if (txt_EditCode.Text.Length < 4)
            {
                errorMessage.Append("Wymagana dlugosc kodu to 4 cyfry.\n");
                result = false;
            }


            if (string.IsNullOrEmpty(txt_EditLastName.Text) || string.IsNullOrEmpty(txt_EditCode.Text) || string.IsNullOrEmpty(txt_EditRepeatCode.Text))
            {
                errorMessage.Append("Wszystkie pola musza byc uzupelnione\n");
                result = false;
            }


            return result;
        }

        //Changing selection chagnes contetns of text boxes fileds in Edit and Remove Tab Control
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string lastname = dataGridView1.CurrentRow.Cells["col_LastName"].Value.ToString();
            string number = dataGridView1.CurrentRow.Cells["col_Number"].Value.ToString();
            string code = dataGridView1.CurrentRow.Cells["col_Code"].Value.ToString();

            txt_EditLastName.Text =  lastname;
            numUpDown_EditNumber.Value =  Convert.ToDecimal(number);
            txt_EditCode.Text = code;

            lbl_RemoveNumber.Text = "Numer mieszkania: " + number;
            lbl_RemoveLastName.Text = "Nazwisko: " + lastname;
            lbl_RemoveCode.Text = "Kod: " + code;


        }


        //Type-time events preventing from incorrect data input
        #region TextValidationErrors
        private void txt_EditLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_EditCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_EditCode_TextChanged(object sender, EventArgs e)
        {
            er_MinLength.SetError(txt_EditCode, "Kod musi być liczbą z zakresu 1000-9999");
            if (txt_EditCode.Text.Length == 4)
                er_MinLength.Clear();
        }

        private void txt_EditRepeatCode_TextChanged(object sender, EventArgs e)
        {
            if (txt_EditCode.Text == txt_EditRepeatCode.Text)
                er_CodeRepeat.Clear();
        }

        private void txt_EditLastName_TextChanged(object sender, EventArgs e)
        {
            if (txt_EditLastName.Text.Length > 0)
                er_MantadoryField.Clear();

            if (string.IsNullOrEmpty(txt_EditLastName.Text))
                er_MantadoryField.SetError(txt_EditLastName, "Pole nie moze byc puste.");
        }



        #endregion

        #endregion

        //remove tab
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dataGridView1.CurrentRow.Index;
            ApartmentsList.Apartments.RemoveAt(currentRowIndex);
            bsApartments.ResetBindings(false);
            lbl_NumberOfResidents.Text = "Liczba mieszkań: " + ApartmentsList.Apartments.Count().ToString();

        }

        
    }
}
