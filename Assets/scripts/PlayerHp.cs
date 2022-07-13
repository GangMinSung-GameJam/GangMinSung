using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    public Slider hpbar;
    player player;
    private void Start()
    {
        player = GetComponent<player>(); 
    }

    void Update()
    {
        hpbar.value = player.currenthp / player.maxHp;
    }
}
