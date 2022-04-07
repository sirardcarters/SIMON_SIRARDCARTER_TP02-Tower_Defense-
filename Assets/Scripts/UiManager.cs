using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class UiManager : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public Button pause;
    public Button play;
    //public GameObject PauseMenuUi;
    // Start is called before the first frame update
    void Awake()
    {
        pause.onClick.AddListener(PauseGame);
        play.onClick.AddListener(ResumeGame);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void PauseGame()
    {
        //PauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    void ResumeGame()
    {
        //PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}
