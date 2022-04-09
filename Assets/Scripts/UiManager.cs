using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UiManager : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public Button pause;
    public Button play;
    public float currentTime;
    public Text timeText;
    float lifeNb = 3;
    public Text LifeCount;
    public Text over;
    

    //public GameObject PauseMenuUi;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
        pause.onClick.AddListener(PauseGame);
        play.onClick.AddListener(ResumeGame);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = currentTime + Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timeText.text = time.ToString(@"mm\:ss\:ff");

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
    public void LifeLoss()
    {
        lifeNb -= 1;
        LifeCount.text = lifeNb.ToString();
        if (lifeNb == 0)
        {
            GameOver();
        }

    }
    void GameOver()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
        over.text = ("Game Over : You Are Dead :(");
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
}
