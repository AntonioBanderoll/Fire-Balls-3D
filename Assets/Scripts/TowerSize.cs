using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TowerSize : MonoBehaviour
{
    [SerializeField] private TMP_Text _sizeView;
    [SerializeField] private Tower _tower;

    private void OnEnable()
    {
        _tower.SizeUpdate += OnSizeUpdate;
    }

    private void OnDisable()
    {
        _tower.SizeUpdate -= OnSizeUpdate;
    }

    private void OnSizeUpdate(int size)
    {
        _sizeView.text = size.ToString();
    } 
}
