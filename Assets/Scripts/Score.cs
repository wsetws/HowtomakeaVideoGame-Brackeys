﻿
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform Player;
    public Text ScoreText;
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Distance : " + Player.position.z.ToString("0");
    }
}
