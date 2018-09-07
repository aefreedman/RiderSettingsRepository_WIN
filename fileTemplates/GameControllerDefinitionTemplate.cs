using Audio;
using Entitas;
using EntitasInput;
using Game;
using SecretCrush.GameController;
using SecretCrush.ScriptableObject;
using State;
using Zenject;


    public class $fileName : IGameControllerDefinition
    {
        private const string AllSystemsName = "Systems";
        private const string InputSystemsName = "Input Systems";

        [Inject] private AudioAssetSettings _audioAssetSettings;
        [Inject] private GameSettings _gameSettings;
        [Inject] private DiContainer _container;

        public Systems CreateSystems(Contexts c)
        {
            var feature = new Feature(AllSystemsName);

            feature.Add(new StateInitializeSystem(c));
            

            feature.Add(new AudioSystems(c, _gameSettings, _audioAssetSettings));
            feature.Add(new InputSystems(c));

            feature.Add(new GameInitializeSystem());
            
            feature.Add(new StateExecuteSystem(c));
            feature.Add(new ExecuteTimerSystem());

            feature.Add(new StateReactiveSystem(c, _audioAssetSettings));

            feature.Add(new StateCleanupSystem());
            feature.Add(new InputCleanupSystem());


            return feature;
        }

        private void OnDestroy()
        {
//            Entitas.Systems.DeactivateReactiveSystems();
        }

        private sealed class InputSystems : Feature
        {
            internal InputSystems(Contexts c)
                : base(InputSystemsName)
            {
                Add(new InputEmitSystem(c));
            }
        }

        private sealed class AudioSystems : Feature
        {
            internal AudioSystems(Contexts c, GameSettings gameSettings, AudioAssetSettings audioAssetSettings)
                : base("Audio Systems")
            {
                Add(new AudioReactiveGameStateChangeSystem(c, audioAssetSettings));
                Add(new AudioReactiveOneShotSystem(c, audioAssetSettings));
                Add(new AudioReactiveChangeTrackSystem(c));
            }
        }
    }
