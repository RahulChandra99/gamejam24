using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{

    [SerializeField] private GameObject _geometry;
    [SerializeField] private Ease _ease = Ease.InExpo;

    //Animating Node Start

    private void Start()
    {
        ShowNode();
    }

    void ShowNode()
    {
        StartCoroutine(NodeAnimRoutine());
    }
    IEnumerator NodeAnimRoutine()
    {
        if(_geometry != null)
        {
            _geometry.transform.DOScale(Vector3.zero, 0f);

            yield return new WaitForSeconds(1);

            _geometry.transform.DOScale(Vector3.one, 1f).SetEase(_ease);
        }
        
    }
}
