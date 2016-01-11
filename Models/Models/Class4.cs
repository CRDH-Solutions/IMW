using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
 /*\\Summary
 * 
 * 
 \\Description
  Data structure to create and populate EF tables
 \\ End of Description
 * 
 \\ Attributes(fields)
     string submissionHash
     DateTime datePublished
     string text
     string language
     string userHostAddress
 \\ENd of Attributes(fields)
 * 
 \\Attribute Descriptions
    submissionHash is the hash of the submission. This will allow for o(1) lookup times.
        Will serve as the primary key of the relation.
 -----------------------------------------------------
    datePublished trachs when the submission was published to teh IMW database.
 -----------------------------------------------------
    text contains the translation submitted by the user
 -----------------------------------------------------
    language contains the language of the translation
 -----------------------------------------------------
    userHostAddress contains the IPaddress of the user
 \\ end of Attribute Descriptions
 * 
 * 
 * \\ ENd of Summary
*/
    class Translations
    {
        string submissionHash;
        DateTime datePublished;
        string text;
        string language;
        string userHostAdress;
    }
}
