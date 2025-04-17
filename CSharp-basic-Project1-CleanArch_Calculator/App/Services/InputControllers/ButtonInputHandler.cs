using CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputHandler
{
    /// <summary>
    /// Handles input from buttons on the calculator's UI.
    /// The class receives input from buttons and passes it to the input processor for further handling.
    /// </summary>
    public class ButtonInputHandler
    {
        private readonly InputProcessor.InputProcessor _inputProcessor;

        /// <summary>
        /// Constructor to inject the input processor dependency.
        /// </summary>
        /// <param name="inputProcessor">An instance of the input processor to handle input processing.</param>
        public ButtonInputHandler(InputProcessor.InputProcessor inputProcessor)
        {
            _inputProcessor = inputProcessor;
        }

        /// <summary>
        /// Manages button click events and forwards the input to the input processor.
        /// </summary>
        /// <param name="sender">The object that triggered the button click event.</param>
        public void ButtonManager(object sender)
        {
            // Check if the sender is a button and its Tag contains the input string
            if (sender is Button button && button.Tag is string input && !string.IsNullOrEmpty(input))
            {
                // Forward the input to the input processor for further handling
                _inputProcessor.AddInput(input);
            }
        }
    }
}
