using CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputHandler;
using CSharp_basic_Project1_CleanArch_Calculator.App.Services.DisplayManagers;
using CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputControllers;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputEventHandler
{
    /// <summary>
    /// Handles the events triggered by input sources such as the keyboard or buttons.
    /// This class is responsible for processing input data and invoking the appropriate actions.
    /// </summary>
    public class InputEventHandler
    {
        private readonly KeyboardInputHandler _keyboardInputHandler;
        private readonly ButtonInputHandler _buttonInputHandler;
        private readonly DisplayManager _displayManager;

        /// <summary>
        /// Event triggered when the data has been processed and is ready to be displayed.
        /// </summary>
        public event Action<string, string>? OnDataProcessed;

        /// <summary>
        /// Event triggered when the exit process is requested.
        /// </summary>
        public event Action? OnExitRequested;

        /// <summary>
        /// Constructor to inject dependencies for keyboard, button handlers, and display manager.
        /// </summary>
        /// <param name="keyboardInputHandler">The handler for keyboard input.</param>
        /// <param name="buttonInputHandler">The handler for button input.</param>
        /// <param name="displayManager">The manager for displaying input and result data.</param>
        public InputEventHandler(KeyboardInputHandler keyboardInputHandler, ButtonInputHandler buttonInputHandler,
                                 DisplayManager displayManager)
        {
            _keyboardInputHandler = keyboardInputHandler;
            _buttonInputHandler = buttonInputHandler;
            _displayManager = displayManager;

            // Subscribe to the exit event from the keyboard input handler.
            _keyboardInputHandler.ExitHandler += ExitApplication;
        }

        /// <summary>
        /// Event handler for key press events from the keyboard.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The key event arguments containing key information.</param>
        public void KeyDownEventHandler(object? sender, KeyEventArgs e)
        {
            // If the key press is processed successfully, invoke data processing.
            if (_keyboardInputHandler.KeyboardManager(e.KeyCode))
            {
                ProcessData();
            }
        }

        /// <summary>
        /// Event handler for button click events.
        /// </summary>
        /// <param name="sender">The object that triggered the event (the button).</param>
        /// <param name="e">The event arguments containing information about the button click.</param>
        public void ButtonHandler(object? sender, EventArgs e)
        {
            // Validate that the sender is not null to avoid runtime errors.
            if (sender == null)
            {
                MessageBox.Show("Error: The sender cannot be null. Please try again.",
                        "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Process the button input.
            _buttonInputHandler.ButtonManager(sender);
            ProcessData();
        }

        /// <summary>
        /// Processes the input and result data, then triggers the OnDataProcessed event.
        /// </summary>
        private void ProcessData()
        {
            string inputData = _displayManager.DisplayInputData();
            string resultData = _displayManager.DisplayResultData();

            // Invoke the event to notify that data has been processed.
            OnDataProcessed?.Invoke(inputData, resultData);
        }

        /// <summary>
        /// Handles the exit process when triggered by the keyboard input handler.
        /// </summary>
        public void ExitApplication()
        {
            // Trigger the exit requested event.
            OnExitRequested?.Invoke();
        }
    }
}
