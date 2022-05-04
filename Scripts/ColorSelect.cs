using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColorSelect : MonoBehaviour
{

    public Material band1;
    public Material band2;
    public Material band3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void w1ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "Black Button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band1.color = myColor;
        }
        else if(buttonName == "Blue Button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000A1A", out myColor);
            band1.color = myColor;
        }
    }


    public void w2ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "Black Button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band2.color = myColor;
        }
        else if (buttonName == "Red Button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#290900", out myColor);
            band2.color = myColor;
        }
    }


    public void w3ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "Gold Button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#FFF6AD", out myColor);
            band3.color = myColor;
        }
        else if (buttonName == "Silver Button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#A1A1A1", out myColor);
            band3.color = myColor;
        }
    }

}
