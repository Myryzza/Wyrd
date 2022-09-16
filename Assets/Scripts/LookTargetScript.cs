using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTargetScript : MonoBehaviour
{

    public Rigidbody2D selfRb;
    public Rigidbody2D silRb;
    public GameObject sil;
    public float multiplier;
    public Rigidbody2D lookTarget;
    public float moveSpeed;
    private Vector2 currentSpeed;
    public Vector2 something;

    // Start is called before the first frame update
    void Start()
    {

        selfRb.position = silRb.position;
        lookTarget = silRb;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        lookTarget = sil.GetComponent<SilControl>().lookTarget;
       
        if (lookTarget == silRb)
        {

           selfRb.position = Vector2.SmoothDamp(selfRb.position, new Vector2(silRb.position.x, silRb.position.y + sil.GetComponent<SilControl>().aim.y * multiplier), ref currentSpeed, moveSpeed);

        }
        else
        {

            //selfRb.position = new Vector2(Mathf.Lerp(lookTarget.position.x, selfRb.position.x, moveSpeed), Mathf.Lerp(lookTarget.position.y, selfRb.position.y, moveSpeed));

            selfRb.position = Vector2.SmoothDamp(selfRb.position, lookTarget.position, ref currentSpeed, moveSpeed);

        }
        

    }
}
