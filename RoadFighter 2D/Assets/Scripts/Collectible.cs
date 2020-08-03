using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float speed;

    public float myXPos;

    void FixedUpdate()
    {
        transform.localPosition = new Vector2(myXPos, transform.localPosition.y - Time.deltaTime * speed);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("tag: " + col);
        if(col.tag == "Player")
        {
            Debug.Log("Collision Succesful");
            FuelMeter.fm.IncrementFuel();
            Destroy(gameObject);
        }
        else if(col.tag == "Finish")    
        {
            Destroy(gameObject);
        }
    }
}
