using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 cameraPos = new Vector3(0, 5, -8);
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + cameraPos ;
    }
}
