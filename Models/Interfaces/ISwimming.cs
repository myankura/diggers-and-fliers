namespace diggers_and_fliers
{
    public interface ISwimming
    {
        void Swim();

        //In feet
        int MaximumDepth { get; set; }
    }
}