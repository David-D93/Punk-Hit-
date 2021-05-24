using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour {

    private int skinIndex;
    public GameObject[] skins;

    void Start() {
        skins[0].SetActive(true);
    }

    void Update() {
        if (Input.GetButtonDown("NextSkin")) {
            skins[skinIndex].SetActive(false);
            skinIndex++;
            if (skinIndex >= skins.Length) {
                skinIndex = 0;
            }
            skins[skinIndex].SetActive(true);
        } else if (Input.GetButtonDown("PreviousSkin")) {
            skins[skinIndex].SetActive(false);
            skinIndex--;
            if (skinIndex < 0) {
                skinIndex = skins.Length - 1;
            }
            skins[skinIndex].SetActive(true);
        }
    }
}
