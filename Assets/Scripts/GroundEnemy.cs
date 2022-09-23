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
    /*public float turnLag;
    private float turnTimer;*/
    public float autoTurnWait;
    private float autoTurnTimer;
    public int dir;
    public Rigidbody2D selfRb;
    public Collider2D selfCollider;
    public Collider2D silCollider;
    public bool contactDmg;
    private Vector2 posPrev;

    public HealthScript health;

    // Start is called before the first frame update
    void Start()
    {

        speed = speedDefault;
        //autoTurnTimer = autoTurnWait;

        Physics2D.IgnoreCollision(selfCollider, silCollider, true);

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 target = new Vector2(dir * speed, 0);

        if (health.kb)
        {

            target = new Vector2(silCollider.GetComponent<Rigidbody2D>().position.x - selfRb.position.x, silCollider.GetComponent<Rigidbody2D>().position.y - selfRb.position.y).normalized * -kbDist;

            selfRb.velocity = target;


            /*

            Vector2 target = new Vector2(silCollider.GetComponent<Rigidbody2D>().position.x - selfRb.position.x, silCollider.GetComponent<Rigidbody2D>().position.y - selfRb.position.y).normalized * -kbDist;

            
            RaycastHit2D R = Physics2D.Raycast(selfRb.position, new Vector2(dir, 0), kbDist);

            if (R.collider.tag == "Wall" && turnTimer <= 0)
            {

                reverse();

            }


            selfRb.velocity = target;
            */

            health.kb = false;
            kbTimer = kbLength;

            /*
            autoTurnTimer = autoTurnWait;
            turnTimer = turnLag;
            */


        }


        if (kbTimer <= 0)
        {

            /*
            if (autoTurnTimer <= 0)
            {

                reverse();

            }


            Vector2 target = new Vector2(dir * speed, 0);*/


             /*RaycastHit2D R = Physics2D.(selfCollider.transform.position, new Vector2(dir, 0), 1f);

             if (R.collider.tag == "Wall" && turnTimer <= 0)
             {
             //BoxCollider2D C = Physics2D.BoxCast

                 dir = -dir;

                 selfRb.velocity = new Vector2(dir * speed, 0);


                 turnTimer = turnLag;

             }
             else
             {*/

            selfRb.velocity = target;



            autoTurnTimer -= Time.deltaTime;


            if (autoTurnTimer <= 0)
            {

                reverse();

            }

            //}

            //add separate detection for enemy bounds

        }


        


        /*if (posPrev.x == selfRb.position.x)
        {
            autoTurnTimer -= Time.deltaTime;
        }

        posPrev = selfRb.position;
        */

        kbTimer -= Time.deltaTime;
        //turnTimer -= Time.deltaTime;



        /*if (bump(target))
        {

            reverse();

        }*/
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Wall")
        {

            reverse();

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Enemy Bound")
        {

            reverse();

        }

    }

    /*private bool bump(Vector3 target)
    {

        Collider2D g = Physics2D.OverlapBox(selfRb.transform.position + target, new Vector2(0.5f, 0.5f), 0);
        return (g.gameObject.tag == "Wall");

    }*/

    private void reverse()
    {

        dir = -dir;

        
        autoTurnTimer = autoTurnWait;
        //turnTimer = turnLag;
        

    }

}




