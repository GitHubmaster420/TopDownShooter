using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpDown : MonoBehaviour
{
    public float verticalInput;
    public float rotForwardSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(new Vector3(1, 0, 0) * verticalInput * rotForwardSpeed * Time.deltaTime);

    }
}
