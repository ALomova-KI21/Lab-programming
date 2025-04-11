using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Lab2;

namespace Lab2 
{
    public partial class Form1 : Form
    {
        private List<Income> finances = new List<Income>();
        private string filePath = "/Users/Александра/Documents/Учёба/Технологии и методы программирования/test.txt";

        public Form1()
        {
            InitializeComponent();
        }


        private void LoadDataFromFile()
        {
            finances.Clear();
            dataGridView1.Rows.Clear();


            using (StreamReader file = new StreamReader(filePath))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (line.StartsWith("Активный:"))
                    {
                        Active activeIncome = new Active();
                        activeIncome.Read(line);
                        finances.Add(activeIncome);
                    }
                    else if (line.StartsWith("Пассивный:"))
                    {
                        Passive passiveIncome = new Passive();
                        passiveIncome.Read(line);
                        finances.Add(passiveIncome);
                    }
                }
            }
            UpdateDataGridView();

        }

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var income in finances)
            {
                if (income is Active active)
                {
                    dataGridView1.Rows.Add(
                        "Активный",
                        active.Date,
                        active.Source,
                        active.Amounte,
                        active.Hours,
                        "",
                        ""
                        );
                }
                else if (income is Passive passive)
                {
                    dataGridView1.Rows.Add(
                        "Пассивный",
                        passive.Date,
                        passive.Source,
                        passive.Amounte,
                        "",
                        passive.Payer,
                        passive.Period
                    );
                }
            }
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadDataFromFile();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                    finances.RemoveAt(selectedRowIndex);
                    UpdateDataGridView();
            }
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            AddIncomeForm addForm = new AddIncomeForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Income newIncome = addForm.GetNewIncome();
                if (newIncome != null)
                {
                    finances.Add(newIncome);
                    UpdateDataGridView();
                }
            }
        }

        private void SaveDataToFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var income in finances)
                {
                    if (income is Active active)
                    {
                        writer.WriteLine($"Активный: {active.Date} {active.Source} {active.Amounte} {active.Hours}");
                    }
                    else if (income is Passive passive)
                    {
                        writer.WriteLine($"Пассивный: {passive.Date} {passive.Source} {passive.Amounte} {passive.Payer} {passive.Period}");
                    }
                }
            }
        }

        private void buttonUpdateFile_Click(object sender, EventArgs e)
        {
            SaveDataToFile();
        }
    }
}
