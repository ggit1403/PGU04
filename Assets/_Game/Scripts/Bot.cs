using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Bot : MonoBehaviour
{
    private GameObject player;
    private float distanse;
    [SerializeField] private float speed;
    public float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null) {
            distanse = Vector2.Distance(transform.position, player.transform.position);
        }
        else
        {
            return;
        }
        
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x)* Mathf.Rad2Deg;
        if(distanse < 18)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Damage")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {
            Destroy(player.gameObject);
            //Time.timeScale = 0f;
        }
    }
}
