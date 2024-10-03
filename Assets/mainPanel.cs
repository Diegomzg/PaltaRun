using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainPanel : MonoBehaviour
{
    [Header("Options")]
    public Slider volumeFx;
    public Slider volumeMaster;
    public Toggle mute;
    [Header("Panels")]
    public GameObject ainPanel;
    public GameObject optionPanel;
    //public GameObject playPanel;

    public void PlayLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void OpenPanel (GameObject panel)
    {
        ainPanel.SetActive(false);
        optionPanel.SetActive(false);
        //playPanel.SetActive(false);

        panel.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
       
    }
}
