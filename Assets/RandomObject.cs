using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnemySpawn", 2.0f, 2.0f);
    }
    private void EnemySpawn()
    {
        float x = Random.Range(-4.0f, 4.0f);
        float z = Random.Range(-4.0f, 4.0f);
        Vector3 enemyposition = new Vector3(x, 2.5f, z);
        transform.position = enemyposition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
