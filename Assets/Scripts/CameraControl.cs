using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject sil;
    public float camZ;
    public float followSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(sil.transform.position.x, sil.transform.position.y, camZ );

    }

    private void LateUpdate()
    {



    }

}
