using UnityEngine;

namespace eh.animation
{
    public class ease_out_animation_processor : linear_animation_processor
    {
        public override float process(float current_value, float target_value, float delta_time)
        {
            var linear = base.process(current_value, target_value, delta_time);
            return 1.0f - Mathf.Pow(1.0f - linear, 2.0f);
        }
    }
}
