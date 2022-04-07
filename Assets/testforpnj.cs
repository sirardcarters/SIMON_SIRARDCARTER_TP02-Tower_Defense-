using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class testforpnj : MonoBehaviour
{
    private NavMeshAgent agent;
    private bool isAgentBusy = false;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isAgentBusy)
        {
            Vector3 newDestination = new Vector3(25f, 1f, 35f);

            agent.SetDestination(newDestination);

            isAgentBusy = true;
        }
    }
}
