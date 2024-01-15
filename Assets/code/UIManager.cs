using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void DisplayQuestion()
    {
        // Soru ekranını göstermek için gerekli kodları buraya ekleyin.
    }
}