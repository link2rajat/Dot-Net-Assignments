using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PhoneBookRESTXMLService
{
   public class PhoneBookRESTXMLService : IPhoneBookRESTXMLService
   {
      // create a dbcontext object to access PhoneBook database
      private PhoneBookEntities dbcontext = new PhoneBookEntities();

      // add an entry to the phone book database
      public void AddEntry(string lastName, string firstName,
         string phoneNumber)
      {
         // create PhoneBook entry to be inserted in database
         PhoneBook 
         // insert PhoneBook entry in database
        _______________________________
      } // end method AddEntry

      // retrieve phone book entries with a given last name
      ________________________________________
}

