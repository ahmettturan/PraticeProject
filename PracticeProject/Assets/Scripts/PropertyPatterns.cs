using UnityEditor;
using UnityEngine;
using UnityEngine.TextCore;

public class PropertyPatterns : MonoBehaviour
{
    string MulkTipi;
    string BlokTipi;
  //  int AidatCarpanKatsayısı = 2;
    int BenimKatsayim = 2;

    void Start()
    {
        int AidatHesapla(PropertyPatterns classimbenim, int AidatCarpanKatsayısı) 
            => classimbenim switch
        {
         {MulkTipi : "Daire", BlokTipi : "A"} => AidatCarpanKatsayısı * (int) 1.5,
         {MulkTipi : "Villa", BlokTipi: "B"} => AidatCarpanKatsayısı * (int) 2.5,
         {MulkTipi : "Rezidams", BlokTipi: "A"} => AidatCarpanKatsayısı * (int) 3.5,
            _ => 0
        };

        MulkTipi = "Daire";
        BlokTipi = "A";
        Debug.Log(AidatHesapla(this, BenimKatsayim));


    /*    MulkTipi = "Villa";

        if (MulkTipi == "Daire")
            Debug.Log(AidatCarpanKatsayısı * 1.5);

        else if (MulkTipi== "Villa")
            Debug.Log(AidatCarpanKatsayısı * 2.5);

        else if (MulkTipi== "Rezidans")
            Debug.Log(AidatCarpanKatsayısı * 3.5);

        else
            Debug.Log("Tanımsız");
            
        */ 
    /*    switch (MulkTipi)
        {
            case "Daire":
                Debug.Log(AidatCarpanKatsayısı * 1.5);
                break;
            case "Villa":
                Debug.Log(AidatCarpanKatsayısı * 2.5);
                break;
            case "Rezidans":
                Debug.Log(AidatCarpanKatsayısı * 3.5);
                break;

            default:
                Debug.Log("Tanımsız");
                break;
        } */
            

    }
}