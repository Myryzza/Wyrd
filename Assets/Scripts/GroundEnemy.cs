using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEnemy : MonoBehaviour
{

    public float speedDefault;
    public float recoilSpeedDefault;
    private float speed;
    public float kbDist;
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

        if (health.invulnerable)
        {

            selfRb.velocity = new Vector2(silCollider.GetComponent<Rigidbody2D>().position.x - selfRb.position.x, silCollider.GetComponent<Rigidbody2D>().position.y - selfRb.position.y).normalized * -kbDist;

        }
        else
        {

            selfRb.velocity = new Vector2(dir * speed, 0);

        }

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
