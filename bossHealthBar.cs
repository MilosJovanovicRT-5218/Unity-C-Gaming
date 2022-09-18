using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossHealthBar : MonoBehaviour
{
    private Image HealtBar;
    public int CurrentHealth;
    private float MaxHealth = 50f;
    BossHealth Player;
    // Start is called before the first frame update
    void Start()
    {
        HealtBar = GetComponent<Image>();
        Player = FindObjectOfType<BossHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentHealth = Player.health;
        HealtBar.fillAmount = CurrentHealth / MaxHealth;
    }

}
