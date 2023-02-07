using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Auido : MonoBehaviour
{
    public AudioSource soundEffect;

    public void PlaySound()
    {
        soundEffect.Play();
    }
    public void StopSound()
    {
        soundEffect.Stop();
    }

    private void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(PlaySound);
    }
}




