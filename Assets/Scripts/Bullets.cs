using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    private Zombie_Skeleton zomb;
    private NightShade night;
    private Warrock warrock;
    // Start is called before the first frame update
    private void Start()
    {
        night = FindObjectOfType<NightShade>();
        zomb = FindObjectOfType<Zombie_Skeleton>();
        warrock = FindObjectOfType<Warrock>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ennemies" && GameObject.Find("skeletonzombie Variant"))
        {
            zomb.LifeLoss();

        }
        else
        {
            if (other.gameObject.tag == "Ennemies" && GameObject.Find("Nighshade_Variant"))
            {
                night.LifeLoss();
       
            }
            else
            {
                if (other.gameObject.tag == "Ennemies" && GameObject.Find("warrok Variant"))
                {
                    warrock.LifeLoss();

                }
            }
        }


    }
}
