using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMovement : MonoBehaviour
{
    public float speed = 1f;

    public float clammpos;

    [HideInInspector] public Vector2 StartPos;

    void Start()
    {
        StartPos = transform.localPosition;
    }

    void FixedUpdate()
    {
        if(transform.position.y < clammpos)
        {
            transform.position = new Vector2(0f, 13f);
        }
        else
        {
            transform.position = new Vector2(0f, transform.position.y - Time.deltaTime * speed);
        }
    }
}
