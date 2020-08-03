using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 5f;
    
    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - Time.deltaTime * speed);
    }

}
