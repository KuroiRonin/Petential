﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StoryText : MonoBehaviour
{
    
    public int food = 100;
    public int water = 100;
    public int clean = 100;
    public int bored = 100;

    public Text textComponent;

    public State StartingState;
    public State Situation1;
    public State Situation2;

    State state;
    void Start()
    {
        //starts the game with the starting state
        state = StartingState;
        //gets the states and the text
        textComponent.text = state.GetStateStory();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
