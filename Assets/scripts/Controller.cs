using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody player;
    void Start()
    {

    }

    private void Update()
    {
        float speed = 2f * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + speed);
            MileageTracker.instance.AddMileage(speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - speed);
            MileageTracker.instance.AddMileage(speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position = new Vector3(player.transform.position.x - speed, player.transform.position.y, player.transform.position.z );
            MileageTracker.instance.AddMileage(speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position = new Vector3(player.transform.position.x + speed, player.transform.position.y, player.transform.position.z);
            MileageTracker.instance.AddMileage(speed);
        }
    }

}
