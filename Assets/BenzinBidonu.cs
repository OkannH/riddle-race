using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenzinBidonu : MonoBehaviour
{
    // Bu bidonun ne kadar benzin içerdiğini belirleyen değişken
    public float benzinMiktari = 20f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Arac"))
        {
            // Soru sormak için bir fonksiyonu çağır
            SoruSor();
        }
    }

    void SoruSor()
    {
        // Burada soru sorma işlemlerini gerçekleştirin
        // Örneğin, bir UI paneli açabilir ve soruyu kullanıcıya sormak için bir metot kullanabilirsiniz.
        // Kullanıcının cevabını kontrol etmek için bir başka fonksiyonu çağırabilirsiniz.
    }
}

