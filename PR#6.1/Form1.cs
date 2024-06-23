using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(surnameTextBox.Text) & !String.IsNullOrEmpty(nametextBox.Text) & !String.IsNullOrEmpty(patronymicTextBox.Text) & !String.IsNullOrEmpty(ageTextBox.Text))
            {
                if (ambulanceRadioButton.Checked == true)
                {
                    Ambulance ambulance = new Ambulance();
                    ambulance.ShowDialog();
                }
                else if (medicineRadioButton.Checked == true)
                {
                    Medicine medicine = new Medicine();
                    medicine.ShowDialog();
                }
                else if (medicalExaminationRadioButton.Checked == true)
                {
                    MedicalExamination medical = new MedicalExamination();
                    medical.ShowDialog();
                }
                
            }
        }

        private void patronymicTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
