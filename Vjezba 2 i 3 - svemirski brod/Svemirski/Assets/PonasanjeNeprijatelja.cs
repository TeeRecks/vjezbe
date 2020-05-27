using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PonasanjeNeprijatelja : MonoBehaviour
{
    public GameObject projektil;
    public float snaga = 150;
    public float PucanjuSekundi = 4f;
    public float brzinaProjektila = 10;
    public int rezultatValue = 150;
    private PrikazRezultata prikazRezultata;
    public AudioClip zvukPucnja;
    public AudioClip zvukUnistenja;

    private void Start()
    {
        prikazRezultata = GameObject.Find("Rezultat").GetComponent<PrikazRezultata>();
    }

    private void Update()
    {
        //dodao *0.2f jer neprijatelji pucaju prebrzo, u suprotnom se oko 20-ak lasera prikazuje na ekranu odjednom, ponekad čak i više
        float vjerojatnost = PucanjuSekundi * Time.deltaTime * 0.2f;
        if (Random.value < vjerojatnost)
        {
            Fire();
        }
    }

    void Fire()
    {
        Vector3 offset = new Vector3(0, -1.0f, 0);
        Vector3 polozajpucnja = transform.position + offset;
        GameObject missile = Instantiate(projektil, polozajpucnja, Quaternion.identity) as GameObject;
        missile.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -brzinaProjektila);
        AudioSource.PlayClipAtPoint(zvukPucnja, transform.position);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Projektil missile = collision.gameObject.GetComponent<Projektil>();
        if (missile)
        {
            missile.Hit();
            snaga -= missile.GetDamage();
            if (snaga <= 0)
            {
                Die();
            }
        }
    }

    void Die()
    {
        prikazRezultata.Rezultat(rezultatValue);
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(zvukUnistenja, transform.position);
    }
}
