using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastleManager : MonoBehaviour
{
    [SerializeField]
    private Text castleText;
    [SerializeField]
    private int fullCastleHealth;

    private int currentCastleHealth;
    private int enemyPower;

    void Start()
    {
        currentCastleHealth = fullCastleHealth;
        enemyPower = FindObjectOfType<Enemy>().enemyPower;
    }

    void Update()
    {
        castleText.text = currentCastleHealth.ToString() + " / " + fullCastleHealth.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            currentCastleHealth -= enemyPower;
        }
    }
}
