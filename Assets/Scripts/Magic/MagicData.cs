using UnityEngine;

[CreateAssetMenu(fileName = "MagicData", menuName = "Scriptable Objects/MagicData")]
public class MagicData : ScriptableObject
{
    public int id;
    public string maicName;
    public float range;
    public int power;
    public float loadTime;
    public float shootTime;
    public int loadId;
    public int shootId;
}
