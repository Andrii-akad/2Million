using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemies/Standart Enemy", fileName = "New Enemy")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private Sprite mainSprite;
    public Sprite MainSprite
    { get { return mainSprite; } protected set { } }
    [SerializeField] private float attackSpeed;
    public float AttackSpeed
    { get { return attackSpeed; } protected set { } }
    [SerializeField] private int health;
    public int Health
    { get { return health; } protected set { } }
    [SerializeField] private int defence;
    public int Defece
    { get { return defence; } protected set { } }
    [SerializeField] private string enemyName;
    public string EnemyName
    { get { return enemyName; } protected set { } }

    [SerializeField] private bool isEnergyFilled = false;
    public bool IsEnergyFilled
    { get { return isEnergyFilled; } set { isEnergyFilled = value; } }

}
