using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTrigger : MonoBehaviour
{

    private void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController pC = collision.GetComponent<PlayerController>();

        if(pC)
        {
            pC.stats.AddToStructure(gameObject);
            Destroy(this); // elimina este componente de la bala, ya que no lo necesitamos mas
            gameObject.SetActive(false);
        }
    }
}
