using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance = null;

    public string NationName    { get; private set; }
    public float GDP            { get; private set; }
    public float TaxRate        { get; private set; }
    public float Expenses       { get; private set; }
    public float Income         { get { return GDP * TaxRate; } }
    public float Revenue        { get { return Income - Expenses; } }

    void Awake()
    {
        if (instance == null)       { instance = this; }
        else if (instance != this)  { Destroy(gameObject); }
        DontDestroyOnLoad(gameObject);

        InitializeData();
    }

    /* Temporary Test function */
    /* TODO: Remove this function */
    private void InitializeData()
    {
        NationName = "Principality of Principle";
        GDP = 2000000f;
        TaxRate = 50f;
        Expenses = 500000f;
    }

}
