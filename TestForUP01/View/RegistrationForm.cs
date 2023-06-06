using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;
using TestForUP01.Model;
using TestForUP01.Utils;
using TestForUP01.View;

namespace TestForUP01
{
    public partial class RegistrationForm : MaterialForm
    {
        private const string classesFileName = "classes.txt";

        public RegistrationForm()
        {
            InitializeComponent();
            FormUtils.InitDefaultDesignToForm(this);

            Load += RegistrationForm_Load;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            var content = File.ReadAllText(classesFileName);
            var splitContent = content.Split("\r\n");
            selectClassComboBox.Items.AddRange(splitContent);
        }

        private void startTestBtn_Click(object sender, EventArgs e)
        {
            var className = (string) selectClassComboBox.SelectedItem;
            var fio = fioTextBox.Text;

            if (CheckInputErrors(fio, className))
            {
                MessageBox.Show("Ошибка при вводе данных", "Ошибка");
                return;
            }

            if (!IsCorrectFormatFio(fio))
            {
                MessageBox.Show("Неккоретный формат ФИО", "Ошибка");
                return;
            }

            var splitFio = fio.Split(" ");
            var classNameModel = new ClassModel(className);
            var userModel = new UserModel(splitFio[0], splitFio[1], splitFio[2], classNameModel);

            var testForm = new TestForm(userModel);
            Hide();
            testForm.Show();
            testForm.Text = $"Тест по истории за 5 класс";
        }

        private bool IsCorrectFormatFio(string fio)
        {
            var splitFio = fio.Split(" ");
            if (splitFio.Length < 3) return false;
            return true;
        }

        private bool CheckInputErrors(string fio, string className)
        {
            if (fio == string.Empty) return true;
            if (className == null) return true;

            return false;
        }

        private void exitApplicationBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void documentationBtn_Click(object sender, EventArgs e)
        {
            var documentationForm = new DocumentationForm();
            documentationForm.Show();
            Hide();
        }
    }
}
