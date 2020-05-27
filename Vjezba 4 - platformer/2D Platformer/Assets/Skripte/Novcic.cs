using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Novcic : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PadNaGranicu granica = GameObject.Find("DonjaGranica").GetComponent<PadNaGranicu>();
            granica.Uvecaj();
            Destroy(gameObject);
        }
    }
}
