using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPad : MonoBehaviour

{
    public Transform player, destination;
 public GameObject playerg;
 
 void OnTriggerEnter(Collider other){
  if(other.CompareTag("CompleteXROriginSetUp")){
   playerg.SetActive(false);
   player.position = destination.position;
   playerg.SetActive(true);
  }
 }
}