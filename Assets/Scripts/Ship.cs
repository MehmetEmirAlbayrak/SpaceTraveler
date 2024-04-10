using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ship : MonoBehaviour
{
    [SerializeField] private GameObject laser;
    [SerializeField] private float speed;
    [SerializeField] private Button button;
    [SerializeField] private GameObject sound;

    private int hp;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fire(0.20f));
        hp = 100;
    }

    // Update is called once per frame
    void Update()
    {


        
            transform.position += new Vector3(speed * Time.deltaTime * Input.GetAxis("Horizontal"), 0,
                -speed * Time.deltaTime * Input.GetAxis("Vertical"));

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -21f, 21f), transform.position.y,
            Mathf.Clamp(transform.position.z, -5f, 5f));
        
    }

    private IEnumerator Fire(float time)
    {
        while (true)
        {
            Vector3 pos = gameObject.transform.GetChild(0).position;
            Instantiate(laser, pos, Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Meteor"))
        {
            hp -= other.GetComponent<Enemy>().getHealth() * 10;
            Instantiate(sound);
            if (hp <= 0)
            {
                Cursor.visible=true;
                button.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    public int GetHp()
    {
        return hp;
    }
}
