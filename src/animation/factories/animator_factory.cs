
namespace eh.animation
{
    public class animator_factory
    {
        private static readonly i_curve_vertices linear_curve = animation_vertices_factory.create_linear_curve();

        private static readonly i_animation_processor ease_out_processor = animation_processor_factory.create_ease_out();
        private static readonly i_animation_processor ease_in_processor = animation_processor_factory.create_ease_in();
        private static readonly i_animation_processor ease_in_out_processor = animation_processor_factory.create_ease_out_in();
        private static readonly i_animation_processor linear_processor = animation_processor_factory.create_linear();

        public static i_animator create(i_curve_vertices curve_vertices, i_animation_processor curve_processor,
             float scale_multiplier = 1.0f, float animation_speed_multiplier = 1.0f, bool looped = false, bool reversed = false)
        {
            return new animator(curve_vertices, curve_processor, scale_multiplier, animation_speed_multiplier)
            {
                loop = looped,
                reversed = reversed
            };
        }

        public static i_animator create_linear(float scale_multiplier = 1.0f, float animation_speed_multiplier = 1.0f, bool looped = false, bool reversed = false)
        {
            return create(linear_curve, linear_processor, animation_speed_multiplier, scale_multiplier, looped, reversed);
        }

        public static i_animator create_ease_in(float scale_multiplier = 1.0f, float animation_speed_multiplier = 1.0f, bool looped = false, bool reversed = false)
        {
            return create(linear_curve, ease_in_processor, animation_speed_multiplier, scale_multiplier, looped, reversed);
        }

        public static i_animator create_ease_out(float scale_multiplier = 1.0f, float animation_speed_multiplier = 1.0f, bool looped = false, bool reversed = false)
        {
            return create(linear_curve, ease_out_processor, animation_speed_multiplier, scale_multiplier, looped, reversed);
        }

        public static i_animator create_ease_in_out(float scale_multiplier = 1.0f, float animation_speed_multiplier = 1.0f, bool looped = false, bool reversed = false)
        {
            return create(linear_curve, ease_in_out_processor, animation_speed_multiplier, scale_multiplier, looped, reversed);
        }

        public static i_animator create_custom(Func<float, float> custom_evaluate, float scale_multiplier = 1.0f, float animation_speed_multiplier = 1.0f, bool looped = false, bool reversed = false)
        {
            return create(linear_curve, new custom_animation_processor(custom_evaluate), animation_speed_multiplier, scale_multiplier, looped, reversed);
        }
    }
}
