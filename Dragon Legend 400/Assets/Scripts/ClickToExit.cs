using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToExit : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("Application Closing");
        Application.Quit();
    }
}
