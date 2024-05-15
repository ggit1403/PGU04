using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelDie : MonoBehaviour
{
    //[SerializeField] private GameObject player;
    [SerializeField] private GameObject panelDie;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject pauseMenu;
    void Start()
    {
        
    }

    void Update()
    {
        if(player == null)
        {
            panelDie.SetActive(true);
            Time.timeScale = 0f;
            pauseMenu.SetActive(false);
        }
        else if (player != null)
        {
            //Time.timeScale = 1f;
            return;
        }
    }
    public void Home()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1.0f;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
    }
}
