using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int currentPlayerHealth = 10;
    public int enemyDamage = 5;

    void Start()
    {

    }

    public void HurtPlayer()
    {
        currentPlayerHealth -= enemyDamage;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HitCollider"))
        {
            HurtPlayer();
        }
    }
}
