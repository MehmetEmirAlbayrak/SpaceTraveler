using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Laser : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private ParticleSystem part;
    [SerializeField] private GameObject hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = speed * Vector3.up;
        if (gameObject.transform.position.y > 50)
            Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Meteor"))
        {
            part.Play();
            Instantiate(hit);
            Invoke("Dest", 1);
        }
    }

    private void Dest()
    {
        Destroy(gameObject);
    }

}
