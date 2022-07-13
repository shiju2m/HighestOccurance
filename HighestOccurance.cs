/*Challenge 2: 
Write a solution to find the character that has the highest number of occurrences within a certain string, ignoring 
case. If there is more than one character with equal highest occurrences, return the character that appeared first 
within the string. 
For example: 
     Input: "Character" 
     Output: c
Program for Challenge 2 is as follows
*/


using System; 

   public class HighestOccurance { 
      public static void Main(){ 
         Console.WriteLine("Please enter a String ");
         //storing the string as lowercase to avoid case sensitivity
         String str = Console.ReadLine().ToLower();
         //declaring an integer array with size 128
         int []charCount = new int[128]; 
         //storing the length of the input character
         int length = str.Length; 
         /*using a for loop and the value in charCount is incremented corresponding to the character in the string*/
         for (int i = 0; i < length; i++){
            charCount[str[i]]++; 
         }
         //declaring maxCount to find the maximum count
         int maxCount = 0; 
         //declaring character to get the max occur charcter
         char character = ' ';
         /*The values of maxCount and character can be determined using a for loop. */
         for (int i = 0; i < length; i++){ 
            if (maxCount < charCount[str[i]]){ 
               maxCount = charCount[str[i]]; 
               character = str[i]; 
            } 
         }  
         Console.WriteLine("The highest occurring character in the given string is: " + character);
      } 
   } 

