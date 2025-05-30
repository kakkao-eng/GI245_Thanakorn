using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] heroPrefabs;

    public GameObject[] HerePrefabs
    {
        get { return heroPrefabs; }
    }

    public static GameManager instance;

    void Awake()
    {
        instance = this;


    }


    private void GeneratePlayerHero()
    {
        int i = Settings.playerPrefabId;
        GameObject heroobj = Instantiate(heroPrefabs[i], new Vector3(46f, 10f, 38f), Quaternion.identity);
        heroobj.tag = "Player";
        Character hero = heroobj.GetComponent<Character>();
        PartyManager.instance.Members.Add(hero);
        
        hero.CharInit(VFXManager.instance, UIManager.instance, 
            InventoryManager.instance, PartyManager.instance); 
        InventoryManager.instance.AddItem(hero, 0);//health potion 
        InventoryManager.instance. AddItem(hero, 2);//Shield A

    }
    
    void Start()
    {
        if (Settings.isNewGame) 
        { 
            Settings.isNewGame = false; 
            GeneratePlayerHero(); 
        } 
        if (Settings.isWarping) 
        { 
            Settings.isWarping = false; 
            WarpPlayers(); 
        }
    }

    private void WarpPlayers()
    {
        PartyManager.instance.LoadAllHeroData();
    }
}