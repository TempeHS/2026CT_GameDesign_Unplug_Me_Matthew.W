using UnityEngine;

public class Chest : MonoBehaviour, IIinteractable
{
    public bool IsOpened {get; private set;}
    public string ChestID {get; private set;}
    public GameObject itemPrefab;

    void Start()
    {
        ChestID ??=GlobalHelper.GenerateUniqueID(gameObject);
    }

    
    public bool CanInteract()
    {
        return !IsOpened;

    }

    public void Interact()
    {
        if (!CanInteract()) return;

    }

    public void OpenChest ()
    {
        SetOpened(true);

        if (itemPrefab)
        {
            
        }
    }

    public void SetOpened(bool opened)
    {
        if (IsOpened = opened)
        {
            
        }
    }
}
