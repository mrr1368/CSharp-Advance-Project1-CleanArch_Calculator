using CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.DisplayManagers
{
    public class DisplayManager(InputProcessor.InputProcessor inputProcessor)
    {
        private readonly InputProcessor.InputProcessor _inputProcessor = inputProcessor;


        public string DisplayInputData()
        {
            string inputData = _inputProcessor.GetInput();
            return inputData;
        }

        public string DisplayResultData()
        {
            string resultData = _inputProcessor.GetResult();
            return resultData;
        }

    }
}
