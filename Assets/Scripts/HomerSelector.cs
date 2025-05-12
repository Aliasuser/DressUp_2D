using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomerSelector : MonoBehaviour
{
    public Dropdown homerDropdown;
    public Toggle shirtToggle, pantsToggle, shoesToggle;
    public GameObject dragPanel;
    public GameObject widthSlider;
    public GameObject heightSlider;

    void Start()
    {
        homerDropdown.onValueChanged.AddListener(OnDropdownChanged);
        dragPanel.SetActive(true);
        SetClothingToggles(true);
    }

    void OnDropdownChanged(int index)
    {
        string selected = homerDropdown.options[index].text;

        if (selected.Contains("Apakšbikses Homers"))
        {
            SetClothingToggles(true);
            dragPanel.SetActive(true);
            widthSlider.SetActive(true);
            heightSlider.SetActive(true);
        }
        else
        {
            SetClothingToggles(false);
            dragPanel.SetActive(false);
            widthSlider.SetActive(false);
            heightSlider.SetActive(false);
        }
    }

    void SetClothingToggles(bool active)
    {
        shirtToggle.interactable = active;
        pantsToggle.interactable = active;
        shoesToggle.interactable = active;
    }
}
