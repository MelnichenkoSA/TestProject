using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZoneView : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Gorim");

        if (other.gameObject.tag == "Player")
        {
            PlayerController playercontroller = FindObjectOfType<PlayerController>();

            playercontroller.InDamageZoneAction.Invoke(1);

        }
    }
    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Ne Gorim");

        if (other.gameObject.tag == "Player")
        {
            PlayerController playercontroller = FindObjectOfType<PlayerController>();

            playercontroller.OutDamageZoneAction.Invoke();

        }
    }
}
