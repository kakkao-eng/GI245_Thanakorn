using UnityEngine; 
using System.Collections.Generic;

public class Npc : Character
{
    
    [SerializeField] private List<Quest> questToGive = new List<Quest>();
    
    [SerializeField] 
    private bool isShopkeeper; 
    public bool IsShopkeeper { get { return isShopkeeper; }} 
    [SerializeField] 
    private List<Item> shopItems = new List<Item>(); 
    public List<Item> ShopItems { get { return shopItems; } set { shopItems = value; } } 
    [SerializeField] 
    private int npcMoney = 3000; 
    public int NpcMoney { get { return npcMoney; } set { npcMoney = value; } }

    public List<Quest> QuestToGive
    {
        get { return questToGive; }
        set { questToGive = value; }
    }
    
    
    public Quest CheckQuestList(QuestStatus status) 
    { 
        foreach (Quest quest in questToGive) 
        { 
            if (quest.Status == status) 
                return quest; 
        } 
        return null; 
    }
    
    
}