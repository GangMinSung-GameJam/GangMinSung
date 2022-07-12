using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float maxHp = 200;
    public float currenthp= 200;
    public int selectedBullet;
    float angle;
    Vector2 target, mouse;

    private void Start()
    {
        maxHp = currenthp;
        target = transform.position;
    }
    void Update()
    {
        fire();
        SelectBullet();
        swap();
        if(currenthp <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
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
            if (selectedBullet >= transform.childCount  - 1)
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
