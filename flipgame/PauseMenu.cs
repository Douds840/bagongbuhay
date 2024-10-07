using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject A;
    [SerializeField] GameObject B;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        A.SetActive(false);
        B.SetActive(false);

    }
    public void Home()
    {
        SceneManager.LoadScene("Easy");
        Time.timeScale = 1;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        A.SetActive(true);
        B.SetActive(true);

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale=1;
    }
}
