using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundAdjuster : MonoBehaviour
{
    [SerializeField] private float _maxSoundVolume;
    [SerializeField] private float _minSoundVolume;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float _soundChangeRate;

    private float _targetSoundVolume;
    private void Start()
    {
        _targetSoundVolume = _minSoundVolume;
        
    }

    public void StartVolumeIncreasing()
    {
        var increaserInJob = StartCoroutine(IncreaseVolumeToMax());
    }

    public void StartVolumeDecreasing()
    {
        var decreaserInJob = StartCoroutine(DecreaseVolumeToMin());
    }

    private IEnumerator IncreaseVolumeToMax()
    {
        _audioSource.Play();
        for (float i = _audioSource.volume; i < _maxSoundVolume; i += _soundChangeRate)
        {
            _audioSource.volume = i;
            yield return new WaitForFixedUpdate();
        }
    }  

    private IEnumerator DecreaseVolumeToMin()
    {
        for (float i = _audioSource.volume; i > _minSoundVolume; i -= _soundChangeRate)
        {
            _audioSource.volume = i;
            yield return new WaitForFixedUpdate();
        }
        _audioSource.Stop();
    }
}
