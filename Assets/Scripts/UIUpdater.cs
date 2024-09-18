using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TargetsText;
    [SerializeField] private Toggle FinishToggle;

    private void OnEnable()
    {
        Objectives.OnCurrentObjectivesChanged += UpdateTargetsText;
        Objectives.OnCurrentObjectivesChanged += UpdateFinishToggle;
    }

    private void OnDisable()
    {
        Objectives.OnCurrentObjectivesChanged -= UpdateTargetsText;
        Objectives.OnCurrentObjectivesChanged -= UpdateFinishToggle;
    }

    private void UpdateTargetsText()
    {
        TargetsText.text = $"Целей: {Objectives.Instance._targetsToDestroy}";
    }

    private void UpdateFinishToggle()
    {
        FinishToggle.isOn = Objectives.Instance._isFinishReached;
    }
}
