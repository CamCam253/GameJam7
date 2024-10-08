using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuSkript : MonoBehaviour
{
    public void OnPlayBtn()
    {
        SceneManager.LoadScene(1);
    }
    public void OnQuitBtn()
    {
        Application.Quit();
    }
}
