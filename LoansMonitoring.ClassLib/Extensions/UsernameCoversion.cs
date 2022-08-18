namespace LoansMonitoring.ClassLib.Extensions;
public class UsernameCoversion
{
   /// <summary>
   /// Username Conversion
   /// </summary>
   /// <param name="name"></param>
   /// <returns>First letter of each word of User's first name</returns>
   public static string Username(string name)
   {
      var _trimDoubleSpace = name.Replace("  ", " ");
      var _trimWhiteSpace = _trimDoubleSpace.Trim();

      bool _space = _trimWhiteSpace.Contains(" ");
      if (_space)
      {
         int index = _trimDoubleSpace.IndexOf(" ");
         var a = _trimWhiteSpace.Substring(0, 1).ToLower();
         var b = _trimWhiteSpace.Substring(index + 1, 1).ToLower();
         return a + b;
      }
      else
      {
         return _trimWhiteSpace.Substring(0, 1).ToLower();
      }
   }
}
