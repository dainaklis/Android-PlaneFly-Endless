using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] private float waitTime;

    [SerializeField] GameObject explose;

    void Start()
    {
        Time.timeScale = 1;
        
    }


    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            StartCoroutine(StarGameOvertDelay());
            // gameOverPanel.SetActive(true);
            // Time.timeScale = 0;

        }
    }

    IEnumerator StarGameOvertDelay()
    {   
        yield return new WaitForSeconds(waitTime);
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }


}
