using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab4;
using System.Diagnostics;

namespace Lab4 
{
    public partial class Form1 : Form
    {
        private IncomeController _controller;
        public Form1()
        {
            InitializeComponent();
            _controller = new IncomeController(this);

        }

        // Метод для отображения данных в DataGridView (вызывается контроллером)
        public void DisplayData(List<Income> incomes)
        {
            dataGridView1.Rows.Clear();
            foreach (var income in incomes)
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
            _controller.LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                _controller.DeleteIncome(selectedRowIndex); // Удаляем доход через контроллер
            }
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            _controller.AddIncome();
        }

        private void buttonUpdateFile_Click(object sender, EventArgs e)
        {
            _controller.SaveData();
        }

        private void buttonCommandFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Выберите файл команд";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string commandFilePath = openFileDialog.FileName;
                ProcessCommandFile(commandFilePath);
            }
        }

        private void ProcessCommandFile(string filePath)
        {
            List<string> commands = File.ReadAllLines(filePath).ToList();
            _controller.ExecuteCommands(commands);
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileForViewing();
        }

        private void OpenFileForViewing()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Выберите файл данных для просмотра";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                Process.Start(filePath);
            }
        }
    }
}
