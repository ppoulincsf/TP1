class Program
{
  #region LOGOS
    const string MAIN_APP_LOGO = @"

_________ .__                                __                
\_   ___ \|  |__ _____ ____________    _____/  |_  ___________ 
/    \  \/|  |  \\__  \\_  __ \__  \ _/ ___\   __\/ __ \_  __ \
\     \___|   Y  \/ __ \|  | \// __ \\  \___|  | \  ___/|  | \/
 \______  /___|  (____  /__|  (____  /\___  >__|  \___  >__|   
        \/     \/     \/           \/     \/          \/       
__________      .__.__       .___                              
\______   \__ __|__|  |    __| _/___________                   
 |    |  _/  |  \  |  |   / __ |/ __ \_  __ \                  
 |    |   \  |  /  |  |__/ /_/ \  ___/|  | \/                  
 |______  /____/|__|____/\____ |\___  >__|                     
        \/                    \/    \/                         
 ";
  
  #endregion

  
  public static void Main(string[] args)
  {
  
  }

  
  
  #region UTILITY_FUNCTIONS  
  /// <summary>
  /// Permet d'écrire du texte à la console à un endroit précis
  /// </summary>
  /// <param name="text">Le texte à écrire</param>
  /// <param name="x">La colonne à laquelle écrire le texte</param>
  /// <param name="y">La ligne à laquelle écrire le texte.  La première ligne est en haut et le numéro de ligne augmente en descendant</param>
  static void WriteText(string text, int x, int y)
  {
    Console.SetCursorPosition(x, y);
    Console.Write(text);
  }
  /// <summary>
  /// Permet de signaler une erreur à la console à un endroit précis
  /// </summary>
  /// <param name="text">Le texte à écrire</param>
  /// <param name="x">La colonne à laquelle écrire le texte</param>
  /// <param name="y">La ligne à laquelle écrire le texte.  La première ligne est en haut et le numéro de ligne augmente en descendant</param>
  static void WriteError(string text, int x, int y)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    WriteText(text, x, y);
    Console.ForegroundColor = ConsoleColor.White;
  }
  #endregion
}
