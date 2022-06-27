using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEnemy : MonoBehaviour
{

    public float speed;
    public int dir;
    public Rigidbody2D selfRb;
    public Collider2D selfCollider;
    public Collider2D silCollider;
    public bool contactDmg;

    // Start is called before the first frame update
    void Start()
    {

        Physics2D.IgnoreCollision(selfCollider, silCollider, true);

    }

    // Update is called once per frame
    void Update()
    {

        selfRb.velocity = new Vector2(dir * speed, 0);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Wall")
        {

            dir = dir * -1;

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name == "Enemy Bound")
        {

            dir = dir * -1;

        }

    }

}
