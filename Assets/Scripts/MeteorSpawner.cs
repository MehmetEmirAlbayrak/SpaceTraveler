using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] meteor;
    [SerializeField] private GameObject[] particle;

    private GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(SpawnAndWait(1.0f));
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private IEnumerator SpawnAndWait(float time)
    {
        float speed = 40;
        var wait = new WaitForSeconds(time);
        while (true)
        {
            int index = Random.Range(0, 3);
            Vector3 spawn = new Vector3(Random.Range(-20, 21), 500, Random.Range(-5,6));
            enemy = Instantiate(meteor[index], spawn,
                Quaternion.Euler(new Vector3(Random.Range(0f,360f),Random.Range(0f,360f),Random.Range(0f,360f))));
            enemy.GetComponent<Enemy>().setSpeed(speed + Random.value, particle[index]);
            
            speed += 0.5f;
            yield return wait;
        }
    }
}
