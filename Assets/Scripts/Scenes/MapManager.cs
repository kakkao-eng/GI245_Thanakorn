using UnityEngine; 
using UnityEngine. SceneManagement;

public class MapManager : MonoBehaviour
{
    [SerializeField] private Transform[] enterPoints;

    public Transform[] EnterPoints
    {
        get { return enterPoints; }
    }

    public static MapManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void GoToMap(string mapName, int enterPointId)
    {
        Settings.isWarping = true;
        Settings.enterPointId = enterPointId;
        Settings.partyCount = PartyManager.instance.Members.Count;
        PartyManager.instance.SaveAllHeroData();
        SceneManager.LoadScene(mapName);

    }
}