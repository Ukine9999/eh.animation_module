
namespace eh.animation
{
    public class ease_in_animation_processor : linear_animation_processor
    {
        public override float process(float current_value, float target_value, float delta_time)
        {
            var linear = base.process(current_value, target_value, delta_time);
            return linear * linear;
        }
    }
}
