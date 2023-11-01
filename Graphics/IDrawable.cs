namespace Graphics
{
    public interface IDrawable : Drawable
    {
        public event EventHandler OnMousePressed;
        public event EventHandler OnMouseReleased;
        public event EventHandler OnMouseEntered;
        public event EventHandler OnMouseExited;
    }
}
