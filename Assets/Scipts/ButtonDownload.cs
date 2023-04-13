using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDownload : MonoBehaviour
{
    public string Url;

    public void OpenLink()
    {
        Application.OpenURL(Url);
    }
}
