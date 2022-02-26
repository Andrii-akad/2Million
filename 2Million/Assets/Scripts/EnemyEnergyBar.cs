using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyEnergyBar : MonoBehaviour
{
    public Slider slider;
    public GameObject enemy;
    public float fillSpeed;
    private float targetProgress = 0;
    void Start()
    {
        IncrementProgress(1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value == 1)
        {
            enemy.GetComponent<Enemy>().FillEnergy();

            slider.value = 0;
        }
        if (slider.value < targetProgress)
            slider.value += fillSpeed * Time.deltaTime;

    }

    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }
}
