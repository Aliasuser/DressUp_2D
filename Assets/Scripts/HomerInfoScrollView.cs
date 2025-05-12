using UnityEngine;
using UnityEngine.UI;

public class HomerInfoScrollView : MonoBehaviour
{
    public Dropdown homerDropdown;   
    public Text infoText; 

    private string[] descriptions = new string[]
    {
   
        "Underwear Homer: The only version of Homer you can fully customize! Mix and match shirts, pants, and shoes to create your own unique look for Springfield’s most iconic dad.",

        
        "Classic Homer: This is the Homer everyone knows — white shirt, blue pants, and a big appetite for donuts. Always confused, always hilarious.",

  
        "Biker Homer: Leather jacket, shades, and an attitude. He’s not just riding a motorcycle — he’s riding into trouble (and probably crashing right after).",

        
        "Satan Homer: Straight from the underworld, this devilish version of Homer has horns, a tail, and a fiery sense of humor. May or may not be ruling over a donut-filled hell.",

       
        "Homeless Homer: Down on his luck and living rough, but still somehow managing to find food and sarcasm wherever he goes.",

        
        "Boxer Homer: In the ring and ready to fight — until he gets hit once and rethinks everything. His strategy? Get punched until the other guy gets tired.",

      
        "Clown Homer: Painted face, oversized shoes, and chaotic energy. Whether he’s at Krusty’s show or tripping over his own feet, it’s always a circus."
    };

    void Start()
    {
        homerDropdown.onValueChanged.AddListener(UpdateInfo);
        UpdateInfo(homerDropdown.value); 
    }

    void UpdateInfo(int index)
    {
        if (index >= 0 && index < descriptions.Length)
            infoText.text = descriptions[index];
        else
            infoText.text = "No description available for this Homer.";
    }
}
