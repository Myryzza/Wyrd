using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{

    public Rigidbody2D cursorRb;
    public Rigidbody2D silRb;
    public GameObject sil;
    public float offset;
    public SpriteRenderer spriteRenderer;
    public float moveSpeed;
    private Vector2 currentSpeed;


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

        cursorRb.position = Vector2.SmoothDamp(cursorRb.position, new Vector2(silRb.position.x + sil.GetComponent<SilControl>().aim.normalized.x * offset, silRb.position.y + sil.GetComponent<SilControl>().aim.normalized.y * offset), ref currentSpeed, moveSpeed);

        

        var dir = silRb.position - cursorRb.position;
        var angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
        cursorRb.transform.rotation = Quaternion.AngleAxis(-angle - 90, Vector3.forward);


        spriteRenderer.color = new Color(1, 1, 1, sil.GetComponent<SilControl>().aim.magnitude / 2);


    }
}
