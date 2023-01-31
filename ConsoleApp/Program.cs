using ConsoleApp.Services;

var menu = new MenuManagement();

menu.DocPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";
while (true)
{
    Console.Clear();
    menu.WelcomeMenu();
}
