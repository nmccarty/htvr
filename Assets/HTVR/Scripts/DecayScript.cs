using UnityEngine;
using System.Collections;

public class DecayScript : MonoBehaviour {

    float progress;

	// Use this for initialization
	void Start () {
        progress = 0;
	}
	
	// Update is called once per frame
	void Update () {
	    if (progress > 0)
        {
            progress -= .05f;
        } else if (progress < 0)
        {
            progress = 0f;
        }
	}

    public void incrementCounter()
    {
        progress += 1.5f;
        Debug.Log(progress);
    }
}
