using UnityEngine;

public class ZeusController : MonoBehaviour
{
    private Animator _anim;
    [SerializeField] private GameObject _tapok;
    public int tapokCount;

    [SerializeField] private float throwCooldown = 1f; // Время задержки между бросками
    private bool canThrow = true;

    private void Start()
    {
        AudioManager.Instance.PlayZeus("Run");
        _anim = GetComponent<Animator>();
        _anim.SetBool("Run", true);
    }

    public void ThrowTapok()
    {
        if (!canThrow) return;

        canThrow = false;
        tapokCount++;
        _anim.SetTrigger("Throw");
        AudioManager.Instance.PlayZeus("HYA");
        Invoke("TapokFly", 1f);
        Invoke("ResetThrow", throwCooldown);
    }

    private void TapokFly()
    {
        _tapok.SetActive(true);
    }

    private void ResetThrow()
    {
        canThrow = true;
    }
}
