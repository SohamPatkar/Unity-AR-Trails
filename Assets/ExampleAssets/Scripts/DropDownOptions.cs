using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownOptions : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Dropdown myDropdown;
    GameObject[] dropdownObjects = GameObject.FindGameObjectsWithTag("Targets");

    public void Start()
    {
        // For example
        PopulateDropdown(myDropdown, dropdownObjects);
    }
    void PopulateDropdown(Dropdown dropdown, GameObject[] optionsArray)
    {
        List<string> options = new List<string>();
        foreach (var option in optionsArray)
        {
            options.Add(option.name); // Or whatever you want for a label
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(options);
    }

}
