using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CollectibleSpawnManager : MonoBehaviour
{
    public static CollectibleSpawnManager csm = null;

    public GameObject collectiblePrefab;

    public GameObject enemyPrefab;

    void OnEnable()
    {
        CollectibleSpawnManager.csm = this;
    }

    public float timer;

    private float collectibleTimer = 0;
    
    public float maxTimer;

    private bool spawnedCollectible = false;

    private List<Vector2> spawnPointsList = new List<Vector2> { new Vector2(0, 8), new Vector2(1.5f, 8), new Vector2(-1.5f, 8) };

    void Start()
    {
        StartCoroutine(SpawnCollectible());
    }

    Vector2 GetRandomSpawnPoint()
    {
        var rand = Random.Range(1, spawnPointsList.Count);
        return spawnPointsList[rand - 1];
    }


    void FixedUpdate()
    {
        timer -= Time.deltaTime;

        if(timer < 0)
        {
            //spawn
            var newObject = enemyPrefab;

            Instantiate(newObject, GetRandomSpawnPoint(), Quaternion.identity);
            timer = maxTimer;
        }
    }

    IEnumerator SpawnCollectible()
    {
        yield return new WaitForSeconds(3f);

        var newObject = collectiblePrefab;
        Instantiate(newObject, GetRandomSpawnPoint(), Quaternion.identity);

        StartCoroutine(SpawnCollectible());
    }
}
