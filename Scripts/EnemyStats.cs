using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float health = 3;

    private void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        } 
    }
}
