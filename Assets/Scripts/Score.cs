using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    public static int score = 0;

    private void Update()
    {
        if(text!=null)
        text.text = $"Score:{score}";
    }

    
}
