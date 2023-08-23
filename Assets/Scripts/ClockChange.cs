using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Clockchange : MonoBehaviour
{

    public TextMeshProUGUI time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time.text = DateTime.Now.ToString();
    }
}
