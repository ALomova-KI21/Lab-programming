using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    // Что-то типо модэл
    public class IncomeController
    {
        private List<Income> _finances = new List<Income>();
        private string _filePath = "/Users/Александра/Documents/Учёба/Технологии и методы программирования/test.txt";
        private Form1 _view;

        public IncomeController(Form1 view)
        {
            _view = view;
        }

        public void LoadData()
        {
            _finances.Clear();
            using (StreamReader file = new StreamReader(_filePath))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (line.StartsWith("Активный:"))
                    {
                        Active activeIncome = new Active();
                        activeIncome.Read(line);
                        _finances.Add(activeIncome);
                    }
                    else if (line.StartsWith("Пассивный:"))
                    {
                        Passive passiveIncome = new Passive();
                        passiveIncome.Read(line);
                        _finances.Add(passiveIncome);
                    }
                }
            }
            UpdateView();
        }

        public void SaveData()
        {
            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                foreach (var income in _finances)
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

        public void AddIncome()
        {
            AddIncomeForm addForm = new AddIncomeForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Income newIncome = addForm.GetNewIncome();
                if (newIncome != null)
                {
                    _finances.Add(newIncome);
                    UpdateView();
                }
            }
        }

        public void DeleteIncome(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < _finances.Count)
            {
                _finances.RemoveAt(rowIndex);
                UpdateView();
            }
        }

        private void UpdateView()
        {
            _view.DisplayData(_finances);
        }
        public void ExecuteCommands(List<string> commands)
        {
            foreach (string command in commands)
            {
                string[] parts = command.Trim().Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 0)
                {
                    string commandType = parts[0].ToUpper();
                    string commandArgs = parts.Length > 1 ? parts[1] : "";

                    switch (commandType)
                    {
                        case "ADD":
                            AddObjectCommand(commandArgs);
                            break;
                        case "REM":
                            RemoveObjectCommand(commandArgs);
                            break;
                        case "SAVE":
                            SaveDataCommand(commandArgs);
                            break;
                        default:
                            MessageBox.Show($"Неизвестная команда: {commandType}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
            }
            UpdateView();
        }

        private void AddObjectCommand(string commandArgs)
        {
            if (commandArgs.StartsWith("Активный:") || commandArgs.StartsWith("Пассивный:"))
            {
                if (commandArgs.StartsWith("Активный:"))
                {
                    Active activeIncome = new Active();
                    activeIncome.Read(commandArgs);
                    _finances.Add(activeIncome);
                }
                else
                {
                    Passive passiveIncome = new Passive();
                    passiveIncome.Read(commandArgs);
                    _finances.Add(passiveIncome);
                }
            }
            else
            {
                MessageBox.Show("Неверный формат команды ADD. Укажите тип объекта (Активный или Пассивный).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RemoveObjectCommand(string condition)
        {
            List<Income> itemsToRemove = new List<Income>();
            foreach (var income in _finances)
            {
                if (EvaluateCondition(income, condition))
                {
                    itemsToRemove.Add(income);
                }
            }

            foreach (var item in itemsToRemove)
            {
                _finances.Remove(item);
            }
        }

        private bool EvaluateCondition(Income income, string condition)
        {
            condition = condition.Trim();
            string[] parts = condition.Split(new char[] { ' ', '<', '>', '=', '!' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 2)
            {
                return false;
            }

            string propertyName = parts[0].Trim();
            string operation = "";
            if (condition.Contains("<") || condition.Contains(">") || condition.Contains("=") || condition.Contains("!"))
            {
                operation = condition.FirstOrDefault(c => c == '<' || c == '>' || c == '=' || c == '!').ToString();
            }
            string value = parts[1].Trim();

            switch (propertyName)
            {
                case "amounte":
                    int amountValue = int.Parse(value);
                    return EvaluateIntCondition(income.Amounte, amountValue, operation);
                case "hours":
                    if (income is Active active)
                    {
                        int hoursValue = int.Parse(value);
                        return EvaluateIntCondition(active.Hours, hoursValue, operation);
                    }
                    return false;
                case "payer":
                    if (income is Passive passive)
                    {
                        return passive.Payer == value;
                    }
                    return false;
                case "source":
                    return income.Source == value;
                case "date":
                    return income.Date == value;
                default:
                    return false;
            }
        }

        private bool EvaluateIntCondition(int propertyValue, int conditionValue, string operation)
        {
            switch (operation)
            {
                case "<":
                    return propertyValue < conditionValue;
                case ">":
                    return propertyValue > conditionValue;
                case "=":
                    return propertyValue == conditionValue;
                default:
                    return false;
            }
        }

        private void SaveDataCommand(string filename)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                string saveFilePath = Path.Combine(Path.GetDirectoryName(_filePath), filename.Trim());

                using (StreamWriter writer = new StreamWriter(saveFilePath))
                {
                    foreach (var income in _finances)
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
        }

        public string GetFilePath()
        {
            return _filePath;
        }
    }
}
