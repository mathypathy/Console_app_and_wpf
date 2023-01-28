using ConsoleApp.Services;

var menu = new MenuManagement();
var docu = new DocumentManagement();
docu.DocPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";
while (true)
{
    Console.Clear();
    menu.WelcomeMenu();
}
