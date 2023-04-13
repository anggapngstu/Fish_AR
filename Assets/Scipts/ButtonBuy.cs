using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBuy : MonoBehaviour
{
    public string Url;

    public void OpenLink()
    {
        Application.OpenURL(Url);
    }
}
