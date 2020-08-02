using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawnManager : MonoBehaviour
{
    public static CollectibleSpawnManager csm = null;

    public GameObject myPrefab;

    void OnEnable()
    {
        CollectibleSpawnManager.csm = this;
    }

    public float timer;

    public float maxTimer;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        timer -= Time.deltaTime;

        if(timer < 0)
        {
            //spawn
            Instantiate(myPrefab, gameObject.transform.position, Quaternion.identity);
            Debug.Log("Timer update");
            timer = maxTimer;
        }
    }

}
