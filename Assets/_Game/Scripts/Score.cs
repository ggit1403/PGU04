using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private float score;
    [SerializeField] private TextMeshPro scoretext;
    [SerializeField] private GameObject sword;
    private GameObject bot;
    private void Start()
    {
        sword = GameObject.FindGameObjectWithTag("Damage");
        bot = GameObject.FindGameObjectWithTag("Enemy");

    }
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
