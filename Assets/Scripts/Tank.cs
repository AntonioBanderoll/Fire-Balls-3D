using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tank : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _bullerTempler;
    [SerializeField] private float _delayBetweenShoots;
    [SerializeField] private float _recoilDistance;

    private float _timaAfterShoot;

    private void Update()
    {
        _timaAfterShoot += Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            if (_timaAfterShoot > _delayBetweenShoots)
            {
                Shoot();
                transform.DOMoveZ(transform.position.z - _recoilDistance, _delayBetweenShoots / 2).SetLoops(2, LoopType.Yoyo);
                _timaAfterShoot = 0;
            }
        }
    }
    private void Shoot()
    {
        Instantiate(_bullerTempler, _shootPoint.position, Quaternion.identity);
    }

}
