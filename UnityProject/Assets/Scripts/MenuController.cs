using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*This script allows the menu to be interactable with two simple actions. Pressing the Start button, the player will load into the game.
 * If the player clicks Exit, the application will close*/

public class MenuController : MonoBehaviour
{

    public Button StartBtn;
    public Button ExitBtn;

    public CanvasGroup MainMenuGroup;

    public void LoadLevel(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
        StartBtn.interactable = false;
        ExitBtn.interactable = false;
    }

    public void Exit()
    {
        Application.Quit();
    }
}