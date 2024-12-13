
namespace eh.animation
{
    public interface i_curve_vertices
    {
        curve_vertex get_vertex(float time);

        curve_vertex this[int index] { get; }
    }
}
