using System;
using UnityEngine;
using Object = UnityEngine.Object;

public class Objectives : MonoBehaviour
{
    #region Singleton
    public static Objectives Instance;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

    [field: SerializeField] public int _targetsToDestroy { get; private set; }
    [field: SerializeField] public bool _isFinishReached { get; private set; }
    [field: SerializeField] public bool _objectivesReached { get; private set; }
    
    [SerializeField] private AudioSource _audioSource;

    public static Action OnObjectivesComplete;
    public static Action OnCurrentObjectivesChanged;

    private void Start()
    {
        _targetsToDestroy = 0;
        _isFinishReached = false;
        _objectivesReached = false;

        //Создает массив объектов, в которые, с помощью поиска, помещаются все игровые объекты с компонентом "Target".
        Object[] targets = FindObjectsByType(typeof(Target), FindObjectsSortMode.None);
        
        //Количество целей - количество объектов с компонентом "Target".
        _targetsToDestroy = targets.Length;

        OnCurrentObjectivesChanged.Invoke();
    }

    private void OnEnable()
    {
        OnCurrentObjectivesChanged += CheckObjectives;
    }

    private void OnDisable()
    {
        OnCurrentObjectivesChanged -= CheckObjectives;
    }

    public void UpdateTargetsCount()
    {
        _targetsToDestroy--;
        OnCurrentObjectivesChanged?.Invoke();
    }

    public void FinishIsReachedSwitch()
    {
        _isFinishReached = !_isFinishReached;
        OnCurrentObjectivesChanged?.Invoke();
    }

    public void CheckObjectives()
    {
        if (_objectivesReached)
            return;

        if (_targetsToDestroy == 0 && _isFinishReached)
        {
            _audioSource.Play();
            OnObjectivesComplete?.Invoke();
            _objectivesReached = true;
        }
    }
}
