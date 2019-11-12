using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillPanelManager : MonoBehaviour , ISkillButton
{
    [SerializeField] Text Skillname;
    [SerializeField] Text SkillPoint;
    [SerializeField] Text SkillInfoText;
    [SerializeField] Image SkillImage;
    [SerializeField] Image T1_SkillImage;
    [SerializeField] Image T2_1_SkillImage;

    int currentPoint = 10;

    List<SkillData> skillDatas = new List<SkillData>();
    SkillInfoes skillInfoes;
    SkillData skillData;
    private void Awake()
    {
        SkillData T1SkillData = new SkillData();

        T1SkillData.SkillName = "섬광";
        T1SkillData.SkillLevel = 1;
        T1SkillData.SkillNeedMana = 15;
        T1SkillData.SkillDamage = 25;
        T1SkillData.SkillInfoText = $"섬광탄을 던져서 {T1SkillData.SkillNeedMana} 만큼의 마나를 소비하여 적에게 {T1SkillData.SkillDamage} 만큼의 대미지를 입힙니다.";
        T1SkillData.SkillNeddLevel = 1;
        T1SkillData.sprite = T1_SkillImage.sprite;

        SkillData T2_1_SkillData = new SkillData();

        T2_1_SkillData.SkillName = "2티어 섬광";
        T2_1_SkillData.SkillLevel = 1;
        T2_1_SkillData.SkillDamage = 45;
        T2_1_SkillData.SkillNeedMana = 30;
        T2_1_SkillData.SkillInfoText = $"2티어 섬광탄을 던져서 {T2_1_SkillData.SkillNeedMana} 만큼의 마나를 소비하여 적에게 {T2_1_SkillData.SkillDamage} 만큼의 대미지를 입힙니다.";
        T2_1_SkillData.SkillNeddLevel = 5;
        T2_1_SkillData.sprite = T2_1_SkillImage.sprite;

        skillDatas.Add(T1SkillData);
        skillDatas.Add(T2_1_SkillData);

        FileManager<SkillInfoes>.Save(skillInfoes, "data.json");    
    }
    public void DidSelctSkill(SkillButton skillButton)
    {
        int index = skillDatas.IndexOf(skillData);
        Debug.Log(index + "번 인덱스 ");
    }
}

