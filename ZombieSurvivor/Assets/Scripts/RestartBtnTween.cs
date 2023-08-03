using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class RestartBtnTween : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Tween shakeAni = default;

    // Start is called before the first frame update
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("���콺 �÷� �ξ���.");

        if (shakeAni == null || shakeAni == default)
        {
            shakeAni = transform.DOShakeScale(0.5f, 1, 10, 90, true, ShakeRandomnessMode.Harmonic).SetAutoKill();
            shakeAni.onKill += () => DisposeShake();
            return;
        }

        // Debug.Log("Shake Ani�� ��� ���� �ʴ�.");

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = Vector3.one;
    }

    //! Tween�� kill �� �� shakeAni ������ ����ִ� �Լ�
    private void DisposeShake()
    {
        transform.localScale = Vector3.one;
        shakeAni = default;
    }

}
