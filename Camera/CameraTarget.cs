using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] Transform player;
    [SerializeField] float threshhold;
    void Update()
    {
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 targetPos = (player.position + mousePos) / 2f;

        targetPos.x = Mathf.Clamp(targetPos.x, -threshhold + player.position.x, threshhold + player.position.x);
        targetPos.y = Mathf.Clamp(targetPos.y, -threshhold + player.position.y, threshhold + player.position.y);

        this.transform.position = targetPos;
    }
}
