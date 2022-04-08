using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 projectileShootFromPosition;
    private float range;
    private int damageAmount;
    private float shootTimerMax;
    private float shootTimer;
    private MovementPNJ targetEnemy;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetTarget(MovementPNJ targetEnemy)
    {
        this.targetEnemy = targetEnemy;
    }
}