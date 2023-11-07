using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenFlower : MonoBehaviour
{
    public Collider2D selfCollider;
    public SpriteRenderer selfSpriteRenderer;
    public GameObject sil;
    public bool initialSetting;
    public float colorRed;
    public float colorGreen;
    public float colorBlue;
    public float fullAlpha;
    public float offAlpha;

    // Start is called before the first frame update
    void Start()
    {

        sil = GameObject.Find("Sil");

    }

    // Update is called once per frame
    void Update()
    {

        if (initialSetting == true)
        {

            if (sil.GetComponent<SilControl>().greenFlowerToggle == true)
            {

                selfCollider.enabled = true;
                selfSpriteRenderer.color = new Color(colorRed, colorGreen, colorBlue, fullAlpha);

            }

            if (sil.GetComponent<SilControl>().greenFlowerToggle == false)
            {

                selfCollider.enabled = false;
                selfSpriteRenderer.color = new Color(colorRed, colorGreen, colorBlue, offAlpha);

            }

        }

        if (initialSetting == false)
        {

            if (sil.GetComponent<SilControl>().greenFlowerToggle == true)
            {

                selfCollider.enabled = false;
                selfSpriteRenderer.color = new Color(colorRed, colorGreen, colorBlue, offAlpha);

            }

            if (sil.GetComponent<SilControl>().greenFlowerToggle == false)
            {

                selfCollider.enabled = true;
                selfSpriteRenderer.color = new Color(colorRed, colorGreen, colorBlue, fullAlpha);

            }

        }


    }

}
