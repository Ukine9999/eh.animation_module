
namespace eh.animation
{
    public interface i_animator
    {
        float value { get; }

        void animate(float delta);
    }
}