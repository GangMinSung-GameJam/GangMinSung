using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float HP = 200;

    public int selectedBullet;
    float angle;
    Vector2 target, mouse;

    private void Start()
    {
        target = transform.position;
    }
    void Update()
    {
        fire();
        SelectBullet();
        swap();
    }
    public void SelectBullet()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedBullet) { weapon.gameObject.SetActive(true); }
            else if(i == 3) { weapon.gameObject.SetActive(true); }
            else { weapon.gameObject.SetActive(false); }
            i++;
        }
    }
    void swap()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (selectedBullet >= 2)
                selectedBullet = 0;
            else
                selectedBullet++;
        }
    }
    public void fire()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angle = Mathf.Atan2(mouse.y - target.y, mouse.x - target.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);


    }
}
