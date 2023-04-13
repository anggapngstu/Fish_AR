using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonExit : MonoBehaviour
{
    public void ClickButtonExit()
    {
        Application.Quit();
        Debug.Log("Game Close");
    }
}
