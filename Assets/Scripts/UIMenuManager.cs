using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenuManager : MonoBehaviour
{
    public void HandleStartClick()
    {
        SceneManager.LoadScene(1);
    }
}
