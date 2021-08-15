using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankSoal : MonoBehaviour
{
    public Pertanyaan[] soalsoal;

    public Pertanyaan AmbilPertanyaan(int index){
        if(index > soalsoal.Length){
            return new Pertanyaan();
        }
        return soalsoal[index];
    }
}

[System.Serializable]
public struct Pertanyaan {
    // Text pertanyaan
    public string pertanyaan;

    // Opsi Jawaban, Maximum: 4
    public Opsi[] jawaban;
}

[System.Serializable]
public struct Opsi {
    public string jawaban;
    public bool apakahBenar;
}