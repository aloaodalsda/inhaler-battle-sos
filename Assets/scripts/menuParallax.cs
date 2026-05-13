using UnityEngine;
using UnityEngine.InputSystem;

public class menuParallax : MonoBehaviour
{
    public float offnikmult = 1f;
    public float time = .3f;
    private Vector2 startpos;
    private Vector3 velociped;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offnik = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        transform.position = Vector3.SmoothDamp(transform.position, startpos + (offnik * offnikmult), ref velociped, time);
    }
}
