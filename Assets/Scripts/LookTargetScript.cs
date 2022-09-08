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

    // Start is called before the first frame update
    void Start()
    {

        selfRb.position = silRb.position;
        lookTarget = silRb;

    }

    // Update is called once per frame
    void Update()
    {

        lookTarget = sil.GetComponent<SilControl>().lookTarget;
        
        if (lookTarget == silRb)
        {

            selfRb.position = new Vector2(Mathf.Lerp(silRb.position.x, selfRb.position.x, moveSpeed),
                Mathf.Lerp(silRb.position.y + sil.GetComponent<SilControl>().aim.y * multiplier, selfRb.position.y, moveSpeed));

        }
        else
        {

            selfRb.position = new Vector2(Mathf.Lerp(lookTarget.position.x, selfRb.position.x, moveSpeed), Mathf.Lerp(lookTarget.position.y, selfRb.position.y, moveSpeed));

        }
        
    }
}
