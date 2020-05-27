using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class postaviBodove : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("Bodovi").GetComponent<Text>().text = Score.Bodovi.ToString();
    }
}
