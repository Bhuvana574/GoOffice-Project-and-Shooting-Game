using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score;
    public void ScoreCalculator(int value)
    {
        score += value;
        print("The Score is " + score);
    }
}