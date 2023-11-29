using System;
namespace Logic
{
	public abstract class ADrawableMatrix : IDrawable, IDecoratable<ADrawableMatrix>
	{
		public ADrawableMatrix() {}

		public abstract void Draw(IDrawer drawer);

		public abstract int DrawableHeight();
		public abstract int DrawableWidth();

        public abstract ADrawableMatrix GetChild();
        public abstract ADrawableMatrix GetEndpoint();

		public abstract IMatrix GetMatrix();
		public abstract void ChangeMatrix(IMatrix matrix);
	}
}

