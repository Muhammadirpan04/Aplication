 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void Exit()
    {
        Application.Quit();
        Debug.Log("Game Close");
    }

    public void Mainkan()
    {
        SceneManager.LoadScene("MainkanAR");
    }

    public void Marker()
    {
        SceneManager.LoadScene("Marker");
    }

    public void Petunjuk()
    {
        SceneManager.LoadScene("Petunjuk");
    }

    public void Tentang()
    {
        SceneManager.LoadScene("Tentang");
    }
}
