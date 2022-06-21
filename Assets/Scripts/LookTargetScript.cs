using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTargetScript : MonoBehaviour
{

    public Rigidbody2D selfRb;
    public Rigidbody2D silRb;
    public GameObject sil;
    public float multiplier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        selfRb.position = new Vector2(silRb.position.x, silRb.position.y + sil.GetComponent<SilControl>().aim.y * multiplier);

    }
}
