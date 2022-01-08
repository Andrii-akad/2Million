using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;

    public float fillSpeed = 0.5f;
    private float targetProgress = 0;
    void Start()
    {
        IncrementProgress(1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value == 1)
            slider.value = 0;
        if (slider.value < targetProgress)
            slider.value += fillSpeed * Time.deltaTime;

    }

    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }
}
