using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PadNaGranicu : MonoBehaviour
{
    private Text bodoviTekst;
    private int bodovi;

    public void Start()
    {
        bodoviTekst = GameObject.Find("bodovi").GetComponent<Text>();
        bodoviTekst.text = "0";
    }

    public void Uvecaj()
    {
        bodovi++;
        bodoviTekst.text = bodovi.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Score.Bodovi = bodovi;
            Application.LoadLevel("Win");
        }
    }
}
