using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Skeleton : Ennemies
{
    public float lifeNumber = 4;
    public GameObject zomb;
    public float numberofkilled;
    public UiManager ui;
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
            Destroy(zomb);
            ui.numberofkilled += 1;
        }
    }
    public float kills()
    {
        return numberofkilled;
    }

}
