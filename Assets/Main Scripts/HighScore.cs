﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

    public static int Highscorevalue = 0;
    Text Highscore;


    void Start()
    {
        Highscore = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        Highscore.text = "HighScore: " + Highscorevalue;
    }




}
