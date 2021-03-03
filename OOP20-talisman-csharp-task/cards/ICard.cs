namespace DefaultNamespace
{
    public interface ICard
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>The name of the card</returns>
        string GetName();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The text of the card</returns>
        string GetText();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The type of the card</returns>
        string GetType();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The image path of the card</returns>
        string GetImagePath();
    }
}