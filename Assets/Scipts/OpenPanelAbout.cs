using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanelAbout : MonoBehaviour
{
   public GameObject panel; 

    private void Start()
    {
        CloseNewPanelAbout();
    }
    public void OpenNewPanelAbout()
    {
        panel.SetActive(true);
    }
    public void CloseNewPanelAbout()
    {
        panel.SetActive(false);
    }
}
