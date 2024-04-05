using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static string combinationString = "";
    public static gameManager Instance { get; private set; }
    public string productTag = "";

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }


    void Start()
    {

    }

    void Update()
    {
        // productTag is the new element created
        Debug.Log("GameManager: " + productTag);

            // ButtonActivation.activationParent();
    }
}
