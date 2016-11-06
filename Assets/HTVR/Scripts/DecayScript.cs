using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DecayScript : MonoBehaviour {

    double progress;
    public Text bar;
    int displayProgress;
    bool decreases;

	// Use this for initialization
	void Start () {
        progress = 0;
        decreases = true;
	}
	
	// Update is called once per frame
	void Update () {
	    if (progress > 0 && decreases)
        {
            progress -= .025;
        } else if (progress < 0)
        {
            progress = 0;
        }
        displayProgress = (int)progress;
        if (displayProgress == 100)
        {
            bar.text = "HACK COMPLETED";
        } else
        {
            bar.text = "HACKING IN PROGRESS: " + displayProgress.ToString() + "% HACKED";
        }
	}

    public void incrementCounter()
    {
        if ( GameObject.Find("Enemy(Clone)") == null)
        {
            progress += 1.5;//it exists
        }
       
        
        if(progress > 100)
        {
            progress = 100;
            decreases = false;
        }
        //Debug.Log(progress);
    }
}
