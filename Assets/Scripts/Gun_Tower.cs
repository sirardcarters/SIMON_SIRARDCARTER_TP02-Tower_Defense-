using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gun_Tower : MonoBehaviour
{
    private Tower tower;
    private Transform barrel;
    private void Awake()
    {
        tower = GetComponent<Tower>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<MovementPNJ>(out MovementPNJ pnj))
        {
            tower.SetTarget(pnj);
            Debug.Log("fck");
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
                    hit.collider.enabled = false;
                    Debug.DrawRay(transform.position, forward, Color.green);
                }
            }
        }
    }


}
