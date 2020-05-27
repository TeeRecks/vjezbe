using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generiraj : MonoBehaviour
{
    public GameObject stijene;
    int rezultat = 0;

    private void Start()
    {
        InvokeRepeating("KreirajStjene", 1f, 1.5f);
    }

    private void OnGUI()
    {
        GUI.color = Color.black;
        GUILayout.Label("Rezultat: " + rezultat.ToString());
    }

    void KreirajStjene()
    {
        Instantiate(stijene);
        rezultat++;
    }
}
