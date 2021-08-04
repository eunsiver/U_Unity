using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
  // Start is called before the first frame update
  public AudioMixer mixer;
  public Slider slider;
  // void Start()
  // {
  //   slider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
  // }

  // // Update is called once per frame
  // public void SetLevel(float sliderValue)
  // {
  //   mixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);
  //   PlayerPrefs.SetFloat("MusicVolume", sliderValue);
  // }
  public void AudioControl()
  {
    float sound = slider.value;
    if (sound == -40f) mixer.SetFloat("Music", -80);
    else mixer.SetFloat("Music", sound);
  }
  public void ToggleAudioVolume()
  {
    AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
  }
}
