using EnumClasses;
using UnityEngine;

[CreateAssetMenu(fileName = "RecipeBlock", menuName = "Scriptable Objects/RecipeBlock")]
public class RecipeBlock : ScriptableObject
{
    public UIBlockType type;
    public string content; // text or route
}
