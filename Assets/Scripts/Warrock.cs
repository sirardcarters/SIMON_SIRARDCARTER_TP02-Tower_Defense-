using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrock : Ennemies
{
    // Start is called before the first frame update
    public float lifeNumber = 6;
    public GameObject warrok;
    public GameObject babywarrok;
    public float numberofkilled;
    private UiManager ui;


    // Start is called before the first frame update
    public override void Start()
    {
        ui = FindObjectOfType<UiManager>();
    }
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
            //ui.numberofkilled += 1;
            lifeNumber = 3;
            ui.numberofkilled += 1;
            Instantiate(babywarrok, posr, Quaternion.identity);
            Instantiate(babywarrok, posr, Quaternion.identity);
        }
    }

}
