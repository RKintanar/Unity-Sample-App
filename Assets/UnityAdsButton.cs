using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class UnityAdsButton : MonoBehaviour {

    //onGUI
    void OnGUI()
    {
        Rect buttonRect = new Rect(10, 10, 150, 50);
        string buttonText = Advertisement.IsReady() ? "Show Ad" : "Waiting...";

        if (GUI.Button(buttonRect, buttonText))
        {
            Advertisement.Show();
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
