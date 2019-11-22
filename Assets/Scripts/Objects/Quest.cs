using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest 
{
    public enum Category
    {
            Hunt,
            Item

    }

    public Category category;
    public string target;
    public int reward;
    public bool done = false ;

}
