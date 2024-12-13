
namespace eh.animation
{
    public struct curve_vertex(float time, float value)
    {
        public float time = time;
        public float value = value;

        public curve_vertex(float flt) : this(flt, flt)
        {

        }
    }
}
