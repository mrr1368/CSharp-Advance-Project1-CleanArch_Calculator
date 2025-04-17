using CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputProcessor;
using System;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.DisplayManagers
{
    /// <summary>
    /// Responsible for managing and displaying input and result data in the calculator UI.
    /// </summary>
    public class DisplayManager
    {
        private readonly InputProcessor.InputProcessor _inputProcessor;

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayManager"/> class.
        /// </summary>
        /// <param name="inputProcessor">The input processor used to retrieve input and result data.</param>
        public DisplayManager(InputProcessor.InputProcessor inputProcessor)
        {
            _inputProcessor = inputProcessor;
        }

        /// <summary>
        /// Retrieves the current input data to be displayed in the calculator UI.
        /// </summary>
        /// <returns>The input string entered by the user.</returns>
        public string DisplayInputData()
        {
            string inputData = _inputProcessor.GetInput();
            return inputData;
        }

        /// <summary>
        /// Retrieves the result data to be displayed in the calculator UI.
        /// </summary>
        /// <returns>The result string calculated based on the input.</returns>
        public string DisplayResultData()
        {
            string resultData = _inputProcessor.GetResult();
            return resultData;
        }
    }
}
