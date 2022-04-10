using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightShade : Ennemies
{
    public float lifeNumber = 3;
    public GameObject night;
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
        Debug.Log(lifeNumber);
        if (lifeNumber == 0)
        {
            Destroy(night);
            ui.numberofkilled += 1;
            
        }
    }
    public float kills()
    {
        return numberofkilled;
    }
    
}
