/*
 * author: amir kamalian
 * date:   29 jan 2O23
 * 
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1 {
 
      class Marketing {

          public void Start() {
              SectionTen.Posted += HasPosted;
          }

          void HasPosted() {
              Console.WriteLine("Thank you for completing the survey. You are now subscribed to ten of out newsletters.");
          }
          
      }
 
}

 