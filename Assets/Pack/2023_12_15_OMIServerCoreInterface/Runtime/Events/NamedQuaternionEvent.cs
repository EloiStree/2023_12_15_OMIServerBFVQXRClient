using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class NamedQuaternionEvent : UnityEvent<string, Quaternion> { }