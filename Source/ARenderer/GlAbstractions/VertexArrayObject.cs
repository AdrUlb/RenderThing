using ARenderer.Gl;

namespace ARenderer.GlAbstractions;

public readonly struct VertexArrayObject : IDisposable
{
	private readonly IGlApi gl;
	public readonly uint Id;
    
	public VertexArrayObject(IGlApi gl)
	{
		this.gl = gl;
		Id = gl.GenVertexArray();
	}

	public void Dispose() => gl.DeleteVertexArray(Id);
}
