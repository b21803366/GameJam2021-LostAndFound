using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public float fireDistance = 4f;
    public float damage = 50f;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);
        if (distance <= fireDistance)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        player.GetComponent<PlayerTarget>().TakeDamage(damage);
    }
}
