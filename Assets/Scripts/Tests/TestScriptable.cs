﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptable : MonoBehaviour
{
    private void Start()
    {
        ItemManagerParameters itemManagerParameters = Resources.Load<ItemManagerParameters>("ItemManagerParameters");
        GameObject go = new GameObject();
        go.AddComponent<MeshRenderer>();
        go.AddComponent<MeshFilter>().mesh = itemManagerParameters.defaultVisual;


    }
}
