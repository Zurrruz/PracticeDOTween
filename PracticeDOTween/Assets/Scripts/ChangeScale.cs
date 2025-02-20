using DG.Tweening;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    [SerializeField] private float _magnitude;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOScale(_magnitude, _duration).SetLoops(_repeats, _loopType).SetEase(Ease.Linear);
    }
}
