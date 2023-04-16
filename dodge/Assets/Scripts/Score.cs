using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score = 0;
    [SerializeField]float timeS = 0.3f;
    float timechecker;
    PointUI pu;
    bool alive;
    // Update is called once per frame

    private void Start()
    {
        alive = true;
        score = 0;
        timechecker = 0;
        pu = FindObjectOfType<PointUI>();
    }
    void Update()
    {
        if(alive)
        {
            timeScore();
        }
        
    }

    void timeScore()
    {

        timechecker += Time.deltaTime;
        if(timechecker >= timeS)
        {
            scoreUp(1);
            timechecker = 0;
        }
        
    }

    public void scoreUp(int point)
    {
        score += point;
        pu.ScorePrinting();
    }

    public int getScore()
    {
        return score;
    }

    public void setDead()
    {
        alive = false;
    }
}
