using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddNumbers : MonoBehaviour
{
    public int NumberA;
    public int NumberB;

    public Text resultText;
    public InputField inputA;
    public InputField inputB;

    public void CalculateNumbers ()
    {
        NumberA = int.Parse(inputA.text);
        NumberB = int.Parse(inputB.text);
        var result = NumberA + NumberB;
        resultText.text = "= " + result.ToString();
        
    }
}
