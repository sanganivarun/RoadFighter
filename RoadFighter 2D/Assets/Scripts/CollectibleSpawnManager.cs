using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawnManager : MonoBehaviour
{
    public static CollectibleSpawnManager csm = null;

    void OnEnable()
    {
        CollectibleSpawnManager.csm = this;
    }






}
