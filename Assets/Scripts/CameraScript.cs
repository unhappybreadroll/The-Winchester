
using UnityEngine;

public class CameraScript : MonoBehaviour
{


    private Transform PlayerTransform;


   
    void Start()
    {
        PlayerTransform = GameObject.FindGameObjectWithTag("Player").transform; 
    }

   
    void lateUpdate()
    {
        // storing current cameras position in variable temp
        Vector2 temp = transform.position;
        // set the cameras position x to be equal to the position x
        temp.x = PlayerTransform.position.x;
        // set back the cameras temp position to the cameras current position
        transform.position = temp;

        // reason to do it this way is because you can edit the players temporary position
    }






   







}
