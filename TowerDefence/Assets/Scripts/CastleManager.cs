using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastleManager : MonoBehaviour
{
    [SerializeField] private Text castleText;
    [SerializeField] private int fullCastleHealth;
    [SerializeField] private Enemy enemyPrefab;

    private int currentCastleHealth;

    void Start()
    {
        currentCastleHealth = fullCastleHealth;
    }

    void Update()
    {
        castleText.text = currentCastleHealth.ToString() + " / " + fullCastleHealth.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int enemyPower = collision.gameObject.GetComponent<Enemy>().enemyPower;
        if (collision.tag == "Enemy")
        {
            currentCastleHealth -= enemyPower;
            Destroy(collision.gameObject);
        }
    }
}
