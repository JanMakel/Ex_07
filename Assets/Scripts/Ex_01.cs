using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_01 : MonoBehaviour
{
    public GameObject cube;
    

    private Vector3 RandomSpawnPosition()
    {
        float spawnPosX = Random.Range(-10, 10);
        float spawnPosY = Random.Range(-10, 10);
        return new Vector3(spawnPosX, spawnPosY, 0);
    }

    
   
    private void Start()
    {
        
    }
}
