using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioStop : MonoBehaviour
{
    public AudioSource soundEffect;

    
    public void StopSound()
    {
        soundEffect.Stop();
    }

    private void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(StopSound);
    }
}
