using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject Players;


    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject == Players)
        {
            Debug.Log("on");
            Players.transform.parent = transform;
        }


        
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == Players)
        {
            Debug.Log("off");
            Players.transform.parent = null;
        }

        
    }
}
