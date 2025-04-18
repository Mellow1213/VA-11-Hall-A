using System;
using UnityEngine;
using UnityEngine.UI;

public class RecipeSelector : MonoBehaviour
{
    public Script script;
    public GameObject panel;
    public GameObject detail;

    public void LoadRecipe(int index)
    {
        bool success = script.SelectRecipe(index);
        panel.SetActive(!success);
        detail.SetActive(success);
    }
    
    
}
