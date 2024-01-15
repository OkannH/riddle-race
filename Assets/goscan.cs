using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goscan : MonoBehaviour
{
    void Awake()
    {
        // Soru nesnesini başlangıçta pasif hale getir
        Transform soruNesnesi = transform.GetChild(0);
        soruNesnesi.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("gascan")) // "gascan" tag'ine sahip nesneyle çarpışıldığını kontrol et
        {
            // Oyunu durdur
            Time.timeScale = 0f;

            // Soruyu görüntüle
            Soru();
        }
    }

    private void Soru()
    {
        // Soru nesnesini aktif hale getir (bu nesne, içinde soru metni olan bir alt nesne içermelidir)
        Transform soruNesnesi = transform.GetChild(0);
        soruNesnesi.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
