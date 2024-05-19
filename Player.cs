using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;
    public GameObject fireball;
    public Transform attackPoint;
    public int Coins;
    public void CollectCoin()
    {
        Coins += 1;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока: " + health);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireball, attackPoint.position, attackPoint.rotation);
        }
    }
}
