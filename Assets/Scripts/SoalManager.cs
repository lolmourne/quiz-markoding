using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoalManager : MonoBehaviour
{
    public BankSoal bankSoal;
    public GameObject opsiPertanyaanPrefab;
    public Text textPertanyaan;
    public GameObject opsiOpsiLayout;

    public OpsiUI[] opsiUI = new OpsiUI[4];

    public int currentQuestionId = 0;

    void Start()
    {
        for(int x = 0; x < 4; x ++){
            GameObject go = Instantiate(opsiPertanyaanPrefab, opsiOpsiLayout.transform);
            opsiUI[x] = go.GetComponent<OpsiUI>();
        }

        SpawnPertanyaan(currentQuestionId);
    }

    private void SpawnPertanyaan(int index)
    {
        Pertanyaan question = bankSoal.AmbilPertanyaan(index);
        textPertanyaan.text = question.pertanyaan;
        for(int x = 0; x < opsiUI.Length; x++){
            opsiUI[x].SetOpsi(question.jawaban[x].jawaban, question.jawaban[x].apakahBenar);
        }
    }

    public void PertanyaanSelanjutnya(){
        currentQuestionId++;
        SpawnPertanyaan(currentQuestionId);
    }

    public void UlanginPertanyaan(){
        SpawnPertanyaan(currentQuestionId);
    }
}

