using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScripts : MonoBehaviour
{
    public void Start()
    {
        Debug.Log("Application Start");
    }

    public void ChangeOnClick()
    {
        SceneManager.LoadScene("ScanAR");
    }
}
