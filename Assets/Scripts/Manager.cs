using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    //public Button ourDebugger;
    public Text ourText;

    public GameObject[] models;
    public GameObject [] images;
    private int planindex;
    private int imageindex;

    
    


	// Use this for initialization
	void Start () {

        planindex = 0;
        imageindex = 0;
        //ourText = ourDebugger.GetComponentInChildren<Text>();

       
        for (int i = 0; i < models.Length; i++)
        {
            models[i].SetActive(false);
        }

        for (int i = 0; i < images.Length; i++)
        {
            images[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update(){
        if (images.Length == 0)
        {
            if (Input.touchCount > 0)
            {
                Touch fingertouch = Input.GetTouch(0);

                if (fingertouch.phase == TouchPhase.Ended)
                {

                    //ourText.text = "finger position = " + fingertouch.position.x.ToString();
                    //toggle through models
                    for (int i = 0; i < models.Length; i++)
                    {
                        if (i != planindex)
                        {
                            models[i].SetActive(false);
                        }
                        else
                        {
                            models[i].SetActive(true);
                        }

                    }
                    if (planindex >= models.Length)
                    {
                        planindex = 0;
                    }
                    else
                    {
                        planindex++;
                    }


                }
            }
        }
        else
        {
            if (Input.touchCount > 0)
            {
                Touch fingertouch = Input.GetTouch(0);

                if (fingertouch.phase == TouchPhase.Ended)
                {
                    if (fingertouch.position.x > Screen.width / 2)
                    {
                        //ourText.text = "finger position = " + fingertouch.position.x.ToString();
                        //toggle through models
                        for (int i = 0; i < models.Length; i++)
                        {
                            if (i != planindex)
                            {
                                models[i].SetActive(false);
                            }
                            else
                            {
                                models[i].SetActive(true);
                            }

                        }
                        if (planindex >= models.Length)
                        {
                            planindex = 0;
                        }
                        else
                        {
                            planindex++;
                        }
                    }
                    else// if (fingertouch.position.x <= Screen.width / 2)
                        //else
                    {
                        //ourText.text = "finger position = " + fingertouch.position.x.ToString();
                        for (int i = 0; i < images.Length; i++)
                        {
                            if (i != imageindex)
                            {
                                images[i].SetActive(false);
                            }
                            else
                            {
                                images[i].SetActive(true);
                            }

                        }
                        if (imageindex >= images.Length)
                        {
                            imageindex = 0;
                        }
                        else
                        {
                            imageindex++;
                        }
                    }
                }
            }

        }

        if (Input.GetButtonDown("fire1"))
        {
            for (int i = 0; i < images.Length; i++)
            {
                if (i != imageindex)
                {
                    images[i].gameObject.SetActive(false);
                }
                else
                {
                    images[i].gameObject.SetActive(true);
                }

            }
            if (imageindex >= images.Length)
            {
                imageindex = 0;
            }
            else
            {
                imageindex++;
            }
        }
       






    }
       /* for (int j = 0; j < Input.touchCount; ++j)
        {

            //Touch touch = Input.GetTouch(0);
            if (Input.GetTouch(j).position.x > Screen.width / 2)
            {

                //toggle through models
                for (int i = 0; i < models.Length; i++)
                {
                    if (i != planindex)
                    {
                        models[i].SetActive(false);
                    }
                    else
                    {
                        models[i].SetActive(true);
                    }

                }
                if (planindex >= models.Length)
                {
                    planindex = 0;
                }
                else
                {
                    planindex++;
                }
            }
            if (Input.GetTouch(j).position.x <= Screen.width / 2)
            {
                if (otherImageIsOn == false)
                {
                    otherImage.SetActive(true);
                    otherImageIsOn = true;
                }
                else
                {
                    otherImage.SetActive(false);
                    otherImageIsOn = false;
                }
            }

        }
    }
        /*

        if (Input.touchCount == 1)
        {

            //toggle through models
            for (int i = 0; i < models.Length; i++)
            {
                if (i != planindex)
                {
                    models[i].SetActive(false);
                }
                else
                {
                    models[i].SetActive(true);
                }

            }
            if (planindex >= models.Length)
            {
                planindex = 0;
            }
            else
            {
                planindex++;
            }
        }
        if (Input.touchCount == 2)
        {
            if (otherImageIsOn == false)
            {
                otherImage.SetActive(true);
                otherImageIsOn = true;
            }
            else
            {
                otherImage.SetActive(false);
                otherImageIsOn = false;
            }
        }
    }


*/
    


}
