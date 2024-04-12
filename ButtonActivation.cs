using UnityEngine;
using UnityEngine.UI;

// Access modifier
public class ButtonActivation : MonoBehaviour
{
    public GameObject contentObject;
    public string recievedString;

    void Start()
    {
        Debug.Log("ButtonActivation Start():" + gameManager.Instance.productTag);
    }

    void Update()
    {
        recievedString = gameManager.Instance.productTag;
    }

    // public static void activationParent ()
    // {
    //     ActivateButton(contentObject.transform, gameManager.Instance.productTag);
    // }


    public bool ActivateButton(Transform parent, string buttonTag)
    {
        foreach (Transform child in parent)
        {
            Debug.Log("buttonTag from ActivateButton(): " + buttonTag);
            Debug.Log("gameManager.Instance.productTag from ActivateButton(): " + gameManager.Instance.productTag);
            if (buttonTag.Equals(gameManager.Instance.productTag))
            {
                Debug.Log("child.gameobject from ActivateButton(): " + child.gameObject.tag);
                child.gameObject.SetActive(true);
                break;
            }
        }
        return false;
    }
}