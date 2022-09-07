using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayCtrl : MonoBehaviour
{

    #region variables

    public GameObject sil;

    //game state vars
    private int silHealthMax = 6;
    public static int silHealth = 6;
    //silInv set in SilControl.cs
    public static bool silInv;
    private bool hurt;


    //ability vars
    public static int climbDigClaws = 2; //stores whether Sil has the climbing claws or the digging claws or neither
                                     //(0 = neither, 1 = climbing claws, and 2 = both the climbing claws and the digging claws)
    public static int multiJump = 3; //stores how many extra air jumps the player has
    //whether or not the player has the bash or the tether
    public static bool bash = true; 
    public static bool tether = true;


    #endregion


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (silInv)
        {

            if (!hurt) {

                silHealth -= 1;

                hurt = true;

            }

            Debug.Log(silHealth);

        }
        else
        {

            hurt = false;
            Debug.Log("deactivated");

        }
        
    }
}
