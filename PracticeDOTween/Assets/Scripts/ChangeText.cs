using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _base;
    [SerializeField] private string _substitute;
    [SerializeField] private string _additionalText;
    [SerializeField] private string _substituteScramble;
    [SerializeField] private ScrambleMode _scrambleMode;
    [SerializeField] private float _duration;

    private WaitForSeconds _delay;

    private void Awake()
    {
        _delay = new WaitForSeconds(_duration);
    }

    private void Start()
    {
        StartCoroutine(Modify());
    }    

    private IEnumerator Modify()
    {
        while (enabled)
        {          
            _base.DOText(_substitute, _duration);

            yield return _delay;

            _base.DOText("\n" + _additionalText, _duration).SetRelative();

            yield return _delay;

            _base.DOText("\n" + _substituteScramble, _duration, true, _scrambleMode);

            yield return _delay;
        }
    }
}
