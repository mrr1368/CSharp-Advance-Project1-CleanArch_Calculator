using CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputHandler
{
    public class ButtonInputHandler(InputProcessorTest inputProcessor)
    {
        private readonly InputProcessorTest _inputProcessor = inputProcessor;


        public void ButtonManager(object sender)
        {
            if (sender is Button button && button.Tag is string input && !string.IsNullOrEmpty(input))
            {
                _inputProcessor.AddInput(input);
            }
        }
    }
}
