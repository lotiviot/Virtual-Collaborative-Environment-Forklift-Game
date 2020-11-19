using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror;
using System;
public class spotlaunch : NetworkBehaviour
{
    public NetworkManager NetMan;
    public String connectionString;
    public void PlayGame ()
    {
        NetMan.StartClient(new Uri(connectionString));
        SceneManager.LoadScene("Main Environment");
    }
    public void QuitGame()
    {
        Debug.Log("we audi");
        Application.Quit();
    }
}
