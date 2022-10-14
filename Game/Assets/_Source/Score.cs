using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score
{
    private const int startScore = 5;
    public int score;
    
    public void Start()
    {
        score = startScore;
    }

    public void AddScore()
    {
        score++;
    }

    public void End()
    {
        score = 0;
    }
}
