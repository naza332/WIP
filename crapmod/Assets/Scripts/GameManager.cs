using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject deathPanel;
    private bool pauseGame = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        deathPanel.SetActive(false);
    }

    public void GameOver()
    {
        
        deathPanel.SetActive(true);
        //stop time
        ToggleTime();
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    private void ToggleTime()
    {
        pauseGame = !pauseGame;
        if (pauseGame)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Retry()
    {
        ToggleTime();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
