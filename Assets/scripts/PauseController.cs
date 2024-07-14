using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
     public GameObject pausePanel;
    public void PauseGame()
    {
    pausePanel.SetActive(true);
    Time.timeScale=0f;
    }
    public void ResumeGame()
    {
    pausePanel.SetActive(false);
    Time.timeScale=1f;
    }
    public void RestartGame()
    {
        Time.timeScale=1f;
        SceneManager.LoadScene("SampleScene");
    }
    public void HometGame()
    {
        Time.timeScale=1f;
        SceneManager.LoadScene("Menu");
    }
     
}
