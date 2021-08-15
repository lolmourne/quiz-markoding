using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpsiUI : MonoBehaviour
{
    public Text jawaban;
    public bool apakahBenar;
    public Sprite backgroundJawabanBenar;
    public Sprite backgroundJawabanSalah;

    public Sprite backgroundJawabanNetral;
    public Image backgroundImg;
    private SoalManager soalManager;

    void Start(){
        backgroundImg = GetComponent<Image>();
        soalManager = GameObject.Find("SoalManager").GetComponent<SoalManager>();
    }

    public void SetOpsi(string jawabanParam, bool apakahBenarParam){
        ResetOpsiKeKondisiNetral();
        jawaban.text = jawabanParam;
        apakahBenar = apakahBenarParam;
    }

    public void CekJawaban(){
        if(apakahBenar){
            backgroundImg.sprite = backgroundJawabanBenar;
        } else {
            backgroundImg.sprite = backgroundJawabanSalah;
        }
        AnnouncementManager.instance.AnnounceStatusJawaban(apakahBenar);
        //soalManager.PertanyaanSelanjutnya();
    }

    public void ResetOpsiKeKondisiNetral(){
        backgroundImg = GetComponent<Image>();
        backgroundImg.sprite = backgroundJawabanNetral;
    }
}
