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
    Data container for user submissions
    \\ End of Description
    * 
    \\ Attributes(fields)
        DataTime datePublished;
        string text;
        Dictionary<string, Translation> automatic Translations;
        ArrayList userTranslations;
        int views;
        string userHostAddress;
    \\ENd of Attributes(fields)
    * 
    \\Attribute Descriptions
        datePublished tracks when the submission as published to the IMW database.
    ---------------------------------------------------------------
        text contains the "story" submitted by the user
    ---------------------------------------------------------------
        automaticTranslations is a dictionary that contains all of the translations performed by Translation API. 
            The language in string format serves as the key in the key-value pairing.
    ---------------------------------------------------------------
        userTranslations is an array list containing all of the user submitted translations. The data structure
            used for this field is subject to change or removal.
    ---------------------------------------------------------------
        views tracks the number of views this submission has received.
    ---------------------------------------------------------------
        userHostAddress contains the IP address of the user.
    \\ end of Attribute Descriptions
    * 
    * 
    * \\ ENd of Summary
   */
    public class Submission
    {
        
        private DateTime datePublished;
        private string text;
        private Dictionary<string, Translation> automaticTranslations;
        private ArrayList userTranslations;
        private int views;
        private string userHostAddress;


        //mutators
        public void setDataPublished(DateTime x)
        {
            datePublished = x;
        }

        public void setText(string x)
        {
            text = x;
        }

        public void setAutomaticTranslations(Dictionary<string, Translation> x)
        {
            automaticTranslations = x;
        }

        public void setUserTranslations(ArrayList x)
        {
            userTranslations = x;
        }

        public void setViews(int x)
        {
            views = x;
        }

        public void setUserHostAddress(string x)
        {
            userHostAddress = x;
        }


        //accessors
        public DateTime getDatePublished()
        {
            return datePublished;
        }

        public string getText()
        {
            return text;
        }

        public Dictionary<string, Translation> getAutomaticTranslations()
        {
            return automaticTranslations;
        }

        public ArrayList getUserTranslations()
        {
            return userTranslations;
        }

        public int getViews()
        {
            return views;
        }

        public string getUserHostAddress()
        {
            return userHostAddress;
        } 


        //methods
        public bool incrementViews()
        {
            if (views >= 0) { 
            views++;
            return true;
            } else{
                return false;
            }
    }

  
}
