using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrock : Ennemies
{
    // Start is called before the first frame update
    public float lifeNumber = 6;
    public GameObject warrok;
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
            Destroy(warrok);
        }
    }

}
