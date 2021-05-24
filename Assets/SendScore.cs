using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendScore : MonoBehaviour
{
    int EnemyScore = 1;

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.tag);
        collision.gameObject.SetActive(false);
    }
       
        private void GameObjectDestroy(Collision collision)
    {
    if (collision.gameObject.CompareTag("Enemy"))
    {
         
        Score scrobj = FindObjectOfType<Score>();
        scrobj.ScoreCalculator(EnemyScore);
        //Destroy(collision.gameObject, 2.0f);
    }

    }
}
