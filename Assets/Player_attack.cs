using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_attack : MonoBehaviour
{
    // Attack
    [SerializeField] private float attack_Speed;
    [SerializeField] private float waiting_time;
    [SerializeField] private Animator anim;
    void Update()
    {
        if (attack_Speed <= 0f)
        {
            if (Input.GetMouseButtonDown(0))
            {
                anim.SetTrigger("Attack");
                attack_Speed = waiting_time;
                Debug.Log("attack");
            }

        }
        else
        {
            attack_Speed -= Time.deltaTime;
        }
    }
}
