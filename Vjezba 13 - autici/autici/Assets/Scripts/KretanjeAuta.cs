using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KretanjeAuta : MonoBehaviour
{
    public float carSpeed;
    public float MaxPos = 2.3f;
    Vector3 position;

    public Rezultat UI;

    private void Start()
    {
        position = transform.position;
    }

    private void Update()
    {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -2.4f, 2.4f);
        transform.position = position;

        position.y += Input.GetAxis("Vertical") * carSpeed * Time.deltaTime;
        position.y = Mathf.Clamp(position.y, -4f, 3.2f);
        transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag == "ProtivnickiAuto")
        {
            Destroy(gameObject);
            UI.GameOverActivated();
        } 
    }
}
