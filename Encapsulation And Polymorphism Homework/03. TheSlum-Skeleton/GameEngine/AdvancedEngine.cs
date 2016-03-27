using System;
using System.Linq;
using TheSlum.GameObjects;
using TheSlum.GameObjects.Characters;
using TheSlum.GameObjects.Items;

namespace TheSlum.GameEngine
{
    public class AdvancedEngine: Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            base.ExecuteCommand(inputParams);
            switch (inputParams[0])
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItemToCharacter(inputParams);
                    break;
                default:
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            string characterType = inputParams[1];
            string id = inputParams[2];
            int x = int.Parse(inputParams[3]);
            int y = int.Parse(inputParams[4]);
            Team team = (Team)Enum.Parse(typeof(Team), inputParams[5]);
           
            Character character = CharacterFactory.Create(characterType, id, team, x, y);
            characterList.Add(character);
        }


        protected void AddItemToCharacter(string[] inputParams)
        {
            string id = inputParams[1];
            Character character = characterList.FirstOrDefault(c => c.Id == id);
            Item item = ItemFactory.Create(inputParams[2], inputParams[3]);
            character.AddToInventory(item);
        }
    }
}
