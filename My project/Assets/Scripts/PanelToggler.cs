using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelToggler : MonoBehaviour
{
    bool isOn = false;
    [SerializeField] GameObject informationPanel;

    public void TogglePanel()
    {
        if (isOn)
        {
            isOn = false;

            informationPanel.SetActive(false);
        }
        else
        {
            informationPanel.SetActive(true);
            isOn = true;
        }
    }
}
