using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationInstance : MonoBehaviour
{
    //Signleton 
    public static ApplicationInstance SharedInstance { get; private set; }

    private int record;
    private int score;
    private int mode;

    private void Awake()
    {
        if(SharedInstance == null)
        {
            SharedInstance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }


    //Get latest score
    public int GetScore()
    {
        int latestScore = score;
        score = 0;
        return latestScore;
    }

    //Get record score
    public int GetRecord()
    {
        return record;
    }

    //Set the score and update record
    public void SetScore(int latestScore)
    {
        score = latestScore;
        if(latestScore > record)
        {
            record = latestScore;
        }
    }

    
    public int GetMode()
    {
        return mode;
    }

    
    public void SetMode(int mode)
    {
        this.mode = mode;
    }
}
