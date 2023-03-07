using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_04 : MonoBehaviour
{
    


    private Vector3 RandomSpawnPosition()
    {
        float spawnPosX = Random.Range(-10, 10);
        float spawnPosY = Random.Range(-10, 10);
        return new Vector3(spawnPosX, spawnPosY, 0);
    }

    
    private IEnumerator generate()
    {
        for (var i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(2);
            transform.position = RandomSpawnPosition();     
        }
    }
    private void Start()
    {

        StartCoroutine(generate());

    }
}
