using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunPickUp : MonoBehaviour
{
    /* Script to activate machine gun, wait amount of time, deactivate machine gun and destroy pick up */
    private static float powerUpDelay = 15f;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<PlayerController>().StartCoroutine(Countdown(other));
            Destroy(gameObject);
        }
    }

    public static IEnumerator Countdown(Collider2D other)
    {
        other.GetComponent<PlayerController>().rapidFire = true;
        yield return new WaitForSeconds(powerUpDelay);
        other.GetComponent<PlayerController>().rapidFire = false;       
    }
}       