using UnityEngine;

public enum ItemType
{
    Consumable,
    Equipment,
    Weapon,
    Ammo,
    Quest,
    Other
}
<<<<<<< HEAD

[System.Serializable]
public class Item
{
    [SerializeField] 
    private int id;
    public int ID { get { return id; } }
    
    [SerializeField] 
    private string itemName;
    public string ItemName { get { return itemName; } }
    
    [SerializeField] 
    private ItemType type;
    public ItemType Type { get { return type; } }
    
    [SerializeField] 
    private Sprite icon;
    public Sprite Icon { get { return icon; } }
    
    [SerializeField] 
    private int power;
=======
[System.Serializable]
public class Item
{
    [SerializeField] private int id;
    public int ID { get { return id; } }
    
    [SerializeField] private string itemName;
    public string ItemName { get { return itemName; } }

    [SerializeField] private ItemType type;
    public ItemType Type { get { return type; } }

    [SerializeField] private Sprite icon;
    public Sprite Icon { get { return icon; } }

    [SerializeField] private int power;
>>>>>>> 97cf407b5fca2a66d99ee60a63b2640cb85d351e
    public int Power { get { return power; } }

    public Item(ItemData data)
    {
        id = data.id;
        itemName = data.itemName;
        type = data.type;
        icon = data.icon;
        power = data.power;
    }
<<<<<<< HEAD
=======

>>>>>>> 97cf407b5fca2a66d99ee60a63b2640cb85d351e
}
