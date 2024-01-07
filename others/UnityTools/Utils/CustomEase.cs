/*
 * Created by Vincent Diquélou (vincent.diquelou.pro@gmail.com)
*/
using UnityEngine;

namespace Utils
{
    public static class CustomEase
    {
        public static AnimationCurve EaseOutBack = new AnimationCurve(new []{new Keyframe(0,0), new Keyframe(0.8f,1.2f), new Keyframe(1,1)});
        public static AnimationCurve EaseOutBackHard = new AnimationCurve(new []{new Keyframe(0,0), new Keyframe(0.8f,1.4f), new Keyframe(1,1)});
        public static AnimationCurve EaseInBack = new AnimationCurve(new []{new Keyframe(0,0), new Keyframe(0.2f,-.2f), new Keyframe(1,1)});
    }
}
