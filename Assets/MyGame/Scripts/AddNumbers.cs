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

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        NumberA = int.Parse(inputA.text);
        NumberB = int.Parse(inputB.text);
    }

    public void CalculateNumbers ()
    {
        var result = NumberA + NumberB;
        resultText.text = "= " + result.ToString();
        
    }
}
