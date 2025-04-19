using UnityEngine;

public class InventoryManager : MonoBehaviour
{
<<<<<<< HEAD
    
    [SerializeField] 
    private GameObject[] itemPrefabs; 
    public GameObject[] ItemPrefabs 
    { get { return itemPrefabs; } set { itemPrefabs = value; } } 
    
    [SerializeField] 
    private ItemData [] itemData; 
    public ItemData [] ItemData 
    { get { return itemData; } set { itemData = value; } } 
    
    public const int MAXSLOT = 16;
    
    public static InventoryManager instance; 
    void Awake() 
    { 
        instance = this; 
=======
    [SerializeField]
    private GameObject[] itemPrefabs;
    public GameObject[] ItemPrefabs
    {
        get { return itemPrefabs; }
        set { itemPrefabs = value; }
    }

    [SerializeField]
    private ItemData[] itemData;
    public ItemData[] ItemData
    {
        get { return itemData; }
        set { itemData = value; }
    }

    public const int MAXSLOT = 16;

    public static InventoryManager instance;

    void Awake()
    {
        instance = this;
>>>>>>> 97cf407b5fca2a66d99ee60a63b2640cb85d351e
    }

    public bool AddItem(Character character, int id)
    {
        Item item = new Item(itemData[id]);
        for (int i = 0; i < character.InventoryItems.Length; i++)
        {
            if (character.InventoryItems[i] == null)
            {
                character.InventoryItems[i] = item;
                return true;
            }
        }

        Debug.Log("Inventory Full");
        return false;
    }
<<<<<<< HEAD
    
    public void SaveItemInBag(int index, Item item) 
    { 
        if (PartyManager.instance. SelectChars.Count == 0) 
            return; 
        PartyManager.instance. SelectChars[0].InventoryItems [index] = item; 
    }

    public void RemoveItemInBag(int index)
    {
        if (PartyManager.instance.SelectChars.Count == 0)
            return;
        PartyManager.instance.SelectChars[0].InventoryItems[index] = null;
    }


}
=======
}

>>>>>>> 97cf407b5fca2a66d99ee60a63b2640cb85d351e
