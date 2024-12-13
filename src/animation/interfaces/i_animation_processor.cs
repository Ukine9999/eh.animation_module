
namespace eh.animation
{
    public interface i_animation_processor
    {
        float process(float current_value, float target_value, float delta_time);
    }
}
