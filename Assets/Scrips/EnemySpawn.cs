using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

  public float spawnTime;        // The amount of time between each spawn.
     public float spawnDelay;       // The amount of time before spawning starts.
     public GameObject enemy;

     Transform target;
     Transform myTransform;
 
     void Awake()
     {
         myTransform = transform;
 
     }
 
     void Start()
     {
         GameObject stop = GameObject.FindGameObjectWithTag("Player");
 
         target = stop.transform;
 
 
         StartCoroutine(SpawnTimeDelay());
     }
 
     IEnumerator SpawnTimeDelay()
     {
         while (true)
             {
                 if (Vector3.Distance(target.position, myTransform.position) < 0)
                 {
                 Instantiate(enemy, transform.position, Quaternion.identity);
                 yield return new WaitForSeconds(spawnTime);
                 }
 
                 if (Vector3.Distance(target.position, myTransform.position) > 0)
                 {
                     yield return null;
                 }                
             }
     }
 }