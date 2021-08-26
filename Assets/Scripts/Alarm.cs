using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    [SerializeField] private SoundAdjuster _soundAdjuster;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent<Robber>(out Robber robber))
        {
            _soundAdjuster.StartVolumeIncreasing();
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.TryGetComponent<Robber>(out Robber robber))
        {
            _soundAdjuster.StartVolumeDecreasing();
        }
    }
}
