using UnityEngine;

public class TuplePatterns : MonoBehaviour
{
   
    
 void Start()
    {
      /*  string deger1 = "makas";
        string deger2 = "tas"; */

        #region
        /*
        if (deger1 == "tas" && deger2 == "kagit")
        {
            Debug.Log("Kağıt kazandı");

        }
        else if (deger1 == "tas" && deger2 == "makas")
        {
            Debug.Log("Taş kazandı");

        }
        else if (deger1 == "kagit" && deger2 == "tas")
        {
            Debug.Log("Kağıt kazandı");

        }
        else if (deger1 == "kagit" && deger2 == "makas")
        {
            Debug.Log("Makas kazandı");

        }
        else if (deger1 == "makas" && deger2 == "tas")
        {
            Debug.Log("Taş kazandı");

        }
        else if (deger1 == "makas" && deger2 == "kagit")
        {
            Debug.Log("Makas kazandı");

        }
        else
        {
            Debug.Log("Berabere");

        }
        */
        #endregion

        #region
        /*
        
                switch (deger1)
                {
                    case "tas":
                        if (deger2 == "kagit")
                            Debug.Log("Kağıt kazandı");
                        if (deger2 == "makas")
                            Debug.Log("Taş kazandı");
                        break;

                    case "kagit":
                        if (deger2 == "tas")
                            Debug.Log("Kağıt kazandı");
                        if (deger2 == "makas")
                            Debug.Log("Makas kazandı");
                        break;

                    case "makas":
                        if (deger2 == "tas")
                            Debug.Log("Taş kazandı");
                        if (deger2 == "kagit")
                            Debug.Log("Makas kazandı");
                        break;

                    default:
                        Debug.Log("Berabere");
                        break;
                }        
        */

        #endregion


        string taskagitmakas(string bir, string iki)
            => (bir, iki) switch
        {
            ("tas","kagit") => "Kağıt Kazandı",
            ("tas", "makas") => "Taş Kazandı",
            ("kagit", "tas") => "Kağıt Kazandı",
            ("kagit", "makas") => "Makas Kazandı",
            ("makas", "tas") => "Taş Kazandı",
            ("makas", "kagit") => "Makas Kazandı",
            ("tas", "tas") => "Berabere",
            ("makas", "makas") => "Berabere",
            ("kagit", "kagit") => "Berabere",
            (_,_) => "Değerler Boş"

        };

        Debug.Log(taskagitmakas("kagit", "makas"));

    }

    }