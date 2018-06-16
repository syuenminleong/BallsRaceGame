﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Booster");
        if (other.tag=="Player")
        {
            Debug.Log("Player hit Booster");
            //other.GetComponent<PlayerManager>().speedIncrease();
            other.GetComponent<BallMovementAlternative>().speedIncrease();
            other.GetComponent<ScoreManager>().scoreUpdate(50);
            //TODO play music
        }
       
    }
}