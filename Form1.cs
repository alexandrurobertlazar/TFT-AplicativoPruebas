using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TFTService;

namespace TestsTFTForms
{
    public partial class Form1 : Form
    {
        private static string baseDirectory = "";
        public Form1()
        {
            InitializeComponent();
        }
        /**
         * <summary>Botón para ejecutar las pruebas.</summary>
         */
        private async void button1_Click(object sender, EventArgs e)
        {
            testNumbersButton.Enabled = false;
            MainServiceClient serviceClient = new MainServiceClient();
            if (baseDirectory == "")
            {
                errorsLabel.Text = "Error: No se ha seleccionado ninguna carpeta.";
                return;
            }
            StreamReader srInput = null;
            StreamWriter srOutput = null;
            try
            {
                srInput = new StreamReader(baseDirectory + @"\entrada.txt");
                srOutput = new StreamWriter(baseDirectory + @"\salida.txt", false, Encoding.UTF8);
                string[] numbers = srInput.ReadToEnd().Split("\r\n");
                testsProgressBar.Value = 0;
                testsProgressBar.Maximum = numbers.Length;
                foreach (string number in numbers)
                {
                    testsProgressBar.Increment(1);
                    if (!number.Contains(":")) break;
                    string[] numberForms = number.Split(":");
                    string resp = await serviceClient.ComputeNumberAsync(numberForms[1]);
                    if (resp != numberForms[0])
                    {
                        srOutput.WriteLine("Caso " + numberForms[1] + " ha fallado. Esperado: " + numberForms[0] + "; Actual: " + resp);
                    }
                }
                testNumbersButton.Enabled = true;
                srInput.Close();
                srOutput.Close();
            } catch (Exception ex)
            {
                errorsLabel.Text = ex.Message;
                if (srInput != null) srInput.Close();
                if (srOutput != null) srOutput.Close();
                testNumbersButton.Enabled = true;
            }       
            
        }
        /**
         * <summary>Botón para elegir fichero de entrada.</summary>
         */
        private void buttonInputFile_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                baseDirectory = folderBrowserDialog1.SelectedPath;
                folderTextBox.Text = baseDirectory;
                if (baseDirectory != "")
                {
                    testNumbersButton.Enabled = true;
                } else
                {
                    testNumbersButton.Enabled = false;
                }
                
            }
        }
    }
}
