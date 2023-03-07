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

    private Vector3 RandomScale()
    {
        float spawnRanX = Random.Range(-5, 5);
        float spawnRanY = Random.Range(-5, 5);
        float spawnRanZ = Random.Range(-5, 5);
        return  new Vector3(spawnRanX, spawnRanY, spawnRanZ);
    }
   
    private void Start()
    {
        
        for (var i = 0; i < 5; i++)
        {
            cube.transform.localScale = RandomScale();
            Instantiate(cube, RandomSpawnPosition(), Quaternion.identity);
            
        }
        
    }
}
