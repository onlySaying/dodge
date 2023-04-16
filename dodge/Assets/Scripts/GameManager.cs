using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameoverTxt;
    [SerializeField]TextMeshProUGUI bestScore;
    Score score;
    private bool isGameover;

    void Start()
    {
        isGameover = false;
        // if u want to find a false set of object. u will find it this way  
        gameoverTxt = GameObject.Find("gameOverUI").
            transform.Find("GameOverPanel").gameObject;
        // If you want to find an object using only the address.
        //gameoverTxt = GameObject.Find("/UI/gameOverUI/GameOverPanel");
        bestScore = gameoverTxt.transform.Find("bestRecords").GetComponent<TextMeshProUGUI>();

        score = FindObjectOfType<Score>();
        gameoverTxt.SetActive(false);


        
    }

    
    void Update()
    {
        if(isGameover)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }

    public void EndGame()
    {
        isGameover = true;
        gameoverTxt.SetActive(true);
        int bestRecord = PlayerPrefs.GetInt("BestRecord");
        if(score.getScore() > bestRecord)
        {
            bestRecord = score.getScore();
            PlayerPrefs.SetInt("BestRecord", bestRecord);
        }
        bestScore.text = "Best Score : " + bestRecord;
    }

}
