using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollidesLifeLoss : MonoBehaviour
{
    private UiManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<UiManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Ennemies")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            manager.LifeLoss();
            Destroy(collision.gameObject);
        }
    }
}
