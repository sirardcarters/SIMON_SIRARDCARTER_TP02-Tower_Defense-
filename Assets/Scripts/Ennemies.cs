using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class Ennemies : MonoBehaviour
{
    private NavMeshAgent agent;
    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Vector3 newDestination = new Vector3(16.4f, 0f, -52.8f);
        agent.SetDestination(newDestination);
    }
    void Update()
    {


    }

}
