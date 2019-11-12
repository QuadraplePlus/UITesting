using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public interface ISkillButton
{
    void DidSelctSkill(SkillButton skillButton);
}
public class SkillButton : MonoBehaviour
{
    public ISkillButton skillButtonDelegate;

    Button button;
    public Button CachedButton
    {
        get
        {
            if (CachedButton == null)
            {
                button = GetComponent<Button>();
            }
            return button;
        }
    }
    public void SetOnClickAction(UnityAction action)
    {
        GetComponent<Button>().onClick.AddListener(action);
    }
    public void SetInterlectable(bool value)
    {
        this.CachedButton.interactable = value;
    }
    public void OnCilck()
    {
        skillButtonDelegate.DidSelctSkill(this);
    }
}
