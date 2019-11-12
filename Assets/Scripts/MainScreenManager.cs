using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScreenManager : MonoBehaviour
{
    [SerializeField] GameObject masterPopupViewPrefab;
    [SerializeField] GameObject skillPanelPrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCllickSkillIcon()
    {
        MasterViewManager masterPopView
            = Instantiate(masterPopupViewPrefab , gameObject.transform).GetComponent<MasterViewManager>();
        masterPopView.Title = "스킬";
        SkillPanelManager skillPanelManager
            = Instantiate(skillPanelPrefab, masterPopView.transform).GetComponent<SkillPanelManager>();

    }
}
