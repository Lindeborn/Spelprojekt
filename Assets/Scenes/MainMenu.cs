using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityENgine.SceneManagement;

public class MainMenu : MonoBehaviour
{

public void PlayGame(){
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndez+1);
}

public void quitGame(){
Application.Quit();
}
}
