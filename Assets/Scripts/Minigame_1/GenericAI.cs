using UnityEngine;
using System;
using System.Collections;

public class GenericAI : MonoBehaviour {

    Vector2 moveVector;
    System.Random random = new System.Random();
    bool isInCollision;

    void Start()
    {
        moveVector = new Vector2(0, 30);
    }

    void FixedUpdate () {
        
	}

    void moveAI()
    {
        if (random.Next(0, 2) == 0)
        {
            moveVector = new Vector2(random.Next(-1, 2) * 30, 0);
        }
        else
        {
            moveVector = new Vector2(0, random.Next(-1, 2) * 30);
        }
    }
}
