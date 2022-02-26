using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public EnemyData data;
    public Slider slider;

    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = data.MainSprite;
        slider.GetComponent<EnemyEnergyBar>().fillSpeed = data.AttackSpeed;
    }
    public void Init(EnemyData _data)
    {
        data = _data;
        GetComponent<SpriteRenderer>().sprite = data.MainSprite;
    }

    private void FixedUpdate()
    {

    }

    public void FillEnergy()
    {
        data.IsEnergyFilled = true;
        DoAction();
    }

    private void DoAction()
    {
        Player.TakeDamage(10);
        data.IsEnergyFilled = false;

        //"Do damage or other action";
    }
}
