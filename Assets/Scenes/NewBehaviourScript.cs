using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text label;

    // Start is called before the first frame update
    void Start()
    {
        label.text = "当前分支: " + "123";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}