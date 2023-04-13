using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToPrevious : MonoBehaviour
{
    public void BackOnClick()
    {
    SceneManager.LoadScene("MainMenu");
    }
}
