using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DiallogueController : MonoBehaviour
{
    public static DiallogueController Instance { get ; private set;}

    public GameObject dialoguePanel;
    public TMP_Text dialogueText, nameText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void ShowDialogueUI(bool show)
    {
        dialoguePanel.SetActive(show);
    }

    public void SetNPCInfo(string npcName)
    {
        nameText.text = npcName;
    }

    public void SetDialogueText(string text)
    {
        dialogueText.text = text;
    }
}
