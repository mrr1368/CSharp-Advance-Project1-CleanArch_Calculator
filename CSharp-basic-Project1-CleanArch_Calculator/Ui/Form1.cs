using CSharp_basic_Project1_CleanArch_Calculator.App.Services.ErrorHandling;
using CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputEventHandler;
using System;

namespace CSharp_basic_Project1_CleanArch_Calculator
{
    public partial class Form1 : Form
    {
        private readonly InputEventHandler _inputEventHandler;

        public Form1(InputEventHandler inputEventHandler)
        {
            _inputEventHandler = inputEventHandler;
            InitializeComponent();

            this.KeyPreview = true;
            this.txtInput.Enabled = false;
            this.txtResult.Enabled = false;

            _inputEventHandler.OnDataProcessed += UpdateTextBoxes;
            _inputEventHandler.OnExitRequested += ExitApplication;

            this.KeyDown += Form1_KeyDown;

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Click += Button_Click;
                }
            }
        }


        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            SafeExecute(() => _inputEventHandler.KeyDownEventHandler(sender, e));
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            SafeExecute(() => _inputEventHandler.ButtonHandler(sender, e));
        }

        private void SafeExecute(Action action)
        {
            try
            {
                action();
            }
            catch (InvalidExpressionException ex)
            {
                MessageBox.Show(ex.Message, "خطای محاسباتی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطای غیرمنتظره: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTextBoxes(string inputData, string resultData)
        {
            txtInput.Text = inputData;
            txtResult.Text = resultData;
        }

        private void ExitApplication()
        {
            Application.Exit();
        }
    }
}
