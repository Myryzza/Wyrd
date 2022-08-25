using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
{

    public GameObject sil;
    public Rigidbody2D silRb;
    public Rigidbody2D swordRb;
    public BoxCollider2D enemyAtkCollider;
    public float offset;

    public int damage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        swordRb.position = new Vector2(silRb.position.x + sil.GetComponent<SilControl>().aim.normalized.x * offset, silRb.position.y + sil.GetComponent<SilControl>().aim.normalized.y * offset);

        //swordRb.transform.LookAt(silRb.position, Vector3.forward);

        var dir = silRb.position - swordRb.position;
        var angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
        swordRb.transform.rotation = Quaternion.AngleAxis(-angle - 90, Vector3.forward);



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.GetComponent<HealthScript>() != null)
        {

            HealthScript health = collision.GetComponent<HealthScript>();
            //GroundEnemy enemy = collision.GetComponent<GroundEnemy>();

            if (!health.invulnerable) {

                health.health -= damage;
                Debug.Log("Activated");
                
                //enemy.selfRb.velocity = new Vector2(silRb.GetComponent<Rigidbody2D>().position.x - enemy.selfRb.position.x, silRb.GetComponent<Rigidbody2D>().position.y - enemy.selfRb.position.y).normalized * -kbDist;

            }

        }

    }

}
