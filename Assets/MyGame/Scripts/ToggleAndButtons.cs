using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleAndButtons : MonoBehaviour
{
    public Toggle Toggle1;
    public Toggle Toggle2;

    public Text Toggle1Text;
    public Text Toggle2Text;

    public Text ButtonText;

    public Button Und;
    public Button Oder;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        CheckToggles();
    }

    public void CheckToggles ()
    {
        if (Toggle1.isOn == true)
        {
            Toggle1Text.text = "Wahr";
        } else
        {
            Toggle1Text.text = "Falsch";
        }

        if (Toggle2.isOn == true)
        {
            Toggle2Text.text = "Wahr";
        }
        else
        {
            Toggle2Text.text = "Falsch";
        }
    }

    public void UndButt ()
    {
        Oder.interactable = false;

        if (Toggle1.isOn && Toggle2.isOn)
        {
            ButtonText.text = "Wahr";
        } else
        {
            ButtonText.text = "Falsch";
        }

        Oder.interactable = true;

    }

    public void OdButt ()
    {
        Und.interactable = false;

        if ((Toggle1.isOn == false) && (Toggle2.isOn == false))
        {
            ButtonText.text = "Falsch";

        } else 
        {
            ButtonText.text = "Wahr";
        }

        Und.interactable = true;
    }

    
}
