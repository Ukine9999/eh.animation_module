using UnityEngine;

namespace eh.animation
{
    public class ease_in_out_animation_processor : linear_animation_processor
    {
        public override float process(float current_value, float target_value, float delta_time)
        {
            var linear = base.process(current_value, target_value, delta_time);
            return linear < 0.5 ? 2 * linear * linear : 1 - Mathf.Pow(-2 * linear + 2, 2) / 2;
        }
    }
}
