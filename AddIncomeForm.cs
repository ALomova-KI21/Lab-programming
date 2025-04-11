using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Lab2;

namespace Lab2
{
    public partial class AddIncomeForm : Form
    {
        private Income newIncome;

        public AddIncomeForm()
        {
            InitializeComponent();
        }


        public Income GetNewIncome()
        {
            return newIncome;
        }

        private void AddIncomeForm_Load_1(object sender, EventArgs e)
        {
            comboBoxType.Items.Add("Активный");
            comboBoxType.Items.Add("Пассивный");
            comboBoxType.SelectedIndex = 0;
        }
        private void buttonOk_Click_1(object sender, EventArgs e)
        {
            string type = comboBoxType.SelectedItem?.ToString();
            string date = textBoxDate.Text;
            string source = textBoxSource.Text;
            int amount = Convert.ToInt32(textBoxAmount.Text);
            int hours = Convert.ToInt32(textBoxAmount.Text);

            if (type == "Активный")
            {

                newIncome = new Active()
                {
                    Date = date,
                    Source = source,
                    Amounte = amount,
                    Hours = hours
                };
            }
            else if (type == "Пассивный")
            {
                string payer = textBoxPayer.Text;
                string period = textBoxPeriod.Text;
                newIncome = new Passive()
                {
                    Date = date,
                    Source = source,
                    Amounte = amount,
                    Payer = payer,
                    Period = period
                };
            }
            else
            {
                MessageBox.Show("Выберите тип дохода.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboBoxType.SelectedItem?.ToString();

            labelHours.Visible = (selectedType == "Активный");
            textBoxHours.Visible = (selectedType == "Активный");

            labelPayer.Visible = (selectedType == "Пассивный");
            textBoxPayer.Visible = (selectedType == "Пассивный");
            labelPeriod.Visible = (selectedType == "Пассивный");
            textBoxPeriod.Visible = (selectedType == "Пассивный");
        }
    }
}
