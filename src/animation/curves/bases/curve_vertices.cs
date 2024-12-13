using UnityEngine;

namespace eh.animation
{
    public abstract class curve_vertices(params curve_vertex[] keys) : i_curve_vertices
    {
        private readonly List<curve_vertex> _keys = keys.Length < 2 ? [new(0.0f), new(1.0f)] : [.. keys];

        public int count
        {
            get
            {
                return _keys.Count;
            }
        }

        public curve_vertex this[int index]
        {
            get
            {
                return _keys[index];
            }
        }

        public virtual void add_vertex(curve_vertex vertex)
        {
            vertex.time = Mathf.Clamp01(vertex.time);
            vertex.value = Mathf.Clamp01(vertex.value);

            _keys.Append(vertex);
            _keys.Sort((a, b) => a.time.CompareTo(b.time));
        }

        public virtual void add_vertex(float time, float value)
        {
            time = Mathf.Clamp01(time);
            value = Mathf.Clamp01(value);

            _keys.Append(new(time, value));
            _keys.Sort((a, b) => a.time.CompareTo(b.time));
        }

        public abstract curve_vertex get_vertex(float time);
    }
}
