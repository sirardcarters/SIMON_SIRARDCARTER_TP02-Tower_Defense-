using UnityEngine;


public class Gun_Tower : Tower
{
    public float range = 25.0f;
    public Transform pivot;
    public Transform gun;
    public Transform bulletStart;
    public TrailRenderer tracerEffect;
    private Ennemies enn;

    private bool onRange = false;

    public Rigidbody projectile;
    Ray ray;
    RaycastHit hitInfo;

    void Start()
    {
        enn = FindObjectOfType<Ennemies>();
        InvokeRepeating("DelayedUpdate", 0.2f, 0.2f);
    }

    void DelayedUpdate()
    {
        GameObject[] ennemies = GameObject.FindGameObjectsWithTag("Ennemies");
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in ennemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {

                //pivot.transform.LookAt(relativePos);
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
                tracer.transform.position = hitInfo.point;
                enn.LifeLoss();

                
               

                
                
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

    protected override void  Update()
    {
        Vector3 relativePos = GameObject.FindGameObjectWithTag("body").transform.position - bulletStart.transform.position;
        Vector3 rotation = Quaternion.LookRotation(relativePos).eulerAngles;
        pivot.transform.localEulerAngles = new Vector3(-90.288f, 0f, GameObject.FindGameObjectWithTag("body").transform.position.z);
        gun.transform.localEulerAngles = new Vector3(-GameObject.FindGameObjectWithTag("body").transform.position.z, 0f, 0f);

        
    }

}
