namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEngine.UI;

    public class ButtonHandler : MonoBehaviour   {

        ChangeText instance;
        DecayScript decay;
        public GameObject canvasObject;
        public GameObject decayCounter;

        private void Start()
        {

            GetComponent<VRTK_Button>().events.OnPush.AddListener(handlePush);
            //instance = GetComponent<ChangeText>();
            canvasObject.GetComponent<ChangeText>().enabled = true;
            instance = canvasObject.GetComponent<ChangeText>();
            decay = decayCounter.GetComponent<DecayScript>();
        }

        private void handlePush()
        { 
            //instance.enabled = true;    
            instance.ChangeTextS();
            decay.incrementCounter();
        }
    }
}