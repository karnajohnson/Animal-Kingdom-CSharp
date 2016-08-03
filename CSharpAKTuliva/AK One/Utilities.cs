//Rick... I did copy your code for the Utilities class because I wasn't sure how to do it.
//I think it was okay to have the same class as you because we are doing the same thing.
//I am trying to do the rest of the code myself but this particular class I think needs to 
//be the same as yours so that it works properly. I did change the address to the log file
//so that it works on my machine.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tuliva.com.AK.Utilities
{
    public class Utilities
    {
        #region Fields and Properties...
        // Fields ...
        public static string UtilName = "Utilities";  //This is a FILED whose value is DEFINED at the CLASS-LEVEL (not INSTANCE-LEVEL)
        public static bool DoFileLogging = true;
        //Enumerations pertinant to this Class (if any)
        public enum MessageSeverity
        {
            UNKNOWN,
            INFORMATIONAL,
            WARNING,
            ERROR,
            SEVERE,
            FATAL,
            EXCEPTION,
            THERMONUCLEAR
        }

        // Fields for our sealed, utilitarian class
        public static bool doExtraDebugoutput = false;
        #endregion

        #region Constructors...
        // Constructors (if needed)...
        // Note, by definition, a "UTILITARIAN" class contains 'static methods', meaning, we may call those static methods by using ...
        //... the Class Name (NOT an Instance name, since we do not NEED to INSTNTIATE a "Utilities-Object" in order to call a static method.
        // Since this is how we are using this Utilitarian Class, lets ensure NO One can Instantiate this class...

        private Utilities()          //This is an EXPLICITLY-DECLARED, DEFAULT Constructor for this class
        {
            //in Here, we want to ensure that any attempt to instantiate this class will generate and EXCEPTION...
            throw new InvalidOperationException("You CANNOT INSTANTIATE the UTILITIES Class!!!");
            //The above line of code, by THROWING a new Exception, prevents this method from successfully completing.
            //therefore, there is no way to INSTANTIATE a UTILITIES OBJECT...
            //BTW - this is considered GOOD CONTROL, AND Good Security for this Utilitarian Class...
        }
        #endregion

        #region Domain-Specific Methods. In this case, some commonly-used and quickly-called UTILITARIAN Methods...
        // Methods

        public static bool LogIt(string msgToLog)       //Our INITIAL LogIt method (we will OVERLOAD this method later)
        {
            //This particular "Logging" method RETURNS a status-indicator of either True or False.  It just Logs the message passed into it.
            //This UTILITARIAN METHOD exemplifies "Good Modularization", which takes code that is repeated, and organizes that repetitive-code
            //...into a Single, Callable Method.

            //Here is the DECLARATION and DEFINITION (known as an INITIALIZED) VARIABLE within our Method...
            bool rv = false;                            //Start with the "assumption" that Calling this Method resulted in an ERROR (False).

            // NOTE for a list of the built-in Exceptions (to .NET) see URL: 
            //                                          https://mikevallotton.wordpress.com/2009/07/08/net-exceptions-all-of-them/
            try
            {                                        //START of the "Guard-Block", meaning, the F/W will monitor the work done in the "try"
                                                     //... Block to see if any ERRORS or EXCEPTIONS are RAISED.
                System.Console.WriteLine(msgToLog);     // This is the code that is monitored for the possible occurrance of ERRORS / EXCEPTIONS.
                rv = true;                              //If we arrive at this point in our Try-Block, everything worked, so SIGNAL = SUCCESS.
            }

            catch (System.IO.IOException exceptionRaised)
            {
                Console.WriteLine(Utilities.UtilName +
                  " :: Exception Occurred! Exception MESSAGE = " + exceptionRaised.Message);
                rv = false;
            }

            //Since our SIGNATURE indicates that we are to RETURN a bool value, we must explicitly do-so now...
            return rv;                                  //Return whatever value was set for rv, which will vary, depending on the presence
                                                        //...or absence of an IOException Object
        }

        //An Overload of the Logit Method to log to both the Console && a Text File...

        public static void LogIt(string msgToLog, MessageSeverity severity, bool logFileYesNo)
        {
            //This OVERLOAD of our "Utilitarian - LogIt() Method will log to both the CONOLSE and a LOG FILE

            // Firstly, let's Log our MESSAGE and SEVERITY to the Console, so the user can see
            System.Console.WriteLine(severity.ToString() + " -- " + msgToLog);

            // NOTE Before continuing to write to the File, you should REMEMBER that you are preparing to Do I/O.
            // ALL I/O should be GUARD-=BLOCKED (Implement PROPER EXCEPTION HANDLING)
            // Now a little "Prep-Work" to write the same MESSAGE & SEVERITY to the LogFile...
            string LogFile = @"C:\Users\student\Documents\LogFiles\LogFile.txt";      //Use a RELATIVE PATH (from the 'cwd')
            // NOTE - NOTE - NOTE - 
            // When you are doing File I/O, you should "GUARD-BLOCK" your code (which means, do EXCEPTION HANDLING!!!)
            try
            {
                // Check to see that our LogFile EXISTS in the proper directory...
                if (doExtraDebugoutput)
                    Console.WriteLine(File.Exists(LogFile) ? "Log File exists." : "Log File does not exist.");  //Some Console Output
                if (!File.Exists(LogFile))  //If the Folder (directory) does not exist, we must first CREATE IT.
                {
                    System.IO.Directory.CreateDirectory(@"C:\Users\student\Documents\TextFiles");       //Now, we should have our Folder and LogFile created
                    System.Console.WriteLine(@"LogIt :: LogFile Folder created in C:\Users\student\Documents\...");
                }
                // Now, using a 'USING' statement, write the msgToLog string to the LogFile...
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(LogFile, true)) //DO NOT FORGET THE 'APPEND-TRUE' PARAMETER!!!
                {
                    file.WriteLine(severity.ToString() + " -- " + msgToLog);
                    file.Close();
                }
            }   // END of Guard-Block (try-block)...

            catch (Exception e)
            {
                string excptMsg = "EXCEPTION IN UTILITIES::LogIt(): " +
                    e.Message.ToString() + " :: Caused by Inner Exception = " + e.InnerException.ToString() +
                    ":: Exception SOURCE = " + e.Source +
                    ":: Stack Trace Output = " + e.StackTrace + "END-OF-EXCEPTION STUFF";
                Utilities.LogIt(excptMsg,
                    MessageSeverity.EXCEPTION,
                    false);
            }   // End of this SPECIFIC Catch-Handler...

            //finally
            //{
            //    // If a 'finally' block exists, the CLR will try to execute the code within it, regardless of exception or NORMAL
            //    //... program flow.
            //    // This is where you would "Release" any used Resources, like Open Files, Open DB Connections, Ports you used, etc.
            //    // For now, we will simply demonstrate that this 'finally-block' does execute...
            //LogIt("Utilities:: LogIt(): Executing Finally Block after doing LogFile I/O...",
            //    MessageSeverity.INFORMATIONAL, logFileYesNo);
            //}   // END - of Finally-Block
        }
        #endregion


    }
}
