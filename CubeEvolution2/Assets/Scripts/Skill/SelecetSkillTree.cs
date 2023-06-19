using System.Collections.Generic;
using UnityEngine;

public class SelecetSkillTree : CharacterSelection
{
    [Header("Tabs")]
    [SerializeField] private List<GameObject> _skillTree;

    private void OnEnable()
    {
        SelectSkillTree();
        
        UserData.AddMoney(50);
        UserData.AddDonate(5);
    }

    private void SelectSkillTree()
    {        
        for (int i = 0; i < _skillTree.Count; i++)
        {
            if (i == SelectionCharacter)
                _skillTree[i].SetActive(true);
            
            else _skillTree[i].SetActive(false);
        }
    }
}
