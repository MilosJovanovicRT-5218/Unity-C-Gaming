using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyCanvasHealth : MonoBehaviour
{
    private Image HealtBar;
    public int health;
    private int MaxHealth = 5;
    CharacterStats Enemy;
    // Start is called before the first frame update
    void Start()
    {
        HealtBar = GetComponent<Image>();
        Enemy = FindObjectOfType<CharacterStats>();
    }

    // Update is called once per frame
    void Update()
    {
        health = Enemy.health;
        HealtBar.fillAmount = health / MaxHealth;
    }
}
