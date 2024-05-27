using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFinFami : MonoBehaviour
{
    public string URL;

    public void OpenLink()
    {
        Application.OpenURL(URL);
    }
}
