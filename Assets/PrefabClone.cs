using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabClone : MonoBehaviour
{
    public GameObject prefab;
    public Text inputCloneAmount;
    public Text displayClonesLeft;
    public InputField IField;
    public int counter;
    
    
    void Start()
    {
        counter = 0;
        displayClonesLeft.text = "?";
    }


    void Update()
    {
        
    }


    public void ClonePrefab()
    {
        if(inputCloneAmount.text != "")
        {
            if (counter < int.Parse(inputCloneAmount.text))
        {
            Instantiate(prefab);
            counter++;
            displayClonesLeft.text = (int.Parse(inputCloneAmount.text) - counter).ToString();
        }
            else
            {
                displayClonesLeft.text = "No hay más";
            }

        }
        else
        {
            displayClonesLeft.text = "ERROR FATAL. Ingrese un valor";
        }
        
        
    }
}
