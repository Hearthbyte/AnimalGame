using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _playerSpeed;
    
    private float _horizontalInput;

    private float _xBound = 15.0f;
    
    [SerializeField] private GameObject _foodPrefab;
    
    //private string _inputAxisName = "Horizontal";

    //[SerializeField] private Rigidbody playerRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * (_horizontalInput * _playerSpeed * Time.deltaTime));
        var playerPosition = transform.position;
        playerPosition.x = (playerPosition.x > _xBound ? _xBound 
            : playerPosition.x < -_xBound ? -_xBound : playerPosition.x);

        transform.position = playerPosition;

        SpawnProjectile(Input.GetKeyDown(KeyCode.Space));
    }
    
    private void SpawnProjectile(bool isKeyPressed)
    {
        if (!isKeyPressed) return;
        Instantiate(_foodPrefab, transform.position, Quaternion.identity);
    }
}
