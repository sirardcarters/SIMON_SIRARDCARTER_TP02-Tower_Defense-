using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementPNJ : MonoBehaviour
{
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        Vector3 newDestination = new Vector3(16.4f, 0f, -52.8f);

        agent.SetDestination(newDestination);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
