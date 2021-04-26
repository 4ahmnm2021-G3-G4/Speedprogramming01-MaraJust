using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeToStartScene ()
    {
        SceneManager.LoadScene("SampleScene"); 
    }

    public void ChangeToCalculator()
    {
        SceneManager.LoadScene("SecondScene");
    }
}
