
namespace eh.animation
{
    public class animation_processor_factory
    {
        public static i_animation_processor create_linear()
        {
            return new linear_animation_processor();
        }

        public static i_animation_processor create_ease_in()
        {
            return new ease_in_animation_processor();
        }

        public static i_animation_processor create_ease_out()
        {
            return new ease_in_animation_processor();
        }

        public static i_animation_processor create_ease_out_in()
        {
            return new ease_in_out_animation_processor();
        }

        public static i_animation_processor create_custom(Func<float, float> func)
        {
            return new custom_animation_processor(func);
        }
    }
}
