using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Walk();
    }

    void Walk()
    {
        Vector3 position = transform.position;
        position.x += 0.1f; // Move right by 0.1 units per frame
        transform.position = position; // Update the position of the character
    }
}
