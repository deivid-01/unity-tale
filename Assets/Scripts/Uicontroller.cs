using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Uicontroller : MonoBehaviour
{
    public GameObject textOld;
    public GameObject textNew;

    public GameObject fresaJoven;
    public GameObject cerraduraJoven;
    public GameObject cometitaJoven;
    public GameObject fresaAdulto;
    public GameObject cerraduraAdulto;
    public GameObject cometitaAdulto;

    public static Uicontroller Instance;

    public void Awake()
    {
        Instance = this;
    }

    public void EnableDisable()
    {
        Disable();
        Enabled();
    }

    void Disable() {
           fresaJoven.SetActive(false);
      cerraduraJoven.SetActive(false);
      cometitaJoven.SetActive(false);
        textOld.SetActive(false);
    }

    void Enabled() {
      fresaAdulto.SetActive(true);
      cerraduraAdulto.SetActive(true);
      cometitaAdulto.SetActive(true);
        textNew.SetActive(true);
    }

    public void DisableEnabled()
    {
        fresaJoven.SetActive(true);
        cerraduraJoven.SetActive(true);
        cometitaJoven.SetActive(true);
        textOld.SetActive(true);

        fresaAdulto.SetActive(false);
        cerraduraAdulto.SetActive(false);
        cometitaAdulto.SetActive(false);
        textNew.SetActive(false);
    }

}
