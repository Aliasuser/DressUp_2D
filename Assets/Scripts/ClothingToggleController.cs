using UnityEngine;
using UnityEngine.UI;

public class ClothingToggleController : MonoBehaviour
{
    [Header("Toggles")]
    public Toggle shirtToggle;
    public Toggle pantsToggle;
    public Toggle shoesToggle;

    [Header("Groups (set these to your ShirtGroup, PantsGroup, ShoesGroup)")]
    public GameObject shirtsGroup;
    public GameObject pantsGroup;
    public GameObject shoesGroup;

    void Start()
    {
        
        shirtsGroup.SetActive(shirtToggle.isOn);
        pantsGroup.SetActive(pantsToggle.isOn);
        shoesGroup.SetActive(shoesToggle.isOn);

        
        shirtToggle.onValueChanged.AddListener(OnShirtToggleChanged);
        pantsToggle.onValueChanged.AddListener(OnPantsToggleChanged);
        shoesToggle.onValueChanged.AddListener(OnShoesToggleChanged);
    }

    private void OnShirtToggleChanged(bool isOn)
    {
        shirtsGroup.SetActive(isOn);
    }

    private void OnPantsToggleChanged(bool isOn)
    {
        pantsGroup.SetActive(isOn);
    }

    private void OnShoesToggleChanged(bool isOn)
    {
        shoesGroup.SetActive(isOn);
    }
}
