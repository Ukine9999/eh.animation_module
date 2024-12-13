

namespace eh.animation
{
    public class keyframe_vertices(params curve_vertex[] keys) : curve_vertices(keys)
    {
        public override curve_vertex get_vertex(float time)
        {
            if (time <= this[0].time)
                return this[0];

            if (time >= this[count - 1].time)
                return this[count - 1];

            for (var i = 0; i < count - 1; i++)
            {
                if (time >= this[i].time && time < this[i + 1].time)
                    return this[i + 1];
            }

            return this[count - 1];
        }
    }
}
