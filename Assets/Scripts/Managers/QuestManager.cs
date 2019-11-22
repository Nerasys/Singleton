using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] public List<Quest> quests = new List<Quest>();

    private void Start()
    {
        quests.Add(new Quest()
        {
            category = Quest.Category.Item,
            target = "key",
            reward = 100
        });

        //Faire un EventManager
        ToolBox.Instance.Get<ItemManager>().OnUpdateInventory += OnUpdateInventory;
    }



    void OnUpdateInventory()
    {
        foreach ( var quest in quests)
        {
            if(!quest.done && quest.category == Quest.Category.Item)
            {
                if (ToolBox.Instance.Get<ItemManager>().HasItem(quest.target))
                {
                    quest.done = true;
                    ToolBox.Instance.Get<ItemManager>().gold += quest.reward;
                }
            }
        }

    }


    private void OnDestroy()
    {
        if(ToolBox.Instance.Get<ItemManager>() != null)
        {
            ToolBox.Instance.Get<ItemManager>().OnUpdateInventory -= OnUpdateInventory;
        }
    }



}
