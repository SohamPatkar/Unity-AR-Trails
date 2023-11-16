using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ObjectManager : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject[] gameObjects;
    private Navmeshes _mesh;

    private void Awake()
    {
        _mesh = GameObject.Find("Indicator").GetComponent<Navmeshes>();
    }
    // Start is called before the first frame update
    void Start()
    {
        PopulateDropdown();
    }

    private void Update()
    {
        ActivateSelectedObject();
    }

    private void ActivateSelectedObject()
    {
        int selectedIndex = dropdown.value;
        
        for (int i = 0; i < gameObjects.Length; i++)
        {
            if (i == selectedIndex)
            {
                gameObjects[i].SetActive(true);
                _mesh.target = gameObjects[i].transform ;
            }
            else
            {
                gameObjects[i].SetActive(false);
            }
        }
    }

    private void PopulateDropdown()
    {
        dropdown.ClearOptions();
        List<Dropdown.OptionData> options = new List<Dropdown.OptionData>();
        
        //To add Gameobjects in the options list 
        foreach ( GameObject obj in gameObjects)
        {
            Dropdown.OptionData option = new Dropdown.OptionData(obj.name);
            options.Add(option);
        }
        
        //To add Gameobjects in the Dropdown
        dropdown.AddOptions(options);
    }   
}
