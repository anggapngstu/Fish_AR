using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanelGuide : MonoBehaviour
{
     public GameObject panel; 

    private void Start()
    {
        CloseNewPanelGuide();
    }
    public void OpenNewPanelGuide()
    {
        panel.SetActive(true);
    }
    public void CloseNewPanelGuide()
    {
        panel.SetActive(false);
    }
}
