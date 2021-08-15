using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnnouncementManager : MonoBehaviour
{
    public Text respondJawaban;
    public Text nextAction;
    private bool apakahBenar;
    private SoalManager soalManager;

    public static AnnouncementManager instance;

    private void Awake(){
        if(instance == null){
            instance = this;
        } else{
            Destroy(this);
        }
    }

    void Start(){
        soalManager = GameObject.Find("SoalManager").GetComponent<SoalManager>();
        gameObject.SetActive(false);
    }

    public void AnnounceStatusJawaban(bool apakahBenar){
        gameObject.SetActive(true);
        this.apakahBenar = apakahBenar;
        if(apakahBenar){
            respondJawaban.text = "BENAR! SELAMAT YA!";
            nextAction.text = "NEXT";
        } else{
            respondJawaban.text = "Salah! Tambah wawasan ya!";
            nextAction.text = "RETRY";
        }
    }

    public void NextAction(){
        if(apakahBenar){
            soalManager.PertanyaanSelanjutnya();
        } else{
            soalManager.UlanginPertanyaan();
        }
        gameObject.SetActive(false);
    }
}
