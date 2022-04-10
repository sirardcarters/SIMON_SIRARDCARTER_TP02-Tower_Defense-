using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrock : Ennemies
{
    // Start is called before the first frame update
    public float lifeNumber = 6;
    public GameObject warrok;
    public GameObject babywarrok;

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
            Vector3 posr = new Vector3(warrok.transform.position.x, warrok.transform.position.y, warrok.transform.position.z);
            Destroy(warrok);
            lifeNumber = 3;
            Instantiate(babywarrok, posr, Quaternion.identity);
            Instantiate(babywarrok, posr, Quaternion.identity);
        }
    }

}
