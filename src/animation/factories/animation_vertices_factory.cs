
namespace eh.animation
{
    public class animation_vertices_factory
    {
        public static curve_vertices create_linear_curve()
        {
            return new keyframe_vertices();
        }

        public static curve_vertices create_keyframe_curve(params curve_vertex[] keyframes)
        {
            keyframes = [.. keyframes.OrderBy(k => k.value)];
            return new keyframe_vertices(keyframes);
        }
    }
}
