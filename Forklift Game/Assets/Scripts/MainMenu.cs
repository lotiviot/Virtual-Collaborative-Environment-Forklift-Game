using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("Main Environment");
    }
    public void QuitGame()
    {
        Debug.Log("we audi");
        Application.Quit();
    }
}
