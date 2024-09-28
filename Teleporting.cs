using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporting : MonoBehaviour
{
    public transform teleportTarget;
    public GameObject thePlayer;


    void OnTriggerEnter

    {
        thePlayer.transform.position = teleportTarget.transform.position;
    }
}
