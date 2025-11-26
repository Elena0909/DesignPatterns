// See https://aka.ms/new-console-template for more information
using ObserverPattern.Publishers;
using ObserverPattern.Subscribers;

Console.WriteLine("---- Observer Pattern ----\n");
Console.WriteLine("Sport Publisher:");

SportNewsPublisher sportPublisher = new SportNewsPublisher();

SportNewsSubscriber sportSubscriber1 = new SportNewsSubscriber(sportPublisher);
SportNewsSubscriber sportSubscriber2 = new SportNewsSubscriber(sportPublisher);


sportPublisher.SetLastSportInfo("Chelsea - Arsenal 1:1");

Console.WriteLine("\nTech Publisher:");

TechnologyNewsPublisher techPublisher = new TechnologyNewsPublisher();

TechnologyNewsSubscriber techSubscriber1 = new TechnologyNewsSubscriber(techPublisher);
TechnologyNewsSubscriber techSubscriber2 = new TechnologyNewsSubscriber(techPublisher);
TechnologyNewsSubscriber techSubscriber3 = new TechnologyNewsSubscriber(techPublisher);

techPublisher.SetLastRtxPrice(3.2m);