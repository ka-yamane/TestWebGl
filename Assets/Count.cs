using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public Text text;

    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        count = PlayerPrefs.GetInt("aa", 0);
        text.text = count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            count++;

            text.text = count.ToString();

            PlayerPrefs.SetInt("aa",count);
        }
    }
}
