using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEnemy : MonoBehaviour
{

    public float speedDefault;
    public float recoilSpeedDefault;
    private float speed;
    public float kbDist;
    public float kbLength;
    private float kbTimer;
    public float turnLag;
    private float turnTimer;
    public int dir;
    public Rigidbody2D selfRb;
    public Collider2D selfCollider;
    public Collider2D silCollider;
    public bool contactDmg;

    public HealthScript health;

    // Start is called before the first frame update
    void Start()
    {

        speed = speedDefault;

        Physics2D.IgnoreCollision(selfCollider, silCollider, true);

    }

    // Update is called once per frame
    void Update()
    {

        if (health.kb)
        {

             selfRb.velocity = new Vector2(silCollider.GetComponent<Rigidbody2D>().position.x - selfRb.position.x, silCollider.GetComponent<Rigidbody2D>().position.y - selfRb.position.y).normalized * -kbDist;

             kbTimer = kbLength;
             health.kb = false;

        }

        if (kbTimer <= 0)
        {

            
            Vector2 target = new Vector2(dir * speed, 0);
            
            Collider2D C = Physics2D.OverlapBox(target, new Vector2(0.1f, 0.1f), 0);

            if (C.gameObject.tag == "Wall" && turnTimer <= 0)
            {

                dir = -dir;

                selfRb.velocity = new Vector2(dir * speed, 0);


                turnTimer = turnLag;

            }
            else
            {
            
                selfRb.velocity = target;

            }

            //add separate detection for enemy bounds


            

        }


        kbTimer -= Time.deltaTime;
        turnTimer -= Time.deltaTime;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Wall" && kbTimer <= 0)
        {

            dir = dir * -1;

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name == "Enemy Bound" && kbTimer <= 0)
        {

            dir = dir * -1;

        }

    }

}
