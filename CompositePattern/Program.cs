// See https://aka.ms/new-console-template for more information

using CompositePattern;

Console.WriteLine("----- Composite Pattern -----\n");

FolderComponent mediaFolder = new FolderComponent("Media");

FileComponent track1 = new FileComponent("track1.mp3");
FileComponent track2 = new FileComponent("track2.mp3");
FileComponent track3 = new FileComponent("track3.mp3");


FolderComponent musicFolder = new FolderComponent("music");
musicFolder.AddComponent(track1);
musicFolder.AddComponent(track2);
musicFolder.AddComponent(track3);

mediaFolder.AddComponent(musicFolder);

FolderComponent imagesFolder = new FolderComponent("Images");
FileComponent img1 = new FileComponent("img1.png");
FileComponent img2 = new FileComponent("img2.png");

imagesFolder.AddComponent(img1);
imagesFolder.AddComponent(img2);
mediaFolder.AddComponent(imagesFolder);

mediaFolder.Display();

