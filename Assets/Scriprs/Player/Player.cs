using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    Transform _red;
    [SerializeField]
    Transform _blue;
    CircleMove tween;
    private void Awake()
    {
        tween = gameObject.AddComponent<CircleMove>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tween.Match();
        }
    }
}
