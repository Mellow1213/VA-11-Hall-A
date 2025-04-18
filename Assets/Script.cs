using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    public List<RecipeData> recipeData;
    public GameObject contentArea;
    public GameObject detailArea;
    public GameObject textPrefab;
    public GameObject imagePrefab;
    [FormerlySerializedAs("button")] public Button textButton;
    public Button imageButton;
    public GameObject selector;

    void Awake()
    {
        Debug.Log("테스트");
        textButton.onClick.AddListener(() => Test(textPrefab));
        imageButton.onClick.AddListener(() => Test(imagePrefab));
    }

    public void Test2()
    {
        selector.gameObject.SetActive(true);
        detailArea.gameObject.SetActive(false);
        foreach (var child in contentArea.GetComponentsInChildren<GameObject>())
        {
            Destroy(child);
        }
    }

    public bool SelectRecipe(int index)
    {
        if (index >= recipeData.Count) return false;
        LoadUI(recipeData[0]);
        return true;
    }

    void Test(GameObject prefab)
    {
        Instantiate(prefab, contentArea.transform);
    }

    void LoadUI(RecipeData data)
    {
        foreach (var p in data.recipeList)
        {
            GameObject prefabs = Instantiate(textPrefab, contentArea.transform);
            TextHandler preText = prefabs.GetComponent<TextHandler>();
            preText.SetTextContent(p.content);
        }
    }
}
