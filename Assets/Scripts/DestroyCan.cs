using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCan : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
{
    Debug.Log ("Trigger: " + other.gameObject.name);
    Debug.Log ("binned");
   Destroy(other);

}
   }


   