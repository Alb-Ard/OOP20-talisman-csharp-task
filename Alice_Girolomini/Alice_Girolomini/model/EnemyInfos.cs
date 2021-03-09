using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_Girolomini
{
    /// <summary>A class that helps accessing enemy's informations.</summary>
    public static class EnemyInfos
    {
        private static List<IEnemyModel> enemies = new List<IEnemyModel>();

        /// <summary>Gets the enemy at the specified index.</summary>
        /// <param name="index">index of the enemy</param>
        /// <returns>the enemy</returns>
        public static IEnemyModel GetEnemyByIndex(int index)
        {
            return EnemyInfos.enemies[index];
        }

        /// <summary>Gets the enemy with the specified name.</summary>
        /// <param name="name">the enemie's name</param>
        /// <returns>the enemy</returns>
        public static IEnemyModel GetEnemyByName(String name)
        {
            for (int i = 0; i < GetEnemyCount(); i++)
            {
                if (GetEnemyByIndex(i).GetName().Equals(name))
                {
                    return GetEnemyByIndex(i);
                }
            }
            return null;
        }

        /// <summary>Adds the enemy to the enemies' list.</summary>
        /// <param name="enemy">the enemy to add</param>
        /// <returns>the index of the new enemy</returns>
        public static int AddEnemy(IEnemyModel enemy)
        {
            EnemyInfos.enemies.Add(enemy);
            return EnemyInfos.enemies.FindIndex(x => x.Equals(enemy));
        }

        /// <summary>Gets the number of enemies.</summary>
        /// <returns>the value</returns>
        public static int GetEnemyCount()
        {
            return EnemyInfos.enemies.Count;
        }

        /// <summary>Checks whether the enemy uses strength or craft.</summary>
        /// <param name="index">index of the enemy</param>
        /// <returns>true if the enemy uses strength</returns>
        public static bool HasStrength(int index)
        {
            return EnemyInfos.enemies[index].GetStrength() > 0;
        }
    }
}
