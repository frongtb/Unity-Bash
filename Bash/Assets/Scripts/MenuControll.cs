using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControll : MonoBehaviour
{
    public void StartClick()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitClick()
    {
        Application.Quit();
    }
}
