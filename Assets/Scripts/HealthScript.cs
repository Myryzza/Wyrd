using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{

    public int health;
    public bool invulnerable;
    public float iTimerDefault;
    private float iTimer;
    private int healthLast;
    public bool kb;


    // Start is called before the first frame update
    void Start()
    {

        healthLast = health;
        iTimer = iTimerDefault;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (health < healthLast)
        {

            invulnerable = true;
            kb = true;

            healthLast = health;

        }

        if (invulnerable) { 

            iTimer -= Time.deltaTime;

            if (iTimer <= 0)
            {

                invulnerable = false;

                iTimer = iTimerDefault;

            }

        }
        
        if (health <= 0)
        {

            Destroy(gameObject);

        }

    }
}
