// ReSharper disable InconsistentNaming

using LostMemories.DialogueStateMachine;
using SecretCrush.PrototypingKit;
using UnityEngine;

namespace LostMemories.DialogueTree.DialogueNodes
{
    // name of the class after DialogueNode_ must match the filename
    public class DialogueNode_$name : IDialogueNode
    {
        private const string ChoiceA = "FILENAME_HERE";
        private const string ChoiceB = "FILENAME_HERE";

        private string _debugLabel;

        public void Dispose()
        {
            Debug.Log(_debugLabel + "Dialogue tree ended for " + GetType());
        }

        public NodeChoice GetNodeChoices(HistoryContext historyContext)
        {
            // consult current game state to determine what dialogue the player has seen
            // add whatever custom logic to determine which choices this method returns;
            // returning a null NodeChoice object will stop the choice popup window from appearing

            /* Example
            var history = historyContext.GetGroup(HistoryMatcher.ChatNode).GetEntities();
            var hasSeenAmy_1_1 = historyContext.GetEntitiesWithChatNode(ChoiceA).Count > 0;
            */

            // return new NodeChoice { Choices = null }; // terminal node

            var choice = new NodeChoice
                         {
                             Choices = new[] {ChoiceA, ChoiceB}
                         };
            return choice;
        }

        public void Initialize()
        {
            _debugLabel = DebugStringFormatter.TypeLabel(this, "blue");
            Debug.Log(_debugLabel + "Dialogue tree started for " + GetType());
        }
    }
}