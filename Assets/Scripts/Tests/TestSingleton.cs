using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSingleton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ToolBox.Instance.Get<ItemManager>().gold = 4;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        ToolBox.Instance.Get<ItemManager>().AddItem("key");
    }
}

