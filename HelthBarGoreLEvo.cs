using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelthBarGoreLEvo : MonoBehaviour
{
    private Image HealtBar;
    public int CurrentHealth;
    private float MaxHealth = 100f;
    Health2 Player;
    // Start is called before the first frame update
    void Start()
    {
        HealtBar = GetComponent<Image>();
        Player = FindObjectOfType<Health2>();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentHealth = Player.Health;
        HealtBar.fillAmount = CurrentHealth / MaxHealth;
    }

}
