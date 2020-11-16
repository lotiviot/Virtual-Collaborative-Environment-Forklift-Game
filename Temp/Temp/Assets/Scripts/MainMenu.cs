using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror;
public class MainMenu : NetworkBehaviour
{
    public NetworkManager NetMan;
    public void PlayGame ()
    {
        NetMan.StartHost();
        SceneManager.LoadScene("Main Environment");
    }
    public void QuitGame()
    {
        Debug.Log("we audi");
        Application.Quit();
    }
}
