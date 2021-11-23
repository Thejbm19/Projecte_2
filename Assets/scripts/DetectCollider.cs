using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollider : MonoBehaviour
{
   private void OnTriggerEnter (Collider otherCollider)
    {
        // Destruye el proyectil
        Destroy(gameObject);
        
        //Destruye animal que colisiona
        Destroy(otherCollider.gameObject);
    }
}
