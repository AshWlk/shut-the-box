namespace ShutTheBox
{
    internal struct Box
    {
        public int Value { get; }

        public bool IsShut { get; }

        public Box(int value, bool isShut = false)
        {
            this.Value = value;
            this.IsShut = isShut;
        }
    }
}
