using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    [SerializeField] private GameObject botonPause;

    [SerializeField] private GameObject menuPause;

   

    public void Pause()
    {
        Time.timeScale = 0f;
        botonPause.SetActive(false);
        menuPause.SetActive(true);
    }

   public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPause.SetActive(true);
        menuPause.SetActive(false);
    }

    public void BackMenu(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
