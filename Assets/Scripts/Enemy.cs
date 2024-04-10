using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject sound;
    private GameObject particle;
    private float speed;
    private int health;
    
    // Start is called before the first frame update
    void Start()
    {
        
        health = Random.Range(1,4);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Vector3.down*Time.deltaTime;
        transform.localScale = new Vector3(health, health, health);
        transform.Rotate(Vector3.one * Time.deltaTime * Random.Range(25,50));



    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Laser"))
        {
            health--;
            if (health == 0)
            {
                Instantiate(particle,transform.position,Quaternion.identity);
                Instantiate(sound);
                Score.score++;
                Destroy(gameObject);


            }
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ship"))
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }


    public void setSpeed(float speed,GameObject prefab)
    {
        this.speed = speed;
        particle = prefab;

    }

    public int getHealth()
    {
        return health;
    }
}
