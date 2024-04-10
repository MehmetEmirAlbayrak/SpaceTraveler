using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    [SerializeField] private float speedY;
    [SerializeField] private Material scrollMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scrollMaterial.mainTextureOffset = new Vector2(speedY * Time.realtimeSinceStartup, 0);
    }
}
