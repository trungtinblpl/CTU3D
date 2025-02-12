using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIControll : MonoBehaviour
{
    public Slider _musicSlider, _soundSlider;
    public void ToggleMusic()
    {
        SoundManager.Instance.ToggleMusic();
    }
    public void ToggleSound()
    {
        SoundManager.Instance.ToggleSound();
    }

    public void MusicVolume()
    {
        SoundManager.Instance.MusicVolume(_musicSlider.value);
    }
    public void SoundVolume()
    {
        SoundManager.Instance.SoundVolume(_soundSlider.value);
    }
}
