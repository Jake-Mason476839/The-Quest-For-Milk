using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kill_Count : MonoBehaviour
{
    Text text;
    public static int killCounter;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = killCounter.ToString();
    }
}
