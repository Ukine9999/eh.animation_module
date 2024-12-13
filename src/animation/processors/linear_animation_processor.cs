using UnityEngine;

namespace eh.animation
{
    public class linear_animation_processor : i_animation_processor
    {
        public virtual float process(float current_value, float target_value, float delta_time)
        {
            return Mathf.MoveTowards(current_value, target_value, delta_time);
        }
    }
}
