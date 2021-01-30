using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    public float hitPoint = 50f;

    private void Start()
    {
    }
    public void TakeDamage(float amount)
    {
        hitPoint -= amount;
        if(hitPoint <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}

