using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public Text questionText;

    void Start()
    {
        // Başlangıçta bir soru göstermek için
        ShowQuestion("Bu bir örnek sorudur?");
    }

    void ShowQuestion(string question)
    {
        questionText.text = question;
    }
}