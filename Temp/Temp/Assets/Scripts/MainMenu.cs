using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror;

public class MainMenu : NetworkBehaviour
{
    public NetworkManager Netman;
    public void PlayGame ()
    {
        NetMan.starthost();
    }
    public void QuitGame()
    {
        Debug.Log("we audi");
        Application.Quit();
    }
}
