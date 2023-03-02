using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Template : MonoBehaviour
{
    // Goal: we want to turn the cannon left and right based on user input. 

    // Start is called before the first frame update
    void Start()
    {
        // TODO: Set the tilt angle
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Get the horizontal input and multiply it by the tilt angle

        // TODO: Create a quaternion based on the input

        // TODO: Set the current object's transform to the target quaternion 

    }

    // Optional Exercises! ----------------------------------------------------------------------------
    // Exercise 1: look at the different inputs we can collect and the changes you can make to the cannon's transform
    // hint: go look at the scripting API for Transform, and find the InputManager under Edit > Project Settings

    // Exercise 2: Find a way to have the camera follow behind the cannon as if it is a playable character, bonus points for allowing
    // it to move around and jump like one too!
}
