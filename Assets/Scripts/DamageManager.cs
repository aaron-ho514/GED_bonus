using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public static DamageManager instance;
 
    int damage = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ModifyDamage(int objectHP)
    {
        damage += objectHP;
        Debug.Log("Damage dealt: " + damage);      
    }
}
