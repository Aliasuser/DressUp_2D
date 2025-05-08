using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTextScript : MonoBehaviour
{
    private int number = 0;
    string text;
    int randText;
    public GameObject NameInput;
    public GameObject BirthInput;
    public GameObject textField;
    int currentYear = 2025;
    string textYear;
    int year;
    public void ShowText()
    {
        text = NameInput.GetComponent<Text>().text;
        textYear = BirthInput.GetComponent<Text>().text;
        year = currentYear - (Int32.Parse(textYear));
        textField.GetComponent<Text>().text = "Sveiks " + text + ", tev ir " + year + " gadi!";
    }
}
