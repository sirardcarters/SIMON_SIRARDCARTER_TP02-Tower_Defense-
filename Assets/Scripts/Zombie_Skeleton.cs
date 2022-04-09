using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Skeleton : Ennemies
{
    public float lifeNumber = 4;
    public GameObject zomb;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void LifeLoss()
    {
        lifeNumber -= 0.5f;
        if (lifeNumber == 0)
        {
            Destroy(zomb);
        }
    }

}
