using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class button4ik : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private AudioClip _compressClip;
    [SerializeField] private AudioClip _uncompressClip;
    [SerializeField] private AudioSource _source;

    public void OnPointerDown(PointerEventData eventData)
    {
        _source.PlayOneShot(_compressClip);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _source.PlayOneShot(_uncompressClip);
    }
   
}
