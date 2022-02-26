using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    private int stage = 0;
    //public Experience experience;
    public Sprite sprite;
    //public List<AttackSkills> attackSkills;
    public int slotsAmount;
    //public Attributes attributes;

    private void Start()
    {
        transform.GetChild(0).gameObject.GetComponent<Image>().sprite = sprite;
        Debug.Log(stage);
    }
}
