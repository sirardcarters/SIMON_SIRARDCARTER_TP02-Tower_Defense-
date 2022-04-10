using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour
{
    public GameObject warrok;
    public GameObject night;
    public GameObject zomb;
    private Warrock war;
    private NightShade nig;
    private Zombie_Skeleton zom;
    private float wavenb = 0;
    public float EnnemyCount;
    public GameObject ennemyEmpty;

    // Start is called before the first frame update
    void Start()
    {
        nig = FindObjectOfType<NightShade>();
        zom = FindObjectOfType<Zombie_Skeleton>();
        war = FindObjectOfType<Warrock>();

        Vector3 posr = new Vector3(-15.18884f, 2.188457f, 50.90985f);

        Instantiate(warrok, posr, Quaternion.identity);
        Instantiate(night, posr, Quaternion.identity);
        Instantiate(zomb, posr, Quaternion.identity);
    }
    void NewWave()
    {
    }

    // Update is called once per frame
    void Update()
    {
        EnnemyCount = nig.numberofkilled + zom.numberofkilled + war.numberofkilled;
    }
}
