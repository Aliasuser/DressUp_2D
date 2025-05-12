using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTextScript : MonoBehaviour
{
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
        if (text.Length < 4 || text.Length > 10)
        {
            textField.GetComponent<Text>().text = "Vārda garumam jābūt no 4 līdz 10 simboliem!";
            return;
        }

        textYear = BirthInput.GetComponent<Text>().text;
        int birthYear;
        if (!Int32.TryParse(textYear, out birthYear))
        {
            textField.GetComponent<Text>().text = "Lūdzu ievadi derīgu dzimšanas gadu!";
            return;
        }

        year = currentYear - birthYear;
        if (birthYear > 2024 || birthYear < 1900)
        {
            textField.GetComponent<Text>().text = "Dzimšanas gadam jābūt starp 1900 un 2024!";
            return;
        }

        textField.GetComponent<Text>().text = "Sveiks " + text + ", tev ir " + year + " gadi!";
    }

    

}
