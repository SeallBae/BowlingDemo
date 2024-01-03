using UnityEngine;
using UnityEngine.UIElements;

public class platform : MonoBehaviour
{
    private static float length = 10.0f;
    private static float width = 3.0f;
    private static float height = .15f;
    private static float x_position = 0f;
    private static float y_position = -0.275f;
    private static float z_position = 3f;

    void Start() {
        transform.localScale = new Vector3(width, height, length);
        transform.position = new Vector3(x_position, y_position, z_position);
    }
    void Update() 
    {
        if (score.trialno <=3 && !movement.launched && (monitor.fallcount == 10))
        {
            Debug.Log("platform: " + score.level/2);
            transform.localScale = new Vector3(width, height, length + (score.level/2));
            transform.position = new Vector3(x_position, y_position, z_position - (score.level/2));

        }
    }
}