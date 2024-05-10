using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Diagnostics;

namespace CSCompiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion",frameworkTBox.Text} });
            CompilerParameters parameters = new CompilerParameters(new string[] {"mscorlib.dll","System.Core.dll"},nameTextBox.Text,true);
            parameters.GenerateExecutable=true;

            try
            {
                CompilerResults results = provider.CompileAssemblyFromSource(parameters, codBox.Text);
                if (results.Errors.HasErrors)
                {
                    foreach (CompilerError error in results.Errors.Cast<CompilerError>())
                    {
                        statusBox.Text += $"Строка {error.Line}:     {error.ErrorText}";
                    }
                }
                else
                {
                    statusBox.Text = "---------Сборка завершена------------";
                    Process.Start($"{Application.StartupPath}/{nameTextBox.Text}");
                }


            }
            catch (Exception ex)
            {
                statusBox.Text=ex.Message;
              
            }
              
          


        }
    }
}
