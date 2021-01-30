using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float hitPoint = 50f;
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

