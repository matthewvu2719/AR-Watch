using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WatchSelect : MonoBehaviour
{

    public GameObject watch1;
    public GameObject watch2;
    public GameObject watch3;

    public GameObject window1;
    public GameObject window2;
    public GameObject window3;

    Animation w1;
    Animation w2;
    Animation w3;

    // Start is called before the first frame update
    void Start()
    {
        w1 = window1.GetComponent<Animation>();
        w2 = window2.GetComponent<Animation>();
        w3 = window3.GetComponent<Animation>();
    }

    public void Watch1Clicked()
    {
        watch1.SetActive(true);
        watch2.SetActive(false);
        watch3.SetActive(false);
        w1["w1"].speed =1;
        w1.Play();
    }

    public void Watch2Clicked()
    {
        watch1.SetActive(false);
        watch2.SetActive(true);
        watch3.SetActive(false);
        w2["w2"].speed = 1;
        w2.Play();
    }

    public void Watch3Clicked()
    {
        watch1.SetActive(false);
        watch2.SetActive(false);
        watch3.SetActive(true);
        w3["w3"].speed = 1;
        w3.Play();
    }

    public void CloseClicked()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "w1close")
        {
            w1["w1"].speed = -1;
            w1["w1"].time = w1["w1"].length;
            w1.Play();
        }
        else if(buttonName == "w2close"){
            w2["w2"].speed = -1;
            w2["w2"].time = w2["w2"].length;
            w2.Play();
        }
        else if (buttonName == "w3close")
        {
            w3["w3"].speed = -1;
            w3["w3"].time = w3["w3"].length;
            w3.Play();
        }

    }

}
