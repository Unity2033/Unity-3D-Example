using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Bee : MonoBehaviour
{
    private Vector3 direction;

    [SerializeField] float speed = 3.0f;

    private IObjectPool<Bee> managedPool;

    public void SetManaged(IObjectPool<Bee> pool)
    {
        managedPool = pool;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible()
    {
        managedPool.Release(this);
    }
}
