using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bulletBounce"))
        {
            this.gameObject.tag = "Bounceable";
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;

        }

        if (other.gameObject.CompareTag("speed"))
        {
            this.gameObject.tag = "speedy";
            gameObject.GetComponent<Renderer>().material.color = Color.red;

        }
    }
}
