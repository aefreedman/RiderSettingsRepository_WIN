using SecretCrush.Entitas.GameController;
using Zenject;


    /// <summary>
    /// Populate this Installer with bindings for your game controller definitions
    /// </summary>
    public class $ClassName : MonoInstaller<$ClassName>
    {
        public override void InstallBindings()
        {
            Container.Bind<IGameControllerDefinition>().To<$ControllerDefinition>().AsSingle();
        }
    }
