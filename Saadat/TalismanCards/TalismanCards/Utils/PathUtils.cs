using System;

namespace TalismanCards.Utils
{
    internal class PathUtils
    {
        public static String IMAGES_PATH = "imgs/";
        public static String CARDS_IMAGE_PATH = PathUtils.IMAGES_PATH + "cards/";
        public static String getPathToCard(CardType type, String name)
        {
            return PathUtils.CARDS_IMAGE_PATH + type.ToString() + "_" + name + ".png";
        }
    }
}