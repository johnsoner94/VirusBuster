using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Script to activate machine gun, wait amount of time, deactivate machine gun and destroy pick up */

public class MachineGunPickUp : MonoBehaviour
{
    
    private static float powerUpDelay = 15f;  // delay time
    
    // If player enters pickup, start coroutine, destroy pickup
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<PlayerController>().StartCoroutine(Countdown(other));
            Destroy(gameObject);
        }
    }

    // activate rapidFire, wait delay time, deactivate rapidfire
    public static IEnumerator Countdown(Collider2D other)
    {
        other.GetComponent<PlayerController>().rapidFire = true;
        yield return new WaitForSeconds(powerUpDelay);
        other.GetComponent<PlayerController>().rapidFire = false;       
    }
}       