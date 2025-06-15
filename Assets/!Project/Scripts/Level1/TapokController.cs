using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class TapokController : MonoBehaviour
{
    private Animator _anim;
    [SerializeField] private ZeusController _throwCounter;
    public static event Action Finished;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        int randInt = 0;
        if (_throwCounter.tapokCount <= 4)
        {
            randInt = Random.Range(0, 2);
            _anim.SetInteger("Miss", randInt);
            Debug.Log(randInt);
            return;
        }
        _anim.SetInteger("Count", _throwCounter.tapokCount);
        Debug.Log("Win!");
        Invoke("Death", 1.5f);
        Invoke("TheEnd", 5.6f);
    }

    private void Death()
    {
        AudioManager.Instance.PlaySFX("death");
    }
    private void TheEnd()
    {
        Finished?.Invoke();
    }
}
