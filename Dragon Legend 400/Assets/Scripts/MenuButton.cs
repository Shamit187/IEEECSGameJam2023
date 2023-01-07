using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    private void OnMouseDown() {
        SceneManager.LoadScene("Level_Menu");
    }
}
