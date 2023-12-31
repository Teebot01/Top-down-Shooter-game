using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Adapted from PIIR, 2021. PlayerRotation.cs. N/A: Piir.

public class PlayerRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Tells the player GameObject to always face the direction of the mouse
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.up = direction;
    }
}
