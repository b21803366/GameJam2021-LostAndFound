using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float startDistance = 5f;
    NavMeshAgent nav;
    void Start()
    {
        nav = gameObject.GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);
        if (distance <= startDistance)
        {
            nav.isStopped = false;
            nav.SetDestination(player.position);
        }
            
        else
            nav.isStopped = true;
    }
}
