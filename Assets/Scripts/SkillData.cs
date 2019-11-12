using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct SkillData
{
    public string SkillName;
    public string SkillInfoText;
    public int SkillNeddLevel;
    public int SkillLevel;
    public int SkillDamage;
    public int SkillNeedMana;
    public int index;
    public Sprite sprite;
}

public struct SkillInfoes
{
    List<SkillData> skillDataList;

    public SkillInfoes(List<SkillData> skillDatas)
    {
        this.skillDataList = skillDatas;
    }
}

