
namespace TestForUP01.View
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.estimation = new System.Windows.Forms.Label();
            this.endTest = new MaterialSkin.Controls.MaterialRaisedButton();
            this.correctAnswers = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(78, 32);
            this.title.TabIndex = 0;
            this.title.Text = "label1";
            // 
            // estimation
            // 
            this.estimation.AutoSize = true;
            this.estimation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.estimation.Location = new System.Drawing.Point(3, 40);
            this.estimation.Name = "estimation";
            this.estimation.Size = new System.Drawing.Size(78, 32);
            this.estimation.TabIndex = 1;
            this.estimation.Text = "label1";
            // 
            // endTest
            // 
            this.endTest.Depth = 0;
            this.endTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.endTest.Location = new System.Drawing.Point(3, 329);
            this.endTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.endTest.Name = "endTest";
            this.endTest.Primary = true;
            this.endTest.Size = new System.Drawing.Size(794, 48);
            this.endTest.TabIndex = 2;
            this.endTest.Text = "Завершить";
            this.endTest.UseVisualStyleBackColor = true;
            this.endTest.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // correctAnswers
            // 
            this.correctAnswers.AutoSize = true;
            this.correctAnswers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correctAnswers.Location = new System.Drawing.Point(3, 80);
            this.correctAnswers.Name = "correctAnswers";
            this.correctAnswers.Size = new System.Drawing.Size(0, 32);
            this.correctAnswers.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 616F));
            this.tableLayoutPanel1.Controls.Add(this.correctAnswers, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.estimation, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.endTest, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 380);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ResultForm";
            this.Padding = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.Text = "Результат";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label estimation;
        private MaterialSkin.Controls.MaterialRaisedButton endTest;
        private System.Windows.Forms.Label correctAnswers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}