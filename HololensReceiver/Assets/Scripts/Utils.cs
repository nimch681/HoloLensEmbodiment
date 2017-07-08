using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour {

    public struct Point2f
    {
        public float X;
        public float Y;
    }

    public struct Point3f
    {
        public float X;
        public float Y;
        public float Z;
    }

    public enum TrackingState
    {
        TrackingState_NotTracked = 0,
        TrackingState_Inferred = 1,
        TrackingState_Tracked = 2
    }

    public enum JointType
    {
        JointType_SpineBase = 0,
        JointType_SpineMid = 1,
        JointType_Neck = 2,
        JointType_Head = 3,
        JointType_ShoulderLeft = 4,
        JointType_ElbowLeft = 5,
        JointType_WristLeft = 6,
        JointType_HandLeft = 7,
        JointType_ShoulderRight = 8,
        JointType_ElbowRight = 9,
        JointType_WristRight = 10, 
        JointType_HandRight = 11,
        JointType_HipLeft = 12,
        JointType_KneeLeft = 13,
        JointType_AnkleLeft = 14,
        JointType_FootLeft = 15,
        JointType_HipRight = 16,
        JointType_KneeRight = 17,
        JointType_AnkleRight = 18,
        JointType_FootRight = 19,
        JointType_SpineShoulder = 20,
        JointType_HandTipLeft = 21,
        JointType_ThumbLeft = 22,
        JointType_HandTipRight = 23,
        JointType_ThumbRight = 24,
        JointType_Count = (JointType_ThumbRight + 1)
    }

    public struct Joint
    {
        public Point3f position;
        public JointType jointType;
        public TrackingState trackingState;
    }

    public struct Body
    {
        public bool bTracked;
        public List<Joint> lJoints;
        public List<Point2f> lJointsInColorSpace;
    }

}
