using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] bullets;
    [SerializeField] float spawnRateMin = 0.5f;
    [SerializeField] float spawnRateMax = 3f;

    Transform target;
    float spawnRate;
    float timeAfterSpawn;
    void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        target = FindObjectOfType<PlayerMovement>().transform;
        
       
    }
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;
        
        if(timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;

            int b = Random.Range(1, 100);
            int maker = 0;
            if(b>80)
            {
                maker = 1;
            }

            GameObject bullet =
                Instantiate(bullets[maker] , transform.position, transform.rotation);

            


            bullet.transform.LookAt(target);

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
