using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Gun_Tower : Tower
{
    public float range = 25.0f;
    public Transform body;
    public Transform pivot;
    public Transform bulletStart;
    public TrailRenderer tracerEffect;

    private bool onRange = false;

    public Rigidbody projectile;
    Ray ray;
    RaycastHit hitInfo;

    void Start()
    {
        InvokeRepeating("DelayedUpdate", 0.2f, 0.2f);
    }

    void DelayedUpdate()
    {
        GameObject[] ennemies = GameObject.FindGameObjectsWithTag("body");
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in ennemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }
        if (nearestEnemy != null && shortestDistance <= range)
        {
            ray.origin = bulletStart.position;
            ray.direction = bulletStart.forward;
            var tracer = Instantiate(tracerEffect, ray.origin, Quaternion.identity);
            tracer.AddPosition(ray.origin);
            if (Physics.Linecast(bulletStart.position, nearestEnemy.transform.position, out hitInfo))
            {
                if (hitInfo.transform.CompareTag("Ennemies"))
                {
                    tracer.transform.position = hitInfo.point;

                }
            }
        }




    }
    //private void OnTriggerEnter(Collider other)
    //{

    //    if (other.gameObject.tag == "Ennemies")
    //    {
    //        Debug.Log("F");
            
    //    }
    //}

    void Update()
    {
        //onRange = Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Ennemies").transform.position) < range;
        //if (onRange)
        //{


            //Vector3 relativePos = GameObject.FindGameObjectWithTag("Ennemies").transform.position - bulletStart.transform.position;
            //Vector3 rotation = Quaternion.LookRotation(relativePos).eulerAngles;
            //pivot.transform.localEulerAngles = new Vector3(100, 0, rotation.y);
            //transform.localEulerAngles = new Vector3(-90, 0, transform.localEulerAngles.z);
            //transform.LookAt(new Vector3(GameObject.FindGameObjectWithTag("Ennemies").transform.position.x, transform.position.y, transform.position.z));
            //    Quaternion myRotation = Quaternion.identity;
            //    myRotation.eulerAngles = new Vector3(0, 0, Ennemies.position.z);


            //Vector3 targetPostition = new Vector3(Ennemies.position.x, Ennemies.position.y, this.transform.position.z);
            //this.transform.LookAt(targetPostition);

        //}
    }

}
