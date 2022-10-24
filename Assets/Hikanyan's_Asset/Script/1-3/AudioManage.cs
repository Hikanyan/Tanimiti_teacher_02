using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManage : MonoBehaviour
{
    public static AudioManage instance;
    AudioSource _adioSource;
    [SerializeField]float _volume;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            _adioSource = GetComponent<AudioSource>();
            _adioSource.volume = _volume;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void VolumeChange()
    {
        _adioSource.volume = _volume;
    }
    public void AudioPlay(AudioClip sound)
    {
        _adioSource.PlayOneShot(sound);
    }
}
