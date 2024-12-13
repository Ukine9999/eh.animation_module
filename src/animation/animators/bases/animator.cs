
namespace eh.animation
{
    public class animator(i_curve_vertices curve, i_animation_processor curve_processor, float animation_speed = 1.0f, float scale_multiplier = 1.0f) : i_animator
    {
        private float _animation_value = 0.0f;

        public float value
        {
            get
            {
                return _animation_value * scale_multiplier;
            }
            set
            {
                _animation_value = value;
            }
        }

        public i_curve_vertices curve { get; } = curve;

        public i_animation_processor processor { get; } = curve_processor;

        public float animation_speed_multiplier { get; set; } = animation_speed;

        public float scale_multiplier { get; set; } = scale_multiplier;

        public bool reversed { get; set; }

        public bool loop { get; set; }

        public virtual void animate(float delta)
        {
            delta *= animation_speed_multiplier;

            if (reversed)
                delta = -delta;

            var target = curve.get_vertex(_animation_value + delta).value;

            if(target != _animation_value)
                _animation_value = processor.process(_animation_value, target, delta);
            else if(loop)
                _animation_value = reversed ? 0.0f : 1.0f;
        }
    }
}