using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappleTargeted : MonoBehaviour
{

    public GameObject sil;
    public Rigidbody2D self;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (sil.GetComponent<SilControl>().grappleTargeted)
        {

            self.transform.position = new Vector2(sil.GetComponent<SilControl>().grappleTargetPassive.x, sil.GetComponent<SilControl>().grappleTargetPassive.y);

            self.GetComponent<SpriteRenderer>().enabled = false;

        }
        else {

            self.GetComponent<SpriteRenderer>().enabled = true;

        }

    }
}
