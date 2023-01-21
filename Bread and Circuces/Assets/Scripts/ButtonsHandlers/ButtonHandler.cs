using UnityEngine;
using UnityEngine.UI;

namespace ButtonsHandlers
{
    public class ButtonHandler : MonoBehaviour
    {
        public bool State = false;
        public bool ActivationState;
        public Button Button;


        void Start()
        {
            ActivateDeactivateButton(false);
        }

        public void ActivateDeactivateButton(bool activationStateIn)
        {
            Debug.Log("Changed Button State");
            Button.interactable = activationStateIn;
        }

        public void resetButton()
        {
            State = false;
            ActivateDeactivateButton(false);
        }

        public void HandleClick()
        {
            State = !State;
        }
    
    }
}
