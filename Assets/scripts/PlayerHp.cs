using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    [SerializeField] Slider hpbar;
    player player;
    private void Start()
    {
        player = GetComponent<player>();
        hpbar.maxValue = player.maxHp;
        hpbar.value = player.currenthp;
    }

    void Update()
    {
        hpbar.value = player.currenthp;
    }
}
