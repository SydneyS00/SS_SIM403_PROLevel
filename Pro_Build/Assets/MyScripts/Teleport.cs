using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    //VARIABLES

    //The transform information for our player and our destination plates
    public Transform player;
    public Transform destination;

    //The teleporter??
    public GameObject playerg;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerg.SetActive(false);
            player.position = destination.position;
            playerg.SetActive(true); 
        }
    }


}
