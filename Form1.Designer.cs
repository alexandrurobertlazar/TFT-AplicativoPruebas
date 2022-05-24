
namespace TestsTFTForms
{
    partial class Form1
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
            this.testNumbersButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInputFile = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.errorsLabel = new System.Windows.Forms.Label();
            this.testsProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // testNumbersButton
            // 
            this.testNumbersButton.Enabled = false;
            this.testNumbersButton.Location = new System.Drawing.Point(123, 176);
            this.testNumbersButton.Name = "testNumbersButton";
            this.testNumbersButton.Size = new System.Drawing.Size(134, 23);
            this.testNumbersButton.TabIndex = 0;
            this.testNumbersButton.Text = "Realizar pruebas";
            this.testNumbersButton.UseVisualStyleBackColor = true;
            this.testNumbersButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // folderTextBox
            // 
            this.folderTextBox.Enabled = false;
            this.folderTextBox.Location = new System.Drawing.Point(43, 75);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(214, 23);
            this.folderTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carpeta con fichero de entrada:";
            // 
            // buttonInputFile
            // 
            this.buttonInputFile.Location = new System.Drawing.Point(278, 75);
            this.buttonInputFile.Name = "buttonInputFile";
            this.buttonInputFile.Size = new System.Drawing.Size(75, 23);
            this.buttonInputFile.TabIndex = 5;
            this.buttonInputFile.Text = "Elegir";
            this.buttonInputFile.UseVisualStyleBackColor = true;
            this.buttonInputFile.Click += new System.EventHandler(this.buttonInputFile_Click);
            // 
            // errorsLabel
            // 
            this.errorsLabel.AutoSize = true;
            this.errorsLabel.ForeColor = System.Drawing.Color.Red;
            this.errorsLabel.Location = new System.Drawing.Point(43, 111);
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Size = new System.Drawing.Size(0, 15);
            this.errorsLabel.TabIndex = 6;
            // 
            // testsProgressBar
            // 
            this.testsProgressBar.Location = new System.Drawing.Point(43, 136);
            this.testsProgressBar.Name = "testsProgressBar";
            this.testsProgressBar.Size = new System.Drawing.Size(310, 23);
            this.testsProgressBar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 211);
            this.Controls.Add(this.testsProgressBar);
            this.Controls.Add(this.errorsLabel);
            this.Controls.Add(this.buttonInputFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.testNumbersButton);
            this.Name = "Form1";
            this.Text = "Programa de pruebas - Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testNumbersButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInputFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label errorsLabel;
        private System.Windows.Forms.ProgressBar testsProgressBar;
    }
}

