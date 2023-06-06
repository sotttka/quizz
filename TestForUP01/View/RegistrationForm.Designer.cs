namespace TestForUP01
{
    partial class RegistrationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startTestBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.fioTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.selectClassComboBox = new System.Windows.Forms.ComboBox();
            this.documentationBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.exitApplicationBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(116, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(107, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Класс";
            // 
            // startTestBtn
            // 
            this.startTestBtn.Depth = 0;
            this.startTestBtn.Location = new System.Drawing.Point(198, 294);
            this.startTestBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.startTestBtn.Name = "startTestBtn";
            this.startTestBtn.Primary = true;
            this.startTestBtn.Size = new System.Drawing.Size(243, 40);
            this.startTestBtn.TabIndex = 5;
            this.startTestBtn.Text = "Начать тест";
            this.startTestBtn.UseVisualStyleBackColor = true;
            this.startTestBtn.Click += new System.EventHandler(this.startTestBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(116, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите своё ФИО и выберите класс";
            // 
            // fioTextBox
            // 
            this.fioTextBox.Depth = 0;
            this.fioTextBox.Hint = "";
            this.fioTextBox.Location = new System.Drawing.Point(198, 166);
            this.fioTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.PasswordChar = '\0';
            this.fioTextBox.SelectedText = "";
            this.fioTextBox.SelectionLength = 0;
            this.fioTextBox.SelectionStart = 0;
            this.fioTextBox.Size = new System.Drawing.Size(243, 23);
            this.fioTextBox.TabIndex = 7;
            this.fioTextBox.UseSystemPasswordChar = false;
            // 
            // selectClassComboBox
            // 
            this.selectClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectClassComboBox.FormattingEnabled = true;
            this.selectClassComboBox.Location = new System.Drawing.Point(198, 237);
            this.selectClassComboBox.Name = "selectClassComboBox";
            this.selectClassComboBox.Size = new System.Drawing.Size(243, 23);
            this.selectClassComboBox.TabIndex = 8;
            // 
            // documentationBtn
            // 
            this.documentationBtn.Depth = 0;
            this.documentationBtn.Location = new System.Drawing.Point(198, 340);
            this.documentationBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.documentationBtn.Name = "documentationBtn";
            this.documentationBtn.Primary = true;
            this.documentationBtn.Size = new System.Drawing.Size(243, 40);
            this.documentationBtn.TabIndex = 9;
            this.documentationBtn.Text = "Справка";
            this.documentationBtn.UseVisualStyleBackColor = true;
            this.documentationBtn.Click += new System.EventHandler(this.documentationBtn_Click);
            // 
            // exitApplicationBtn
            // 
            this.exitApplicationBtn.Depth = 0;
            this.exitApplicationBtn.Location = new System.Drawing.Point(198, 386);
            this.exitApplicationBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitApplicationBtn.Name = "exitApplicationBtn";
            this.exitApplicationBtn.Primary = true;
            this.exitApplicationBtn.Size = new System.Drawing.Size(243, 40);
            this.exitApplicationBtn.TabIndex = 10;
            this.exitApplicationBtn.Text = "Выход";
            this.exitApplicationBtn.UseVisualStyleBackColor = true;
            this.exitApplicationBtn.Click += new System.EventHandler(this.exitApplicationBtn_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 440);
            this.Controls.Add(this.exitApplicationBtn);
            this.Controls.Add(this.documentationBtn);
            this.Controls.Add(this.selectClassComboBox);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startTestBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(650, 440);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton startTestBtn;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField fioTextBox;
        private System.Windows.Forms.ComboBox selectClassComboBox;
        private MaterialSkin.Controls.MaterialRaisedButton documentationBtn;
        private MaterialSkin.Controls.MaterialRaisedButton exitApplicationBtn;
    }
}

