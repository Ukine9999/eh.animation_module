
namespace eh.animation
{
    public class custom_animation_processor(Func<float, float> func) : linear_animation_processor
    {
        private readonly Func<float, float> _func = func;

        public override float process(float current_value, float target_value, float delta_time)
        {
            var linear = base.process(current_value, target_value, delta_time);
            return _func.Invoke(linear);
        }
    }
}
