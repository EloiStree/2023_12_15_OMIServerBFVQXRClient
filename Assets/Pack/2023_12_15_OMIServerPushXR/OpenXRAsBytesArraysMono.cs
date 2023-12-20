using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenXRAsBytesArraysMono : MonoBehaviour, I_GetPrimitiveArrayToPush
{
    public char m_uniqueIdToPush ='£';
    public string[] m_namedFloat = new string[] { "XRJLH", "XRJLV", "XRJRH", "XRJRV", "XRTL", "XRTR", "XRGL", "XRGR", };
    [Range(-1, 1)]
    public float m_joystickLeftHorizontal;
    [Range(-1, 1)]
    public float m_joystickLeftVertical;
    [Range(-1, 1)]
    public float m_joystickrightHorizontal;
    [Range(-1, 1)]
    public float m_joystickrightVertical;
    [Range(0, 1)]
    public float m_leftTrigger;
    [Range(0, 1)]
    public float m_rightTrigger;
    [Range(0, 1)]
    public float m_leftGrip;
    [Range(0,1)]
    public float m_rightGrip;
    public float[] F { get {
            return new float[] {
            m_joystickLeftHorizontal,
            m_joystickLeftVertical,
            m_joystickrightHorizontal,
            m_joystickrightVertical,
            m_leftTrigger,
            m_rightTrigger,
            m_leftGrip,
            m_rightGrip
        };
    } }


    public string[] m_namedBooleans = new string[] {
    "XRleftJoystickButton",
    "XRrightJoystickButton",
    "XRleftPrimaryButton",
    "XRrightPrimaryButton",
    "XRleftSecondaryButton",
    "XRrightSecondaryButton",
    "XRleftMenuButton",
    "XRrightMenuButton",
    "XRleftTriggerTouch",
    "XRrightTriggerTouch",
    "XRleftSideThumbTouch",
    "XRrightSideThumbTouch",
    "XRleftJoystickTouch",
    "XRrightJoystickTouch",
    "XRleftPrimaryTouch",
    "XRrightPrimaryTouch",
    "XRleftSecondaryTouch",
    "XRrightSecondaryTouch"
    };
    public bool m_leftJoystickButton;
    public bool m_rightJoystickButton;
    public bool m_leftPrimaryButton;
    public bool m_rightPrimaryButton;
    public bool m_leftSecondaryButton;
    public bool m_rightSecondaryButton;
    public bool m_leftMenuButton;
    public bool m_rightMenuButton;

    public bool m_leftTriggerTouch;
    public bool m_rightTriggerTouch;
    public bool m_leftSideThumbTouch;
    public bool m_rightSideThumbTouch;

    public bool m_leftJoystickTouch;
    public bool m_rightJoystickTouch;
    public bool m_leftPrimaryTouch;
    public bool m_rightPrimaryTouch;
    public bool m_leftSecondaryTouch;
    public bool m_rightSecondaryTouch;
    public bool[] B
    {
        get
        {
            return new bool[] {
             m_leftJoystickButton,
             m_rightJoystickButton,
             m_leftPrimaryButton,
             m_rightPrimaryButton,
             m_leftSecondaryButton,
             m_rightSecondaryButton,
             m_leftMenuButton,
             m_rightMenuButton,
             
             m_leftTriggerTouch,
             m_rightTriggerTouch,
             m_leftSideThumbTouch,
             m_rightSideThumbTouch,
             
             m_leftJoystickTouch,
             m_rightJoystickTouch,
             m_leftPrimaryTouch,
             m_rightPrimaryTouch,
             m_leftSecondaryTouch,
             m_rightSecondaryTouch
            };
        }
    }


    public string[] m_namedVector3= new string[] { "XRLeftHand", "XRRightHand", "XREyes", "XRLeftHandEyes", "XRRightHandEyes" };
    public Vector3 m_leftPositionLocal;
    public Vector3 m_rightPositionLocal;
    public Vector3 m_positionEyesLocal;
    public Vector3 m_leftPositionLocalToEyes;
    public Vector3 m_rightPositionLocalToEyes;
    public Vector3[] V
    {
        get
        {
            return new Vector3[] {
             m_leftPositionLocal,
             m_rightPositionLocal,
             m_positionEyesLocal,
             m_leftPositionLocalToEyes,
             m_rightPositionLocalToEyes
            };
        }
    }

    public string[] m_namedQuaternion = new string[] { "XRLeftHand", "XRRightHand", "XREyes", "XRLeftHandEyes", "XRRightHandEyes" };
    public Quaternion m_leftRotationLocal;
    public Quaternion m_rightRotationLocal;
    public Quaternion m_rotationEyesLocal;
    public Quaternion m_leftRotationLocalToEyes;
    public Quaternion m_rightRotationLocalToEyes;
    public Quaternion[] Q
    {
        get
        {
            return new Quaternion[] {
             m_leftRotationLocal,
             m_rightRotationLocal,
             m_rotationEyesLocal,
             m_leftRotationLocalToEyes,
             m_rightRotationLocalToEyes
            };
        }
    }

    public char GetUniqueCharId()
    {
        return m_uniqueIdToPush;
    }

    public void GetArray(out bool[] values, out string[] namedId)
    {
        values = B; namedId = m_namedBooleans;
    }

    public void GetArray(out float[] values, out string[] namedId)
    {
        values = F; namedId = m_namedFloat;
    }

    public void GetArray(out Vector3[] values, out string[] namedId)
    {
        values = V; namedId = m_namedVector3;
    }

    public void GetArray(out Quaternion[] values, out string[] namedId)
    {
        values = Q; namedId = m_namedQuaternion;
    }
}


