using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;

    void OnTriggerEnter2D(Collider2D other)
    {
       if (other.CompareTag("Player"))
        {
            //Player takes one hit
            other.GetComponent<PlayerCharacter>().health -= damage;
            Debug.Log(other.GetComponent<PlayerCharacter>().health);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
