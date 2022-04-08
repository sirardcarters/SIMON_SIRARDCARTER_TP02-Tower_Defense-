using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Gun_Tower : MonoBehaviour
{
    public Transform Ennemies;
    public float range = 25.0f;
    public float bulletImpulse = 1000.0f;
    public Transform body;
    public Transform pivot;
    public Transform bulletStart;

    private bool onRange = false;

    public Rigidbody projectile;

    void Start()
    {
        float rand = Random.Range(1.0f, 2.0f);
        InvokeRepeating("Shoot", 2, rand);
    }
    void Shoot()
    {
        if (onRange)
        {

            Rigidbody bullet = (Rigidbody)Instantiate(projectile, bulletStart.position + bulletStart.forward, bulletStart.rotation);
            bullet.AddForce(bulletStart.forward * bulletImpulse, ForceMode.Impulse);

            Destroy(bullet.gameObject, 2);
        }


    }

    void Update()
    {

        onRange = Vector3.Distance(transform.position, Ennemies.position) < range;
        if (onRange)
        {
            Vector3 relativePos = Ennemies.position - bulletStart.transform.position;
            Vector3 rotation = Quaternion.LookRotation(relativePos).eulerAngles;
            pivot.transform.localEulerAngles = new Vector3(100, 0, rotation.y);
            transform.localEulerAngles = new Vector3(-90, 0, transform.localEulerAngles.z);
            //transform.LookAt(new Vector3(Ennemies.position.x, transform.position.y, transform.position.z));
            //    Quaternion myRotation = Quaternion.identity;
            //    myRotation.eulerAngles = new Vector3(0, 0, Ennemies.position.z);


            //Vector3 targetPostition = new Vector3(Ennemies.position.x, Ennemies.position.y, this.transform.position.z);
            //this.transform.LookAt(targetPostition);

        }



    }


}
