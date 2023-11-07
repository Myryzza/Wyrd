using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeScript : MonoBehaviour
{

    public GameObject self;
    public GameObject grappleTrigger;
    public GameObject bashTrigger;
    public float speed;
    private bool canMove;
    public float destroySelfAlarm;
    public bool destroySelf;

    // Start is called before the first frame update
    void Start()
    {

        canMove = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {

            transform.Translate(1 * speed, 0, 0);

        }


        if (destroySelfAlarm <= 0)
        {

            Destroy(self);

        }

        destroySelfAlarm -= Time.deltaTime;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Floor" || collision.gameObject.tag == "Ceiling")
        {

            canMove = false;
            grappleTrigger.SetActive(true);
            bashTrigger.SetActive(true);

        }

    }

}
