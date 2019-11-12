using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterViewManager : PopviewManager
{
    [SerializeField] Text titleText;

    public string Title
    {
        get
        {
            return this.titleText.text;
        }
        set
        {
            this.titleText.text = value;
        }
    }

    public void OnCllickBack()
    {
        Close();
    }
}
