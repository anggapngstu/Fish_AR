using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    public GameObject panel; 

    private void Start()
    {
        CloseNewPanel();
    }
    public void OpenNewPanel()
    {
        panel.SetActive(true);
    }

    public void CloseNewPanel()
    {
        panel.SetActive(false);
    }
}
