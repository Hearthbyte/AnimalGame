using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehaviour : MonoBehaviour
{
    [SerializeField] private float _animalSpeed;
    
    private float _xBound = 15.0f;
    private float _xPosition;
    
    private float _zBound = 20.0f;
    private float _zPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (_animalSpeed * Time.deltaTime));
        
        _xPosition = transform.position.x;
        _zPosition = transform.position.z;
        
        if(_zPosition >= -_zBound) return;
        
        Destroy(gameObject);
    }
}
