using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day4cw4 : MonoBehaviour
{
    public int score = 0;
    public Text scoretext;
    public int increment = 1;
    public Text incrementtext;
    public Text warning;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void increasescore()
    {
        score += increment;
        scoretext.text = "Score = " + score;
    }

    public void incrementstore()
    {
        if(score >= 5)
        {
            score -= 5;
            increment += 1;
            scoretext.text = "Score = " + score;
            incrementtext.text = "increment = " + increment;
        }

        else if(score < 5)
        {
            warning.text = "You dont have enough score. Your score is " + score;
        }
    }
}
