using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreShow : MonoBehaviour
{
    public Text score;
    public Text record;


    private void Start()
    {
        score.text = "You scored: " + ApplicationInstance.SharedInstance.GetScore().ToString() + " points!";
        record.text = "Your record: " + ApplicationInstance.SharedInstance.GetRecord().ToString() + " points.";
    }
}
