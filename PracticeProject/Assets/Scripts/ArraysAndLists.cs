using UnityEngine;

public class ArraysAndLists : MonoBehaviour
{
    void Start()
    {
       /* int[] sayilarim = new int[5];
        string[] yazilarim = new string[2]; */

        /* int[] sayilarim = new int[] {1,2,3,4,5,6,9};

        Debug.Log(sayilarim[2]); */

        string[][] arabalar = new string[3][];

        arabalar[0] = new string[] {"Bmw","Audi","Seat"};
        arabalar[1] = new string[] {"2010" ,"2009" ,"2014"};
        arabalar[2] = new string[] {"140hp","100hp","90hp"};

        Debug.Log(arabalar[0][1]);
        Debug.Log(arabalar[1][0]);

        
    }
}
