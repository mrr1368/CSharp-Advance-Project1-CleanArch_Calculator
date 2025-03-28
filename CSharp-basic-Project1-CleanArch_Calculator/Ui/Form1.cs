using CSharp_basic_Project1_CleanArch_Calculator.App.Services;

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

            this.KeyDown += _inputEventHandler.KeyDownEventHandler;

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Click += _inputEventHandler.ButtonHandler;
                }
            }
        }

        private void UpdateTextBoxes(string inputData, string resultData)
        {
            txtInput.Text = inputData;
            txtResult.Text = resultData;
        }
    }
}
