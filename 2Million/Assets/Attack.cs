using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public Text energy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DoAttack()
    {
        int energyAmount = int.Parse(energy.text);
        if (energyAmount > 0)
        {
            energyAmount -= 1;
            energy.text = energyAmount.ToString();
        }
    }
}
