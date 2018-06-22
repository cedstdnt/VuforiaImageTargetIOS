using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonForImagery : MonoBehaviour {

    public GameObject otherImage;
    private bool isOn;

	// Use this for initialization
	void Start () {

        otherImage.SetActive(false);
        isOn = false;
		
	}

    public void ImageToggle()
    {
        if (isOn == false)
        {
            otherImage.SetActive(true);
            isOn = true;
        }
        else
        {
            otherImage.SetActive(false);
            isOn = false;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
