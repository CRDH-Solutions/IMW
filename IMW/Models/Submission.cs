using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace IMW.Models
{
    /*\\Summary
     * 
     * 
     \\Description
     Data container for user submissions
     \\ End of Description
     * 
     \\ Attributes(fields)
         string SubmissionHash;
         DataTime DatePublished;
         string Text;
         Dictionary<string, Translation> AutomaticTranslations;
         ArrayList UserTranslations;
         int Views;
         string UserHostAddress;
     \\ENd of Attributes(fields)
     * 
     \\Attribute Descriptions
         SubmissionHash functions as the ID for the EF database
     ---------------------------------------------------------------
         DatePublished tracks when the submission as published to the IMW database.
     ---------------------------------------------------------------
         Text contains the "story" submitted by the user
     ---------------------------------------------------------------
         AutomaticTranslations is a dictionary that contains all of the translations performed by Translation API. 
             The language in string format serves as the key in the key-value pairing.
     ---------------------------------------------------------------
         UserTranslations is an array list containing all of the user submitted translations. The data structure
             used for this field is subject to change or removal.
     ---------------------------------------------------------------
         Views tracks the number of views this submission has received.
     ---------------------------------------------------------------
         UserHostAddress contains the IP address of the user.
     \\ end of Attribute Descriptions
     * 
     * 
     * \\ ENd of Summary
    */
    public class Submission
    {
        [Key]
        public string SubmissionHash { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Dictionary<string, Translation> AutomaticTranslations { get; set; }
        public ArrayList UserTranslations;
        public int Views { get; set; }
        public string UserHostAddress { get; set; }



        public Submission()
        {
            DatePublished = DateTime.Now;
            Text = string.Empty;
            AutomaticTranslations = new Dictionary<string, Translation>();
            UserTranslations = new ArrayList();
            Views = 0;
            UserHostAddress = string.Empty;
        }
        
        //methods
        public bool incrementViews()
        {
            if (Views >= 0)
            {
                Views++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class SubmissionDBContext : DbContext
    {
        public DbSet<Submission> Submissions { get; set; }
    }
  
}
