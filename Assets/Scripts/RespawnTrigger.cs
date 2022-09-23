using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnTriggerScript : MonoBehaviour
    {

        [HideInInspector] public Vector2 respawnPos;

        private void Start()
        {

            respawnPos = new Vector2(transform.GetChild(0).transform.position.x, transform.GetChild(0).transform.position.y);

        }

    }
