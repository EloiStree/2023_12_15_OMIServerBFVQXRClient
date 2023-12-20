using UnityEngine.Events;

[System.Serializable]
public class NamedBooleanValue : A_GetSetNamedValue<bool>
{
    public NamedBooleanValue()
    {
    }
    public NamedBooleanValue(string name, bool value)
    {
        SetNameAndValue(name, value);
    }
}



[System.Serializable]
public class NamedBooleanValueEvent : UnityEvent<NamedBooleanValue> { }
[System.Serializable]
public class NamedFloatValueEvent : UnityEvent<NamedFloatValue> { }
[System.Serializable]
public class NamedVector3ValueEvent : UnityEvent<NamedVector3Value> { }
[System.Serializable]
public class NamedQuaternionValueEvent : UnityEvent<NamedQuaternionValue> { }

