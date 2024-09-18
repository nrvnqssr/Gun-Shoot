using UnityEngine;

public class NoiseMaker : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _minSpeed;

    [SerializeField] private float _playDelay;
    private float _lastTimePlayed;

    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip[] _sounds;

    private void Start()
    {
        _lastTimePlayed = -_playDelay;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (_rb.velocity.magnitude < _minSpeed)
            return;

        if (Time.time < _lastTimePlayed + _playDelay)
            return;

        _lastTimePlayed = Time.time;

        _audioSource.clip = _sounds[Random.Range(0, _sounds.Length)];
        _audioSource.Play();
    }
}