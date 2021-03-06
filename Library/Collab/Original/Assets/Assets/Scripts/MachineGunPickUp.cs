using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunPickUp : MonoBehaviour
{

    private static float powerUpDelay = 15f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

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
        if (other.GetComponent<PlayerController>().rapidFire == true)
        {
            Debug.Log("RapidFire is ON");
        }
        yield return new WaitForSeconds(powerUpDelay);
        other.GetComponent<PlayerController>().rapidFire = false;
        if (other.GetComponent<PlayerController>().rapidFire == false)
        {
            Debug.Log("rapidFire is OFF");
        }
    }
}       