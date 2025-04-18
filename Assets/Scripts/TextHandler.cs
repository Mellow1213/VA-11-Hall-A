using TMPro;
using UnityEngine;

public class TextHandler : MonoBehaviour
{
    public TMP_Text textObject;

    public void SetTextContent(string content)
    {
        textObject.text = content;
    }
}
