﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleRightLunges : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {

        if (other.name.Contains("malcolm"))
        {
            scoring sc = GameObject.Find("Scoring").GetComponent<scoring>();
            sc.setGesture(5);
        }
    }

    void OnTriggerStay(Collider other)
    {
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name.Contains("malcolm"))
        {
            scoring sc = GameObject.Find("Scoring").GetComponent<scoring>();
            sc.setGesture(1);
        }
    }
}
