using MaterialSkin.Controls;
using System.Windows.Forms;
using TestForUP01.Utils;

namespace TestForUP01.View
{
    public partial class DocumentationForm : MaterialForm
    {
        public DocumentationForm()
        {
            InitializeComponent();
            FormUtils.InitDefaultDesignToForm(this);
        }

        private void backButton_Click(object sender, System.EventArgs e)
        {
            Application.OpenForms[0].Show();
            Close();
        }
    }
}
