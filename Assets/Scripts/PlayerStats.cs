using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStats
{
    [SerializeField] private float health, stamina;
    // (EJ) elige estructura de datos para almacenar las balas en el orden que las recoges

    Queue<GameObject> gemsQueue;
    public PlayerStats(float health, float stamina)
    {
        // (EJ) lanzar excepcion del tipo HealthValueNotAcceptedException (tienes que crear la clase) si la vida supera 100 o es inferior a 0
        if (health <= 0 || health > 100)
        {
            throw new HealthValueNotAcceptedException();
        }

        // (EJ) lanzar excepcion del tipo StaminaValueNotAcceptedException (tienes que crear la clase) si la stamina supera 100 o es inferior a 0
        if (stamina <= 0 || stamina > 100)
        {
            throw new StaminaValueNotAcceptedException();
        }

        this.health = health;
        this.stamina = stamina;

        // recuerda instanciar la estructura de datos

        gemsQueue = new Queue<GameObject>();
       
    }
    
    public void AddToHealth(float value)
    {
        health += value;
    }

    public void AddToStamina(float value)
    {
        stamina += value;
    }

    public float GetHealth()
    {
        return health;
    }

    public float GetStamina()
    {
        return stamina;
    }

    // (EJ) rellena el metodo para anyadir un gameObject a la estructura
    public void AddToStructure(GameObject o)
    {
        gemsQueue.Enqueue(o);
    }

    // (EJ) construye el metodo que devuelve una bala de la estructura de datos. Si está vacía, lanza una excepcion
    // del tipo 'DataStructureEmptyException' (tienes que crear la clase)
    public GameObject GetBullet()
    {
       

        if(gemsQueue.Count <= 0)
        {
            throw new DataStructureEmptyException();
        }

        GameObject nextGem = gemsQueue.Dequeue();

        return nextGem;
    }
}
