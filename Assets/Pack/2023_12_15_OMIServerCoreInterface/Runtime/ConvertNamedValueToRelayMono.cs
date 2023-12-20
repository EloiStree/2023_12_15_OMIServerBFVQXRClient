using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertNamedValueToRelayMono : MonoBehaviour
{


    public NamedBooleanValueEvent m_onBoolRelay;
    public NamedFloatValueEvent m_onFloatRelay;
    public NamedVector3ValueEvent m_onVector3Relay;
    public NamedQuaternionValueEvent m_onQuaternionRelay;

    public void Push(string name, bool value) => m_onBoolRelay.Invoke(new NamedBooleanValue(name, value));
    public void Push(string name, float value) => m_onFloatRelay.Invoke(new NamedFloatValue(name, value));
    public void Push(string name, Vector2 value) => m_onVector3Relay.Invoke(new NamedVector3Value(name, value));
    public void Push(string name, Vector3 value) => m_onVector3Relay.Invoke(new NamedVector3Value(name, value));
    public void Push(string name, Quaternion value) => m_onQuaternionRelay.Invoke(new NamedQuaternionValue(name, value));
}
