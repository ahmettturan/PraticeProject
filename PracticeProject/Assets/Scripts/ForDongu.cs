using UnityEngine;

public class ForDongu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int sayi = 0; sayi <= 5; sayi++)
        {
            if (sayi == 2) break;
            Debug.Log("Sayinin Değeri= " + sayi);
        }         
    }

}
