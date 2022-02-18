using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheGameManager : MonoBehaviour
{
    public static TheGameManager tgm;
    public static int score;
    public Text scoreText;
    public GameObject winPanel;
    public static bool winable;
    public GameObject pausePanel;
    public static bool paused;
    public static bool justWarped;
    // Start is called before the first frame update
    void Start()
    {
        winable = false;
        tgm = this;
        tgm.winPanel.SetActive(false);
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
            if (paused)
            {
                tgm.pausePanel.SetActive(true);
                Time.timeScale = 0f;
            }else
            {
                tgm.pausePanel.SetActive(false);
                Time.timeScale = 1f;
            }
        }
        Win();
    }
    public void Unpouse()
    {
        paused = false;
        Time.timeScale = 1f;
    }
    public static void UpdateScore(int s)
    {
        score += s;
        tgm.scoreText.text = score.ToString();
    }
    void Win()
    {
        if(winable == true)
        {

            winPanel.SetActive(true);
        }
    }
}
