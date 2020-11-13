using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLevel : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float rotSideSpeed;
    public float rotForwardSpeed;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(new Vector3(1, 0, 0) * verticalInput * rotForwardSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.down * horizontalInput * rotSideSpeed * Time.deltaTime, Space.World);
        //transform.RotateAround(player.transform.position, Vector3.up, rotSideSpeed * horizontalInput * Time.deltaTime);
        //transform.RotateAround(player.transform.position, Vector3.right, verticalInput * rotForwardSpeed * Time.deltaTime);
    }
}
