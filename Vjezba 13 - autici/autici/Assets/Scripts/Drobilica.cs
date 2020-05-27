using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drobilica : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ProtivnickiAuto")
        {
            Destroy(collision.gameObject);
        }
    }
}
