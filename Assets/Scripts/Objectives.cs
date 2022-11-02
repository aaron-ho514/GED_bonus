using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectives : MonoBehaviour
{
    public int health;
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {

            DamageManager.instance.ModifyDamage(health);

            Destroy(gameObject);
        }
    }
}
