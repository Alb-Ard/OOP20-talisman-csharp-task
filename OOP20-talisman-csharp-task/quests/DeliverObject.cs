using System;

namespace TalismanCSHARP.quests
{
    public class DeliverObject : TalismanQuest
    {
        public new static long SerialVersionUid = 522224177252193499L;
    
        private readonly QuestObjectType _objectType;

        /**
     * The Quest requires an object to deliver, it can be chosen or let the game decide random
     *
     * @param objectType the object to deliver
     */
        public DeliverObject(QuestObjectType.Type type)
        {
            this._objectType = new QuestObjectType(type);
        }

        public DeliverObject()
        {
            this._objectType = new QuestObjectType();
        } 
        /**
     * Get the object to deliver
     *
     * @return an instance of the object
     */
        public QuestObjectType.Type getObjectType(){

            return _objectType.GetType();
        }

        /**
     * Get a description of the objective for the current quest
     *
     * @return the description of the object to deliver
     */
        public string ToString()
        {

            return _objectType.ToString();
        }
    }
}