using JeuProjetFinal;
using JeuProjetFinal.AbstractFactory;
using JeuProjetFinal.Adapter;
using JeuProjetFinal.Bridge;
using JeuProjetFinal.Builder;
using JeuProjetFinal.Composite;
using JeuProjetFinal.Decorator;
using JeuProjetFinal.Facade;
using JeuProjetFinal.Factory_method;
using JeuProjetFinal.Proxy;
using JeuProjetFinal.Singleton;
using JeuProjetFinal.State;

//// Décorateur
//IPotion potion = new Potion();
//IPotion multiplyPotion = new MultiplyPotion(potion);

//Console.WriteLine(potion.Give());
//Console.WriteLine(multiplyPotion.Give());
//Console.WriteLine(new MultiplyPotion(multiplyPotion).Give());

//// Proxy
//IPlaneteProxy proxy = new CachePlaneteProxy();
//var list = proxy.GetList();

//// Bridge
//ICharacter character = new Enemy(new Baguette());

//// Composite
//var powerContainer = new PowerContainer("Gilet Flik");
//powerContainer.Add(new ForcePower(2));
//powerContainer.Add(new LifePower(4));


//var powerContainer2 = new PowerContainer("Child");
//powerContainer.Add(powerContainer2);

//powerContainer2.Add(new LifePower(10));

//// Facade
//GameSaver saver = new GameSaver("ic");
//saver.Save(new Game());

//// Adapter
//var npc = new NPC(new WizardLanguage());
//npc.Speak("Hello, Harry !");

//var npcSerpentar = new NPC(new FourcheLangAdapter(new FourcheLang()));
//npc.Speak("Comment vas-tu ?");

//// Singleton
//GameMotor motor = GameMotor.Instance;
//motor.StartNewGame();

//// Builder
//GameDirector director = new (new DefaultGameBuilder());
//Game? game = director.Build();

//// Factory method
//IPotion position = (new PotionCreator()).Create(1);

//// Abstract factory
//IQuestFactory<Level1Category> factory = new RpgQuestFactory<Level1Category>();
//var rewards = factory.CreateRewards();

// State
Player player = new();
player.RequestInput(() =>
{
    Console.ForegroundColor= ConsoleColor.DarkYellow;
    Console.WriteLine("Please set the input");
    Input input = new (Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.White;

    return input;
});

