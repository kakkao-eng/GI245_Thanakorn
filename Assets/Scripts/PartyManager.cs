using System;
using System.Collections.Generic;
using UnityEngine;

public class PartyManager : MonoBehaviour
{
    [SerializeField] private List<Character> members = new List<Character>();
    public List<Character> Members
    {
        get { return members; }
    }

    [SerializeField]
    private List<Character> selectChars = new List<Character>();
    public List<Character> SelectChars { get { return selectChars; } }
    public static PartyManager instance;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        foreach (Character c in members)
        {
            c.CharInit(VFXManager.instance,
                UIManager.instance, InventoryManager.instance);
        }

        SelectSingleHero(0);
        members[0].MagicSkills.Add(new Magic(VFXManager.instance.MagicDatas[0]));
        members[1].MagicSkills.Add(new Magic(VFXManager.instance.MagicDatas[1]));
        
        InventoryManager.instance. AddItem(members[0], 0);//Health Potion 
        InventoryManager.instance.AddItem(members[0], 1);//Sword 
        
        InventoryManager.instance.AddItem(members [1], 0);//Health Potion 
        InventoryManager.instance.AddItem(members [1], 1);//Sword 
        InventoryManager.instance. AddItem(members [1], 2);//Shield A
        InventoryManager.instance. AddItem(members [1], 3);//Shield A
        
        
        UIManager.instance.ShowMagicToggles();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (selectChars.Count > 0)
            {
                    selectChars[0].IsMagicMode = true;
                    selectChars[0].CurMagicCast = selectChars[0].MagicSkills[0];
            }
        }
    }

    public void SelectSingleHero(int i)
    {
        foreach (Character c in selectChars)
            c.ToggleRingSelection(false);
            
        selectChars.Clear();
            
        selectChars.Add(members[i]);
        selectChars[0].ToggleRingSelection(true);
    }

    public void HeroSelectMagicSkill(int i)
    {
        if (selectChars.Count <= 0)
            return;

        selectChars[0].IsMagicMode = true;
        selectChars[0].CurMagicCast = selectChars[0].MagicSkills[i];
        
    }
}
