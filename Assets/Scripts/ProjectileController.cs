using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] private float _foodSpeed;

    private float _zBound = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.forward * (_foodSpeed * Time.deltaTime));

        if(transform.position.z <= _zBound) return;
        
        Destroy(gameObject);
    }
    
    

    
}
