using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject _explosionPrefab;
    private Rigidbody _rb;
    private bool _hitsTarget;

    private void Awake() => _rb = GetComponent<Rigidbody>();

    public void Init(Vector3 vel)
    {
        _rb.velocity = vel;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(_explosionPrefab, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
