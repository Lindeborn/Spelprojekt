using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityENgine.SceneManagement;

public class MainMenu : MonoBehaviour
{

public void PlayGame(){
SceneManager.LoadScene(level)
}

public void QuitGame(){
Application.Quit();
}
}
