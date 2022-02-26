using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Player
{
    public static int health = 100;
    public static int defence = 0;
    public static float energySpeed = 0.4f;
    public static int energy = 0;
    //private Weapon weapon;
    //private Shield shield;

    public static void TakeDamage(int damage)
    {
        if (health - damage < 0)
            health = 0;
        else
            health -= damage;

        GameObject.FindGameObjectWithTag("HealthBar").GetComponent<Image>().fillAmount = (float)health / 100;
    }

}
