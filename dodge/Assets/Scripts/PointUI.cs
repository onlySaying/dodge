using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointUI : MonoBehaviour
{
    TextMeshProUGUI tmp;
    Score score;
    void Start()
    {
        score = FindObjectOfType<Score>();
        tmp = GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        ScorePrinting();    
    }

    public void ScorePrinting()
    {  
        tmp.text = "Score : " + score.getScore();
    }

    
}
